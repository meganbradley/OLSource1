---
title: MSSQL_ENG014144
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fdc744d5-530e-48c4-9420-cca032fd482b
---
# MSSQL_ENG014144
    
## Message Details  
  
|||  
|-|-|  
|Product Name|SQL Server|  
|Event ID|14144|  
|Event Source|MSSQLSERVER|  
|Component|[!INCLUDE[ssDEnoversion](../../Token\Other/ssDEnoversion_md.md)]|  
|Symbolic Name||  
|Message Text|Cannot drop Subscriber '%s'. There are subscriptions for it in the publication database '%s'.|  
  
## Explanation  
 A [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] instance that is configured as a Subscriber cannot be removed from the role of Subscriber while there are active subscriptions configured for the instance.  
  
## User Action  
 Drop all associated subscriptions before attempting to change the Subscriber status of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] instance:  
  
1.  Execute [sp_helpsubscription &#40;Transact-SQL&#41;](../Topic/sp_helpsubscription%20\(Transact-SQL\).md) in the publication database at the Publisher to find subscriptions.  
  
2.  Execute [sp_dropsubscription &#40;Transact-SQL&#41;](../Topic/sp_dropsubscription%20\(Transact-SQL\).md) in the publication database to drop subscriptions.  
  
## See Also  
 [Errors and Events Reference &#40;Replication&#41;](../Topic/Errors%20and%20Events%20Reference%20\(Replication\).md)   
 [Subscribe to Publications](../../Topics\TopicNameNotContainA/Subscribe-to-Publications.md)  
  
  