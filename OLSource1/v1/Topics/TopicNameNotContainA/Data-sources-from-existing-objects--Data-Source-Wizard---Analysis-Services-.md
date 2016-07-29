---
title: "Data sources from existing objects (Data Source Wizard) (Analysis Services)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e6ef6dea-9db8-45c4-8959-f9febd7caf7b
caps.latest.revision: 21
manager: mblythe
---
# Data sources from existing objects (Data Source Wizard) (Analysis Services)
Use the **Data sources from existing objects** page to specify an existing data source or project on which to base the new data source.  
  
## Options  
 **Create a data source based on an existing data source in your solution**  
 Select to base the new data source on an existing data source in the solution. When a project that uses the new data source is built, refreshed, or deployed, the new data source acquires the settings from the data source you specify when you select this option.  
  
 **Data source**  
 Select a data source on which you want to base the new data source from the list of data sources, which is grouped by project.  
  
 **Create a data source based on an Analysis Services project**  
 Select to create a new data source that references another [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] project in the current solution. The new data source acquires settings from the **TargetServer** and **TargetDatabase** properties of the selected project. When a project that uses the new data source is built, refreshed, or deployed, the new data source acquires settings from the data source you specify when you select this option.  
  
 **Project**  
 Select the project that you want to reference in the new data source.  
  
## See Also  
 [Data Source Wizard F1 Help (Analysis Services)](../../Topics/TopicNameNotContainA/Data-Source-Wizard-F1-Help--Analysis-Services-.md)   
 [Data Sources in Multidimensional Models](../../Topics/TopicNameNotContainA/Data-Sources-in-Multidimensional-Models.md)   
 [Supported Data Sources (SSAS - Multidimensional)](../../Topics/TopicNameNotContainA/Supported-Data-Sources--SSAS---Multidimensional-.md)