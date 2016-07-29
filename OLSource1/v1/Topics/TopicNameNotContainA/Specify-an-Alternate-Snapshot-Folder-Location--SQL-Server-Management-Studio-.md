---
title: "Specify an Alternate Snapshot Folder Location (SQL Server Management Studio)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9293f0eb-5531-47ec-b6e2-0392823ce5cc
caps.latest.revision: 42
manager: jhubbard
---
# Specify an Alternate Snapshot Folder Location (SQL Server Management Studio)
Specify an alternate snapshot location on the **Snapshot** page of the **Publication Properties - <Publication\>** dialog box. For more information about accessing this dialog box, see [View and Modify Publication Properties](../../Topics/TopicNameNotContainA/View-and-Modify-Publication-Properties.md).  
  
### To specify an alternate snapshot location  
  
1.  On the **Snapshot** page of the **Publication Properties - <Publication\>** dialog box:  
  
    1.  Select **Put files in the following folder**, and then click **Browse** to navigate to a directory, or enter the path to the directory in which the snapshot files should be stored.  
  
        > [!NOTE]  
        >  The Snapshot Agent must have write permissions for the directory you specify, and the Distribution Agent or Merge Agent must have read permissions. If pull subscriptions are used, you must specify a shared directory as a universal naming convention (UNC) path, such as \\\computername\snapshot. For more information, see [Secure the Snapshot Folder](../../Topics/TopicNameNotContainA/Secure-the-Snapshot-Folder.md).  
  
    2.  Clear **Put files in the default folder** unless you require snapshot files to be written to both locations.  
  
     To compress the snapshot files, select **Compress snapshot files in this location**. Compression is typically used for low bandwidth connections and alternate snapshot locations on removable media, such as a CD-ROM.  
  
2.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
## See Also  
 [Alternate Snapshot Folder Locations](../../Topics/TopicNameNotContainA/Alternate-Snapshot-Folder-Locations.md)   
 [Configure Snapshot Properties (Replication Transact-SQL Programming)](../../Topics/TopicNameNotContainA/Configure-Snapshot-Properties--Replication-Transact-SQL-Programming-.md)   
 [Specify the Default Snapshot Location (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/Specify-the-Default-Snapshot-Location--SQL-Server-Management-Studio-.md)   
 [Change Publication and Article Properties](../../Topics/TopicNameNotContainA/Change-Publication-and-Article-Properties.md)   
 [Initialize a Subscription with a Snapshot](../../Topics/TopicNameContainA/Initialize-a-Subscription-with-a-Snapshot.md)