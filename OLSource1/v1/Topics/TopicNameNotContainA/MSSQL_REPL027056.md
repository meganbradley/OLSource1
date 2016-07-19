---
title: MSSQL_REPL027056
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 92d62f3c-b8ae-482e-a348-2e9a8ee9786e
manager: jhubbard
---
# MSSQL_REPL027056
## Message Details  
  
|||  
|-|-|  
|Product Name|SQL Server|  
|Event ID|27056|  
|Event Source|MSSQLSERVER|  
|Component|[!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)]|  
|Symbolic Name||  
|Message Text|The merge process was unable to change generation history at the '%1'. When troubleshooting, restart the synchronization with verbose history logging and specify an output file to which to write.|  
  
## Explanation  
 This error is typically raised as a result of contention in merge replication system tables that have grown excessively large. Large system tables are typically caused by a long publication retention period, because metadata must be stored in these tables until the retention period is reached.  
  
## User Action  
 **To resolve the issue:**  
  
1.  Decrease the value of the -**DownloadGenerationsPerBatch** and **-UploadGenerationsPerBatch** parameters for the Merge Agent to allow processing to continue while you address the underlying issue causing the error. Agent parameters can be specified in agent profiles and on the command line. For more information, see:  
  
    -   [Work with Replication Agent Profiles](../../Topics/TopicNameNotContainA/Work-with-Replication-Agent-Profiles.md)  
  
    -   [View and Modify Replication Agent Command Prompt Parameters (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/View-and-Modify-Replication-Agent-Command-Prompt-Parameters--SQL-Server-Management-Studio-.md)  
  
    -   [Programming Replication Agent Executables](assetId:///cba476df-d4ea-44c9-bb86-81488971e328).  
  
2.  Specify the lowest setting possible for the publication retention period. For more information, see [Subscription Expiration and Deactivation](../../Topics/TopicNameNotContainA/Subscription-Expiration-and-Deactivation.md).  
  
3.  As part of maintenance for merge replication, occasionally check the growth of the system tables associated with merge replication: **MSmerge_contents**, **MSmerge_genhistory**, and **MSmerge_tombstone**, **MSmerge_current_partition_mappings**, and **MSmerge_past_partition_mappings**. Periodically re-index these tables. For more information, see [Reorganize and Rebuild Indexes](../../Topics/TopicNameNotContainA/Reorganize-and-Rebuild-Indexes.md).  
  
## See Also  
 [Errors and Events Reference (Replication)](../../Topics/TopicNameNotContainA/Errors-and-Events-Reference--Replication-.md)