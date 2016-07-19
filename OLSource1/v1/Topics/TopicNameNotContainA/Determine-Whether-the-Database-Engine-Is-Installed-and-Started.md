---
title: Determine Whether the Database Engine Is Installed and Started
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: babb02e4-3521-4b75-b5df-e09205594375
manager: jhubbard
---
# Determine Whether the Database Engine Is Installed and Started
A successful installation of the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)] installs files to the file system, creates entries in the registry, and installs several tools. This topic describes how to determine whether the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] is installed and started in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Configuration Manager  
  
#### How to view and start the Database Engine by using SQL Server Configuration Manager  
  
1.  Click **Start**, point to **All Programs**, point to **Microsoft SQL Server**, point to **Configuration Tools**, and then click **SQL Server Configuration Manager**.  
  
     If you do not have these entries on the **Start** menu, [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] is not correctly installed. Run Setup to install the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)].  
  
2.  In **SQL Server Configuration Manager**, on the left pane, click **SQL Server Services**. The right pane lists several services that are related to [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. If the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] is installed, the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] service is listed as **SQL Server (MSSQLSERVER)** if it is the default instance; or **SQL Server (**<*instance_name*>**)**, if the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] is installed as a named instance. Unless the instance name is changed, [!INCLUDE[ssExpress](../../Topics/TopicNameContainA/includes/ssExpress_md.md)] installs as a named instance with the name **SQLEXPRESS**. A green triangle icon indicates that the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] is running. A red square icon indicates that the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] is stopped.  
  
3.  To start the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)], in the right pane, right-click the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)], and then click **Start**.  
  
> [!NOTE]  
>  During setup, the user can select a location in which to install the program files and the database files. If the user accepts the default location, the files are installed to [!INCLUDE[ssInstallPath](../../Topics/TopicNameContainA/includes/ssInstallPath_md.md)] and C:\Program Files\Microsoft SQL Server\MSSQL.*x*, where *x* is a number.