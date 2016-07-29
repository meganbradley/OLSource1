---
title: "Cubes in Multidimensional Models"
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
ms.assetid: e0f7acf3-4b07-41fc-a5fc-ac30b4a56c54
caps.latest.revision: 34
manager: mblythe
---
# Cubes in Multidimensional Models
A cube is a multidimensional structure that contains information for analytical purposes; the main constituents of a cube are dimensions and measures. Dimensions define the structure of the cube that you use to slice and dice over, and measures provide aggregated numerical values of interest to the end user. As a logical structure, a cube allows a client application to retrieve values, of measures, as if they were contained in cells in the cube; cells are defined for every possible summarized value. A cell, in the cube, is defined by the intersection of dimension members and contains the aggregated values of the measures at that specific intersection.  
  
## Benefits of Using Cubes  
 A cube provides a single place where all related data, for analysis, is stored.  
  
## Components of Cubes  
 A cube is composed of:  
  
|Element|Description|  
|-------------|-----------------|  
|Dimensions|[Dimensions in Multidimensional Models](../../Topics/TopicNameNotContainA/Dimensions-in-Multidimensional-Models.md)|  
|Measures and Measure Groups|[Create Measures and Measure Groups in Multidimensional Models](../../Topics/TopicNameNotContainA/Create-Measures-and-Measure-Groups-in-Multidimensional-Models.md)|  
|Partitions|[Partitions in Multidimensional Models](../../Topics/TopicNameNotContainA/Partitions-in-Multidimensional-Models.md)|  
|Perspectives|[Perspectives in Multidimensional Models](../../Topics/TopicNameNotContainA/Perspectives-in-Multidimensional-Models.md)|  
|Hierarchies|[Create User-Defined Hierarchies](../../Topics/TopicNameNotContainA/Create-User-Defined-Hierarchies.md)|  
|Actions|[Actions in Multidimensional Models](../../Topics/TopicNameNotContainA/Actions-in-Multidimensional-Models.md)|  
|Key Performance Indicators (KPI)|[Key Performance Indicators (KPIs) in Multidimensional Models](../../Topics/TopicNameNotContainA/tianqi.md)|  
|Calculations|[Calculations in Multidimensional Models](../../Topics/TopicNameNotContainA/Calculations-in-Multidimensional-Models.md)|  
|Translations|[Translations in Multidimensional Models (Analysis Services)](../../Topics/TopicNameNotContainA/Translations-in-Multidimensional-Models--Analysis-Services-.md)|  
  
## Related Tasks  
  
|Topic|Description|  
|-----------|-----------------|  
|[Create a Cube Using the Cube Wizard](../../Topics/TopicNameContainA/Create-a-Cube-Using-the-Cube-Wizard.md)|Describes how to use the Cube Wizard to define a cube, dimensions, dimension attributes, and user-defined hierarchies.|  
|[Create Measures and Measure Groups in Multidimensional Models](../../Topics/TopicNameNotContainA/Create-Measures-and-Measure-Groups-in-Multidimensional-Models.md)|Describes how to define measure groups.|  
|[Calculations in Multidimensional Models](../../Topics/TopicNameNotContainA/Calculations-in-Multidimensional-Models.md)|Describes how to define and configure a calculation in an MDX script.|  
|[Actions in Multidimensional Models](../../Topics/TopicNameNotContainA/Actions-in-Multidimensional-Models.md)|Describes how to define and configure an action.|  
|[Perspectives in Multidimensional Models](../../Topics/TopicNameNotContainA/Perspectives-in-Multidimensional-Models.md)|Describes how to define and configure a perspective.|  
|[Defining Stored Procedures](assetId:///f9c57d91-f60f-4f0e-8f7f-d87f4ba97b7c)|Describes how to work with stored procedures.|