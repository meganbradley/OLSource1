---
title: SMO and DMO XPs Server Configuration Option
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bcd945ba-5d81-4124-9a2b-d87491c2a369
manager: jhubbard
---
# SMO and DMO XPs Server Configuration Option
Use the SMO and DMO XPs option to enable [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Management Object (SMO) extended stored procedures on this server.  
  
 Note than beginning in [!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)], DMO has been removed from [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
 The possible values are described in the following table:  
  
|Value|Meaning|  
|-----------|-------------|  
|0|SMO XPs are not available.|  
|1|SMO XPs are available. This is the default.|  
  
 The setting takes effect immediately.  
  
## Examples  
 The following example enables SMO extended stored procedures.  
  
```  
sp_configure 'show advanced options', 1;  
GO  
RECONFIGURE;  
GO  
sp_configure 'SMO and DMO XPs', 1;  
GO  
RECONFIGURE  
GO  
```  
  
## See Also  
 [SQL Server Management Objects (SMO)](assetId:///4cde2b85-2a31-4cac-8d16-7a4196066193)