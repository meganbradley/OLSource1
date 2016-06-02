---
title: Security Overview (SQL Server R Services)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - r-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8fc84754-7fbf-4c1b-9150-7d88680b3e68
---
# Security Overview (SQL Server R Services)

This topic describes the overall security architecture that is used to connect the [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)] database engine and related components to the R runtime. Examples of the security process are provided for two common scenarios for using R in an enterprise environment:

+ Executing RevoScaleR functions in [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)] from a data science client
+ Running R directly from [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)] using stored procedures

## Security Overview

A [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)] login or Windows user account is required to run all R jobs that utilize [!INCLUDE[rsql_productname_md](../../Token\Other/rsql_productname_md.md)]. The login or user account identifies the *security principal*, who must have permission to access the database where R is run, as well as permissions to read data from secured objects such as tables, or to write new data or add new objects if required by the R job.

Therefore, it is a strict requirement that each person who runs R code against [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)] must be mapped to a login in the database, regardless of whether that code is sent from a remote data science client using the RevoScaleR functions or started using a T-SQL stored procedure. 

For example, assume that you created some R code that runs on your laptop, and you want to run that code on [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)]. You must ensure that the following conditions are met:

+ The database allows remote connections.
+ A SQL login with the name and the password that you used in the R code has been added to the [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)] at the instance level. Or, if you are using Windows integrated authentication, the Windows user specified in the connection string must be added as a user on the instance.
+ The SQL login or Windows user must be granted the permission to execute external scripts. Generally, this permission can only be added by a database administrator.
+ The SQL login or Window user must be added as a user, with appropriate permissions, in each database where the R job performs any of these operations:
	+ Retrieving data
	+ Writing or updating data 
	+ Creating new objects, such as tables or stored procedures

After the login or Windows user account has been provisioned and given the necessary permissions, you can run R code on [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)] by using an R data source object or by calling stored procedures. Whenever R is started from [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)], the database engine security gets the security context of the user who started the R job, and manages the mappings of the user or login to securable objects. 

Therefore, all R jobs that are initiated from a remote client must specify the login or user information as part of the connection string.


## Interaction of [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)] Security and LaunchPad Security

When an R script is executed in the context of the [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)] computer, the [!INCLUDE[rsql_launchpad_md](../../Token\Other/rsql_launchpad_md.md)] service gets an available worker account (a local user account) from a pool of worker accounts established for external process and uses that worker account to perform the related tasks. 

For example, if you start an R job under your Windows domain credentials, your account might be mapped to the Launchpad worker account *SQLRUser01*.

After mapping to a worker account, [!INCLUDE[rsql_launchpad_md](../../Token\Other/rsql_launchpad_md.md)] creates a user token that is used to start processes. 

When all [!INCLUDE[ssNoVersion_md](../../Token\Other/ssNoVersion_md.md)] operations are completed, the user worker account is marked as free and returned to the pool.

For more information about [!INCLUDE[rsql_launchpad_md](../../Token\Other/rsql_launchpad_md.md)], see [New Components in SQL Server to Support R Integration](../../Topics\TopicNameNotContainA/New-Components-in-SQL-Server-to-Support-R-Services.md).

## Security of Worker Accounts
This mapping of an external Windows user or valid SQL login to a worker account is valid only for the lifetime of the lifetime of the SQL query that runs the R script. 

Parallel queries from the same login are mapped to the same user worker account.

The directories used for the processes are managed by the [!INCLUDE[rsql_launchpad_md](../../Token\Other/rsql_launchpad_md.md)] using RLauncher, and directories are access-restricted. The worker account cannot access any files in folders above its own, but it can read, write, or delete children under the session working folder that was created for the SQL query with the R script.

For more information about how to change the number of worker accounts, account names, or account passwords, see [Modify the User Account Pool for SQL Server R Services](../../Topics\TopicNameNotContainA/Modify-the-User-Account-Pool-for-SQL-Server-R-Services.md).


## Security Isolation for Multiple External Scripts

The isolation mechanism is based on on physical user accounts. As satellite processes are started for a specific language runtime, each satellite task uses the worker account specified by the [!INCLUDE[rsql_launchpad_md](../../Token\Other/rsql_launchpad_md.md)]. If a task requires multiple satellites, for example, in the case of parallel queries, a single worker account is used for all related tasks.

No worker account can see or manipulate files used by other worker accounts.
 
If you are an administrator on the computer, you can view the directories created for each process. Each directory is identified by its session GUID.

## See Also
[Architecture Overview](Architecture%20Overview%20\(SQL%20Server%20R%20Services\).md)