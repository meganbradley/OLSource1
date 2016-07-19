---
title: Staging Stored Procedure (Master Data Services)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6a613106-9f87-4caf-a23a-a726fc6561c5
manager: jhubbard
---
# Staging Stored Procedure (Master Data Services)
When initiating the staging process from [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], you use one of three stored procedures.  
  
-   stg.udp_<name\>_Leaf  
  
-   stg.udp_<name\>_Consolidated  
  
-   stg.udp_<name\>_Relationship  
  
 Where name is the name of the staging table that was specified when the entity was created.  
  
## Staging Process Stored Procedure Parameters  
 The following table lists the parameters of these stored procedures.  
  
|Parameter|Description|  
|---------------|-----------------|  
|**VersionName**<br /><br /> Required|The name of the version. This may or may not be case-sensitive, depending on your [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] collation setting.|  
|**LogFlag**<br /><br /> Required|Determines whether transactions are logged during the staging process. Possible values are:<br /><br /> **0**: Do not log transactions.<br /><br /> **1**: Log transactions.<br /><br /> <br /><br /> For more information about transactions, see [Transactions (Master Data Services)](../../Topics/TopicNameNotContainA/Transactions--Master-Data-Services-.md).|  
|**BatchTag**<br /><br /> Required, except by web service|The **BatchTag** value as specified in the staging table.|  
|**Batch_ID**<br /><br /> Required by web service only|The **Batch_ID** value as specified in the staging table.|  
|**User Name**|Optional parameter|  
|**User ID**|Optional parameter|  
  
### Staging Process Stored Procedure Example  
 The following example shows how to start the staging process by using the staging stored procedure.  
  
```  
USE [DATABASE_NAME]  
GO  
  
EXEC[stg].[udp_name_Leaf]  
      @VersionName = N'VERSION_1',  
@LogFlag = 1,  
@BatchTag = N'batch1'  
      @UserName=N’domain\user’  
  
GO  
  
```  
  
## See Also  
 [Validation Stored Procedure (Master Data Services)](../../Topics/TopicNameNotContainA/Validation-Stored-Procedure--Master-Data-Services-.md)   
 [View Errors that Occur During Staging (Master Data Services)](../../Topics/TopicNameNotContainA/View-Errors-that-Occur-During-Staging--Master-Data-Services-.md)