---
title: "Example: Online Restore of a Read-Only File (Full Recovery Model)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7ea2d2af-086f-48dc-9636-38dc194c7090
caps.latest.revision: 27
manager: jhubbard
---
# Example: Online Restore of a Read-Only File (Full Recovery Model)
This topic is relevant for [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] databases under the full recovery model that contain multiple files or filegroups.  
  
 In this example, a database named `adb`, which uses the full recovery model, contains three filegroups. Filegroup `A` is read/write, and filegroup `B` and filegroup `C` are read-only. Initially, all of the filegroups are online.  
  
 A read-only file, `b1`, in filegroup `B` of database `adb` has to be restored. A backup was taken since the file became read-only; therefore, log backups are not required. Filegroup `B` is offline for the duration of the restore, but the remainder of the database remains online.  
  
## Restore Sequence  
  
> [!NOTE]  
>  The syntax for an online restore sequence is the same as for an offline restore sequence.  
  
 To restore the file, the database administrator uses the following restore sequence:  
  
```  
RESTORE DATABASE adb FILE='b1' FROM filegroup_B_backup  
WITH RECOVERY   
```  
  
 Filegroup B is now online.  
  
## Additional Examples  
  
-   [Example: Piecemeal Restore of Database (Simple Recovery Model)](../Topic/Example:%20Piecemeal%20Restore%20of%20Database%20\(Simple%20Recovery%20Model\).md)  
  
-   [Example: Piecemeal Restore of Only Some Filegroups (Simple Recovery Model)](../Topic/Example:%20Piecemeal%20Restore%20of%20Only%20Some%20Filegroups%20\(Simple%20Recovery%20Model\).md)  
  
-   [Example: Online Restore of a Read-Only File (Simple Recovery Model)](../Topic/Example:%20Online%20Restore%20of%20a%20Read-Only%20File%20\(Simple%20Recovery%20Model\).md)  
  
-   [Example: Piecemeal Restore of Database (Full Recovery Model)](../Topic/Example:%20Piecemeal%20Restore%20of%20Database%20\(Full%20Recovery%20Model\).md)  
  
-   [Example: Piecemeal Restore of Only Some Filegroups (Full Recovery Model)](../Topic/Example:%20Piecemeal%20Restore%20of%20Only%20Some%20Filegroups%20\(Full%20Recovery%20Model\).md)  
  
-   [Example: Online Restore of a Read-Write File (Full Recovery Model)](../Topic/Example:%20Online%20Restore%20of%20a%20Read-Write%20File%20\(Full%20Recovery%20Model\).md)  
  
## See Also  
 [Online Restore (SQL Server)](../../Topics/TopicNameNotContainA/Online-Restore--SQL-Server-.md)   
 [Restore and Recovery Overview (SQL Server)](../../Topics/TopicNameNotContainA/Restore-and-Recovery-Overview--SQL-Server-.md)   
 [File Restores (Full Recovery Model)](../../Topics/TopicNameNotContainA/File-Restores--Full-Recovery-Model-.md)   
 [RESTORE (Transact-SQL)](assetId:///877ecd57-3f2e-4237-890a-08f16e944ef1)