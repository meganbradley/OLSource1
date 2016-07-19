---
title: Select Backup Device
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7887c9fd-15ce-4cc8-b069-845c1d09088c
manager: jhubbard
---
# Select Backup Device
Use the **Select Backup Device** dialog box to select a logical backup device for the restore operation.  
  
 A logical backup device is a user-defined logical device that corresponds to a physical device, either a tape drive or a disk drive, that is provided by the operating system.  
  
> [!NOTE]  
>  If a backup uses multiple backup devices, they all must correspond to a single type of device.  
  
 **To use SQL Server Management Studio to view the contents of a backup device**  
  
-   [View the Contents of a Backup Tape or File (SQL Server)](../../Topics/TopicNameContainA/View-the-Contents-of-a-Backup-Tape-or-File--SQL-Server-.md)  
  
-   [View the Properties and Contents of a Logical Backup Device (SQL Server)](../../Topics/TopicNameContainA/View-the-Properties-and-Contents-of-a-Logical-Backup-Device--SQL-Server-.md)  
  
## Options  
 **Backup device**  
 In the list box, select the name of a logical backup device from which you want to restore.  
  
 For information about how to view the contents of a backup device, see [View the Properties and Contents of a Logical Backup Device (SQL Server)](../../Topics/TopicNameContainA/View-the-Properties-and-Contents-of-a-Logical-Backup-Device--SQL-Server-.md).  
  
## Remarks  
 If you do not see a logical backup device that contains the backup you are seeking on the list, the backup might have been written directly to one or more files or tape drives. If this is the case, cancel the **Select Backup Device** dialog box; and in the **Specify Backup** dialog box, select **File** or **Tape** in the **Backup media** list box.  
  
## See Also  
 [Backup Devices (SQL Server)](../../Topics/TopicNameNotContainA/Backup-Devices--SQL-Server-.md)