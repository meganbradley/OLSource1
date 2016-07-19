---
title: History Cleanup Task
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5defc5b9-dfd3-4859-a7fe-ac8c2b5480f8
manager: jhubbard
---
# History Cleanup Task
The History Cleanup task deletes entries in the following history tables in the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] msdb database.  
  
-   backupfile  
  
-   backupfilegroup  
  
-   backupmediafamily  
  
-   backupmediaset  
  
-   backupset  
  
-   restorefile  
  
-   restorefilegroup  
  
-   restorehistory  
  
 By using the History Cleanup task, a package can delete historical data related to backup and restore activities, [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Agent jobs, and database maintenance plans.  
  
 This task encapsulates the sp_delete_backuphistory system stored procedure and passes the specified date to the procedure as an argument. For more information, see [How to: Set Task Properties](assetId:///bdb56834-616e-47e4-b942-e895d2325e97).  
  
## Configuration of the History Cleanup Task  
 The task includes a property for specifying the oldest date of data retained in the history tables. You can indicate the date by number of days, weeks, months, or years from the current day, and the task automatically translates the interval to a date.  
  
 You can set properties through [!INCLUDE[ssIS](../../Topics/TopicNameContainA/includes/ssIS_md.md)] Designer. This task is in the **Maintenance Plan Tasks** section of the **Toolbox** in [!INCLUDE[ssIS](../../Topics/TopicNameContainA/includes/ssIS_md.md)] Designer.  
  
 For more information about the properties that you can set in [!INCLUDE[ssIS](../../Topics/TopicNameContainA/includes/ssIS_md.md)] Designer, click the following topic:  
  
-   [History Cleanup Task (Maintenance Plan)](../../Topics/TopicNameNotContainA/History-Cleanup-Task--Maintenance-Plan-.md)  
  
 For more information about how to set these properties in [!INCLUDE[ssIS](../../Topics/TopicNameContainA/includes/ssIS_md.md)] Designer, click the following topic:  
  
-   [Set the Properties of a Task or Container](../../Topics/TopicNameContainA/Set-the-Properties-of-a-Task-or-Container.md)  
  
## See Also  
 [Integration Services Tasks](../../Topics/TopicNameNotContainA/Integration-Services-Tasks.md)   
 [Control Flow](../../Topics/TopicNameNotContainA/Control-Flow.md)