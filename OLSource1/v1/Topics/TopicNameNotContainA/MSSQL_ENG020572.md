---
title: "MSSQL_ENG020572"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 636566db-ffcf-4109-8c11-15b8c7cb9cd9
caps.latest.revision: 12
manager: jhubbard
---
# MSSQL_ENG020572
## Message Details  
  
|||  
|-|-|  
|Product Name|SQL Server|  
|Event ID|20572|  
|Event Source|MSSQLSERVER|  
|Component|[!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)]|  
|Symbolic Name||  
|Message Text|Subscriber '%s' subscription to article '%s' in publication '%s' has been reinitialized after a validation failure.|  
  
## Explanation  
 The data at the Subscriber was validated against the data at the Publisher, and the data did not match; therefore validation failed. When you specified that validation should be performed, you selected the option that a subscription should be reinitialized if validation failed. Reinitializing a subscription involves applying a new snapshot at the Subscriber. For more information about validation, see [Validate Replicated Data](../../Topics/TopicNameNotContainA/Validate-Replicated-Data.md).  
  
## User Action  
 Data at the Publisher and Subscriber will match after the new snapshot is applied at the Subscriber.  
  
## See Also  
 [Errors and Events Reference (Replication)](../../Topics/TopicNameNotContainA/Errors-and-Events-Reference--Replication-.md)