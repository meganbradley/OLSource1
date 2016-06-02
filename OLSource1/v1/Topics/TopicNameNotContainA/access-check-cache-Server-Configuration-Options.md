---
title: access check cache Server Configuration Options
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0a992ea8-3ec6-4a4d-97b5-460ae7326247
---
# access check cache Server Configuration Options
  When database objects are accessed by [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], the access check is cached in an internal structure called the **access check result cache**. The **access check cache quota** and **access check cache bucket count** options control the number of entries and number of hash buckets used for **access check result cache**. In rare circumstances, performance can be improved by changing these options.  
  
 The default values of 0 indicates that [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] is managing these options. Microsoft recommends only changing these options when directed by Microsoft Customer Support Services.  
  
## See Also  
 [Server Configuration Options &#40;SQL Server&#41;](../Topic/Server%20Configuration%20Options%20\(SQL%20Server\).md)   
 [sp_configure &#40;Transact-SQL&#41;](../Topic/sp_configure%20\(Transact-SQL\).md)  
  
  