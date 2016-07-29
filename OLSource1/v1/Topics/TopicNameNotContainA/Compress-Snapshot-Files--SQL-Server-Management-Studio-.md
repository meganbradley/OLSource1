---
title: "Compress Snapshot Files (SQL Server Management Studio)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 174ade3e-74a1-4e67-a6da-b874be3ff50f
caps.latest.revision: 36
manager: jhubbard
---
# Compress Snapshot Files (SQL Server Management Studio)
Specify that files should be compressed on the **Snapshot** page of the **Publication Properties - <Publication\>** dialog box. For more information about accessing this dialog box, see [View and Modify Publication Properties](../../Topics/TopicNameNotContainA/View-and-Modify-Publication-Properties.md).  
  
### To compress snapshot files  
  
1.  On the **Snapshot** page of the **Publication Properties - <Publication\>** dialog box:  
  
    1.  Select **Put files in the following folder**, and then click **Browse** to navigate to a directory, or enter the path to the directory in which the snapshot files should be stored.  
  
        > [!NOTE]  
        >  The Snapshot Agent must have write permissions for the directory you specify, and the Distribution Agent or Merge Agent must have read permissions. If pull subscriptions are used, you must specify a shared directory as a universal naming convention (UNC) path, such as \\\computername\snapshot. For more information, see [Secure the Snapshot Folder](../../Topics/TopicNameNotContainA/Secure-the-Snapshot-Folder.md)  
  
    2.  Clear **Put files in the default folder** unless you require snapshot files to be written to both locations.  
  
        > [!NOTE]  
        >  If this check box is selected, the files stored in the default folder are not compressed. Compressed files can only be stored in the alternate location specified in the previous step.  
  
2.  Select **Compress snapshot files in this folder**.  
  
3.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
## See Also  
 [Configure Snapshot Properties (Replication Transact-SQL Programming)](../../Topics/TopicNameNotContainA/Configure-Snapshot-Properties--Replication-Transact-SQL-Programming-.md)   
 [Change Publication and Article Properties](../../Topics/TopicNameNotContainA/Change-Publication-and-Article-Properties.md)   
 [Compressed Snapshots](../../Topics/TopicNameNotContainA/Compressed-Snapshots.md)   
 [Initialize a Subscription with a Snapshot](../../Topics/TopicNameContainA/Initialize-a-Subscription-with-a-Snapshot.md)