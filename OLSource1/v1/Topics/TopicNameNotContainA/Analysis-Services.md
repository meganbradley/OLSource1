---
title: Analysis Services
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 49d186f4-4b4d-4a5a-bb1a-e2699c64a731
manager: mblythe
---
# Analysis Services
[!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] is an online analytical data engine used in decision support and business analytics, providing the analytical data for business reports and client applications such as Power BI, Excel, Reporting Services reports, and other data visualization tools.  
  
 A typical workflow for [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] includes authoring a Multidimensional or Tabular data model, deploying the model as a database to an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] instance, processing the database to load it with data or metadata, setting up data refresh, and assigning permissions to allow data access by end-users. When it's ready to go, this multi-purpose semantic data model can be accessed by any client application supporting [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] as a data source.  
  
 Models are populated with data from external data systems, usually data warehouses hosted on a SQL Server or Oracle relational database engine (Tabular models support additional data source types). Models specify query objects, such as cubes, but also specify dimensions that can be used in multiple cubes, calculations and KPIs that encapsulate business logic, and interactions such as navigation and drill-through behaviors.  
  
## Server mode  
 When installing Analysis Services by using [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] Setup, during configuration you specify a server mode for that instance.  Each mode includes different features unique to a particular  Analysis Services solution.  
  
-   **Multidimensional and Data Mining Mode** - Implement OLAP modeling constructs (cubes, dimensions, measures).  
  
-   **Tabular Mode** - Implement in-memory relational data modeling constructs (model, tables, columns).  
  
     Tabular models can be created at the default compatibility level 1200 to use the newest functionality, or at the older 1103 compatibility level. There are major differences between the compatibility levels in this release. See [Compatibility Level for Tabular models in Analysis Services](../../Topics/TopicNameNotContainA/Compatibility-Level-for-Tabular-models-in-Analysis-Services.md)for information on how the levels compare.  See [What's New in Analysis Services](../../Topics/TopicNameNotContainA/What-s-New-in-Analysis-Services.md) for details about new features.  
  
-   **Power Pivot Mode** - Implement [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] and Excel data models in SharePoint ([!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] for SharePoint is a middle-tier data engine that loads, queries, and refreshes data models hosted in SharePoint).  
  
 A single instance can be configured with only one mode,  and cannot be changed later.  You can install multiple instances with different modes on the same server, but you'll need to run Setup and specify configuration settings for each instance.  
  
 [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] features vary by edition. For more information, see [Features Supported by the Editions of SQL Server 2016](../../Topics/TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md).  
  
## Authoring solutions  
 To create a model, you use SQL Server Data Tools (see [Tools and applications used in Analysis Services](../../Topics/TopicNameNotContainA/Tools-and-applications-used-in-Analysis-Services.md)), choosing either a Tabular or Multidimensional and Data Mining project template. The project template contains folders for all of the objects needed in a model. Wizards help create many of the basic elements, such as data sources, data source views, dimensions, cubes, and roles.  
  
## Documentation by area  
 Foundational documentation for Analysis Services is organized into sections that correspond to the type of project you are building. Choose from the following links to learn more about each mode or feature area.  
  
 ![Small File Folder Icon](../../Topics/TopicNameNotContainA/media/filefolder_small.png "filefolder_small") [Comparing Tabular and Multidimensional Solutions (SSAS)](../../Topics/TopicNameNotContainA/Comparing-Tabular-and-Multidimensional-Solutions--SSAS-.md)  
  
 ![Small File Folder Icon](../../Topics/TopicNameNotContainA/media/filefolder_small.png "filefolder_small") [Tabular Models (SSAS)](../../Topics/TopicNameNotContainA/Tabular-Models--SSAS-.md)  
  
 ![Small File Folder Icon](../../Topics/TopicNameNotContainA/media/filefolder_small.png "filefolder_small") [Multidimensional Models (SSAS)](../../Topics/TopicNameNotContainA/Multidimensional-Models--SSAS-.md)  
  
 ![Small File Folder Icon](../../Topics/TopicNameNotContainA/media/filefolder_small.png "filefolder_small") [Data Mining (SSAS)](../../Topics/TopicNameNotContainA/Data-Mining--SSAS-.md)  
  
 ![Small File Folder Icon](../../Topics/TopicNameNotContainA/media/filefolder_small.png "filefolder_small") [Power Pivot for SharePoint (SSAS)](../../Topics/TopicNameNotContainA/Power-Pivot-for-SharePoint--SSAS-.md)  
  
 ![Small File Folder Icon](../../Topics/TopicNameNotContainA/media/filefolder_small.png "filefolder_small") [Analysis Services Instance Management](../../Topics/TopicNameNotContainA/Analysis-Services-Instance-Management.md)