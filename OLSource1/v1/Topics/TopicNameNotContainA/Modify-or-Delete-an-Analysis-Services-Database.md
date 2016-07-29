---
title: "Modify or Delete an Analysis Services Database"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e48e3988-c091-4379-aabc-4da62f709a7e
caps.latest.revision: 35
manager: mblythe
---
# Modify or Delete an Analysis Services Database
You can change the name and description of an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] database before deployment in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] and after deployment in [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)]. You can also adjust additional settings on an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] database, depending on the environment.  
  
> [!NOTE]  
>  You cannot change database properties using [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] in online mode.  
  
## Modifying Databases Using SQL Server Management Studio  
 Once an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] database is deployed, you can use [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] to change the impersonation mode used by [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] when connecting to data sources contained by the database. The impersonation mode allows you to specify the security context used by [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] when attempting to connect to a data source for processing, browsing, or drillthrough purposes.  
  
## Modifying Databases Using SQL Server Data Tools  
 You can use [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] in project mode to modify the translations for the caption and description of an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] project used to define a database. For more information about using translations in an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] database, see [Globalization scenarios for Analysis Services](../../Topics/TopicNameNotContainA/Globalization-scenarios-for-Analysis-Services.md).  
  
 You can also set the aliases and aggregation functions associated with account types used by account attributes in dimensions contained by the database. Aliases allow you to select the business-specific terminology used by your organization for the account types in a chart of accounts. The account types are used by members of an account attribute to indicate how to aggregate measures over each member by using the aggregation functions specified for each account type contained in the database. For more information about account attributes, see [Attributes (SSAS)](assetId:///59de1ea2-e7a9-4a53-9ee0-14be52e95643).  
  
## Deleting Databases  
 Deleting an existing [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] database deletes the database and all cubes, dimensions, and mining models in the database. You can only delete an existing [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] database in [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)].  
  
#### To delete an Analysis Services database  
  
1.  Connect to an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] instance.  
  
2.  In **Object Explorer**, expand the node for the connected [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] instance and ensure that the object to be deleted is visible.  
  
3.  Right-click the object to be deleted and select **Delete**.  
  
4.  In the **Delete Object** dialog box, click **OK**.  
  
## See Also  
 [Document and Script an Analysis Services Database](../../Topics/TopicNameNotContainA/Document-and-Script-an-Analysis-Services-Database.md)