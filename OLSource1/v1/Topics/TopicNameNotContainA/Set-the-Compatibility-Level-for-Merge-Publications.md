---
title: Set the Compatibility Level for Merge Publications
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: db47ac73-948b-4d77-b272-bb3565135ea5
manager: jhubbard
---
# Set the Compatibility Level for Merge Publications
This topic describes how to set the compatibility level for merge publications in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)]. Merge replication uses the publication compatibility level to determine which features can be used by publications in a given database.  
  
 **In This Topic**  
  
-   **To set the compatibility level for merge publications, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
 Set the compatibility level on the **Subscriber Types** page of the New Publication Wizard. For more information on accessing this wizard, see [Create a Publication](../../Topics/TopicNameContainA/Create-a-Publication.md). After a publication snapshot is created, the compatibility level can be increased but cannot be decreased. Increase the compatibility level on the **General** page of the **Publication Properties - <Publication\>** dialog box. For more information about accessing this dialog box, see [View and Modify Publication Properties](../../Topics/TopicNameNotContainA/View-and-Modify-Publication-Properties.md). If you increase the publication compatibility level, any existing subscriptions at servers running versions prior to the compatibility level will no longer be able to synchronize.  
  
> [!NOTE]  
>  Because the compatibility level has implications for other publication properties and for which article properties are valid, do not change the compatibility level and other properties in the same use of the dialog box. The snapshot for the publication should be regenerated after the property is changed.  
  
#### To set the publication compatibility level  
  
-   On the **Subscriber Types** page of the New Publication Wizard, select the types of Subscribers that the publication should support.  
  
#### To increase the publication compatibility level  
  
-   On the **General** page of the **Publication Properties - <Publication\>** dialog box, select for **Compatibility level**.  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
 The compatibility level for a merge publication can either be set programmatically when a publication is created or modified programmatically at a later time. You can use replication stored procedures to set or change this publication property.  
  
#### To set the publication compatibility level for a merge publication  
  
1.  At the Publisher, execute [sp_addmergepublication](assetId:///28a629a1-7374-4614-9b04-279d290a942a), specifying a value for **@publication_compatibility_level** to make the publication compatible with older versions of [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. For more information, see [Create a Publication](../../Topics/TopicNameContainA/Create-a-Publication.md).  
  
#### To change the publication compatibility level of a merge publication  
  
1.  Execute [sp_changemergepublication](assetId:///81fe1994-7678-4852-980b-e02fedf1e796), specifying **publication_compatibility_level** for **@property** and the appropriate publication compatibility level for **@value**.  
  
#### To determine the publication compatibility level of a merge publication  
  
1.  Execute [sp_helpmergepublication](assetId:///dfe1e1e1-9a65-406a-aced-6385a078e135), specifying the desired publication.  
  
2.  Locate the publication compatibility level in the **backward_comp_level** column in the result set.  
  
###  <a name="TsqlExample"></a> Examples (Transact-SQL)  
 This example creates a merge publication and sets the publication compatibility level.  
  
```  
-- To avoid storing the login and password in the script file, the values   
-- are passed into SQLCMD as scripting variables. For information about   
-- how to use scripting variables on the command line and in SQL Server  
-- Management Studio, see the "Executing Replication Scripts" section in  
-- the topic "Programming Replication Using System Stored Procedures".  
  
--Add a new merge publication.  
DECLARE @publicationDB AS sysname;  
DECLARE @publication AS sysname;  
DECLARE @login AS sysname;  
DECLARE @password AS sysname;  
SET @publicationDB = N'AdventureWorks2012';   
SET @publication = N'AdvWorksSalesOrdersMerge'   
SET @login = $(Login);  
SET @password = $(Password);  
  
-- Create a new merge publication.   
USE [AdventureWorks2012]  
EXEC sp_addmergepublication   
@publication = @publication,   
-- Set the compatibility level to SQL Server 2014.  
@publication_compatibility_level = '120RTM';   
  
-- Create the snapshot job for the publication.  
EXEC sp_addpublication_snapshot   
@publication = @publication,  
@job_login = @login,  
@job_password = @password;  
GO  
```  
  
 This example changes the publication compatibility level for the merge publication.  
  
> [!NOTE]  
>  Changing the publication compatibility level might not be allowed if the publication uses any features that require a particular compatibility level. For more information, see [Replication Backward Compatibility](../../Topics/TopicNameNotContainA/Replication-Backward-Compatibility.md).  
  
```  
DECLARE @publication AS sysname;  
SET @publication = N'AdvWorksSalesOrdersMerge' ;  
  
-- Change the publication compatibility level to   
-- SQL Server 2012.  
EXEC sp_changemergepublication   
@publication = @publication,   
@property = N'publication_compatibility_level',   
@value = N'110RTM';  
GO  
  
```  
  
 This example returns the current publication compatibility level for the merge publication.  
  
```  
DECLARE @publication AS sysname;  
SET @publication = N'AdvWorksSalesOrdersMerge' ;  
EXEC sp_helpmergepublication   
@publication = @publication;  
GO  
  
```  
  
## See Also  
 [Create a Publication](../../Topics/TopicNameContainA/Create-a-Publication.md)