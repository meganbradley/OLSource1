---
title: "Create User-Defined Hierarchies"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 16715b85-0630-4a8e-99b0-c0d213cade26
caps.latest.revision: 23
manager: mblythe
---
# Create User-Defined Hierarchies
[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] lets you create user-defined hierarchies. A hierarchy is a collection of levels based on attributes. For example, a time hierarchy might contain the Year, Quarter, Month, Week, and Day levels. In some hierarchies, each member attribute uniquely implies the member attribute above it. This is sometimes referred to as a natural hierarchy. A hierarchy can be used by end users to browse cube data. Define hierarchies by using the Hierarchies pane of Dimension Designer in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)].  
  
 When you create a user-defined hierarchy, the hierarchy might become *ragged*. A ragged hierarchy is where the logical parent member of at least one member is not in the level immediately above the member. If you have a ragged hierarchy, there are settings that control whether the missing members are visible and how to display the missing members. For more information, see [Ragged Hierarchies](../../Topics/TopicNameNotContainA/Ragged-Hierarchies.md).  
  
> [!NOTE]  
>  For more information about performance issues related to the design and configuration of user-defined hierarchies, see the [SQL Server 2005 Analysis Services Performance Guide](http://go.microsoft.com/fwlink/?LinkId=81621).  
  
## See Also  
 [Configuring User-defined Hierarchy Properties](assetId:///344af8f8-12f3-48c0-b934-4503779d37ff)   
 [Configuring Level Properties](assetId:///dabb7335-887b-442a-b67c-4901ba1242b7)   
 [Parent-Child Dimensions](../../Topics/TopicNameNotContainA/Parent-Child-Dimensions.md)