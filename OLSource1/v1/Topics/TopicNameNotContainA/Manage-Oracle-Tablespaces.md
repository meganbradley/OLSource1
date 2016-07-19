---
title: Manage Oracle Tablespaces
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b8ea6c3b-01d6-4efc-bbfb-03b264530bbd
manager: jhubbard
---
# Manage Oracle Tablespaces
A tablespace is a unit of database storage that is roughly equivalent to a file group in [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. Tablespaces allow storage and management of database objects within individual groups. For more information, see the Oracle documentation.  
  
 When you configure a table as part of an Oracle publication, you can optionally specify an existing Oracle tablespace to be used when storing replication logging information. If unspecified, the tablespace for the replication objects is the default tablespace associated with the replication administrative user schema that was configured when configuring the Publisher.  
  
 **To specify a tablespace for an article logging table**:  
  
-   Specify a tablespace in the **Article Properties** dialog box. For more information about accessing this dialog box, see [View and Modify Publication Properties](../../Topics/TopicNameNotContainA/View-and-Modify-Publication-Properties.md).  
  
-   Use [sp_changearticle (Transact-SQL)](assetId:///24c33ca5-f03a-4417-a267-131ca5ba6bb5). To use **sp_changearticle**, specify the following:  
  
    -   The name of the Oracle Publisher for the parameter **@publisher**.  
  
    -   The name of the Oracle publication for the parameter **@publication**.  
  
    -   The name of the article for the parameter **@article**.  
  
    -   A value of 'tablespace' for the parameter **@property**.  
  
    -   The name of the tablespace for the parameter **@value**.  
  
## See Also  
 [Configure an Oracle Publisher](../../Topics/TopicNameNotContainA/Configure-an-Oracle-Publisher.md)   
 [Objects Created on the Oracle Publisher](../../Topics/TopicNameNotContainA/Objects-Created-on-the-Oracle-Publisher.md)