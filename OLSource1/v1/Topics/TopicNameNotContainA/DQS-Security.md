---
title: DQS Security
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - data-quality-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 921927f5-1b1e-452a-a79e-c691829fd826
---
# DQS Security
  The [!INCLUDE[ssDQSnoversion](../../Token\Other/ssDQSnoversion_md.md)] \(DQS\) security infrastructure is based upon the SQL Server security infrastructure. A database administrator grants a user a set of permissions by associating the user with a DQS role. Doing so determines the DQS resources that the user has access to and the functional activities that the user is allowed to perform.  
  
## DQS Roles  
 There are four roles for DQS. One is the database administrator \(DBA\) who deals primarily with product installation, database maintenance, and user management. This role primarily uses the SQL Server Management Studio, rather than within the [!INCLUDE[ssDQSClient](../../Token\Other/ssDQSClient_md.md)] application. Their server role is sysadmin.  
  
 The three other roles are information workers, data stewards who use the product directly by working in the [!INCLUDE[ssDQSClient](../../Token\Other/ssDQSClient_md.md)] application. These roles include the following:  
  
-   The **DQS Administrator** \(dqs\_administrator role\) can do everything in the scope of the product. The administrator can edit and execute a project, create and edit a knowledge base, terminate an activity, stop a process within an activity, and can change the configuration and Reference Data Services settings. The DQS Administrator cannot, however, install the server or add new users. The database administrator must do that.  
  
-   The **DQS KB Editor** \(dqs\_kb\_editor role\) can perform all of the DQS activities, except for administration. The KB Editor can edit and execute a project, and create and edit a knowledge base. They can see the activity monitoring data, but cannot terminate or stop an activity or perform administrative duties.  
  
-   The **DQS KB Operator** \(dqs\_kb\_operator role\) can edit and execute a project. They cannot perform any kind of knowledge management; they cannot create or change a knowledge base. They can see the activity monitoring data, but cannot terminate an activity or perform administrative duties.  
  
## User Management  
 The database administrator \(DBA\) creates DQS users and associates them with DQS roles in SQL Server Management Studio. The DBA manages their permissions by adding SQL Logins as users of the DQS\_MAIN database, and associating each user with one of the DQS roles. Each role is granted permissions to a set of stored procedures on the DQS\_MAIN database. The three DQS roles are not available for the DQS\_PROJECTS and DQS\_STAGING\_DATA databases.  
  
## Related Tasks  
  
|Task Description|Topic|  
|----------------------|-----------|  
|Describes how to create a user and grant DQS roles using SQL Server Management Studio.|[Manage DQS Users in SSMS](../../Topics\TopicNameNotContainA/Manage-DQS-Users-in-SSMS.md)|  
  
  