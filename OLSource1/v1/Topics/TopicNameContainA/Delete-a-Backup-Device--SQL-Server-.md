---
title: Delete a Backup Device (SQL Server)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7be62480-ed6a-4262-a071-1feba73b1c02
manager: jhubbard
---
# Delete a Backup Device (SQL Server)
This topic describes how to delete a backup device in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)].  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Security](#Security)  
  
-   **To delete a backup device, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 Requires membership in the **diskadmin** fixed server role.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To delete a backup device  
  
1.  After connecting to the appropriate instance of the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)], in Object Explorer, click the server name to expand the server tree.  
  
2.  Expand **Server Objects**, and then expand **Backup Devices**.  
  
3.  Right-click the device you want, and then click **Delete**.  
  
4.  In the **Delete Object** dialog box, verify that the correct device name appears in the **Object Name** column.  
  
5.  Click **OK**.  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
  
#### To delete a backup device  
  
1.  Connect to the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query. This example shows how to use [sp_dropdevice](assetId:///c8b07189-7c35-414b-acc1-45bd6e7e17c3) to delete a backup device. Execute the first example to create the `mybackupdisk` backup device and the physical name `c:\backup\backup1.bak`. Execute **sp_dropdevice** to delete the `mybackupdisk` backup device. The `delfile` parameter deletes the physical name.  
  
```tsql  
--Define a backup device and physical name.   
USE AdventureWorks2012 ;  
GO  
EXEC sp_addumpdevice 'disk', 'mybackupdisk', 'c:\backup\backup1.bak' ;  
GO  
--Delete the backup device and the physical name.  
USE AdventureWorks2012 ;  
GO  
EXEC sp_dropdevice ' mybackupdisk ', 'delfile' ;  
GO  
  
```  
  
## See Also  
 [View the Properties and Contents of a Logical Backup Device (SQL Server)](../../Topics/TopicNameContainA/View-the-Properties-and-Contents-of-a-Logical-Backup-Device--SQL-Server-.md)   
 [sys.backup_devices (Transact-SQL)](assetId:///457edaa4-aca1-4bd3-bf8d-734490b80fcd)   
 [BACKUP (Transact-SQL)](assetId:///89a4658a-62f1-4289-8982-f072229720a1)   
 [Backup Devices (SQL Server)](../../Topics/TopicNameNotContainA/Backup-Devices--SQL-Server-.md)   
 [sp_addumpdevice (Transact-SQL)](assetId:///c2d2ae49-0808-46d8-8444-db69a69d0ec3)