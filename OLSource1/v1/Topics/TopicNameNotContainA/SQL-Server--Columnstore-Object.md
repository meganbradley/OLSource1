---
title: SQL Server, Columnstore Object
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ae663a49-012f-4ffe-a332-f03157843052
---
# SQL Server, Columnstore Object
The **SQLServer:Columnstore** object provides counters to monitor columnstore index execution in [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
 The following table describes the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] **Columnstore** counters.  
  
|Columnstore counters|Description|  
|--------------------------|-----------------|  
|**Delta Rowgroups Closed**|Number of delta rowgroups closed.|  
|**Delta Rowgroups Compressed**|Number of delta rowgroups compressed.|  
|**Delta Rowgroups Created**|Number of delta rowgroups created.|  
|**Segment Cache Hit Raio**|Percentage of column segments that were found in the columnstore pool without having to incur a read from disk.|  
|**Segment Reads/Sec**|Number of physical segment reads issued.|  
|**Total Delete Buffers Migrated**|Number of times tuple mover has cleaned up the delete buffer.|  
|**Total Merge Policy Evaluations**|Number of times the merge policy for columnstore was evaluated.|  
|**Total Rowgroups Compressed**|Total number of rowgroups compressed.|  
|**Total Rowgroups Fit For Merge**|Number of source rowgroups fit for MERGE since the start of SQL Server.|  
|**Total Rowgroups Merge Compressed**|Number of compressed target rowgroups created with MERGE since the start of SQL Server.|  
|**Total Source Rowgroups Merged**|Number of source rowgroups merged since the start of SQL Server.|  
  
## See Also  
 [Monitor Resource Usage (System Monitor)](../../Topics/TopicNameNotContainA/Monitor-Resource-Usage--System-Monitor-.md)