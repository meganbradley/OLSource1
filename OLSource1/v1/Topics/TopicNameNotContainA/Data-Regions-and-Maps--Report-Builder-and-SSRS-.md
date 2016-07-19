---
title: Data Regions and Maps (Report Builder and SSRS)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3afb8874-b36c-4e44-a0d8-80d2f7135fb1
manager: mblythe
---
# Data Regions and Maps (Report Builder and SSRS)
A data region is an object in a report that displays data from a report dataset. Report data can be displayed as numbers and text in a table, matrix, or list; graphically in a chart or gauge; and against a geographic background in a map. Tables, matrices, and lists are all based on the *tablix* data region, which expands as needed to display all the data from the dataset. A tablix data region supports multiple row and column groups and both static and dynamic rows and columns. A chart displays multiple series and category groups in a variety of chart formats. A gauge displays a single value or an aggregated value for a dataset. A map displays spatial data as map elements that can vary in appearance based on aggregated data from a dataset.  
  
 You can save a data region or map as a report part. [!INCLUDE[ssRBrptparts](../../Topics/TopicNameContainA/includes/ssRBrptparts_md.md)]  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Table  
 A table is a data region that presents data row by row. Table columns are static: you determine the number of columns when you design your report. Table rows are dynamic: they expand downwards to accommodate the data. You can add groups to tables, which organize data by selected fields or expressions. For information about adding a table to a report, see [Tables (Report Builder  and SSRS)](../../Topics/TopicNameNotContainA/Tables--Report-Builder--and-SSRS-.md).  
  
## Matrix  
 A matrix is also known as a crosstab. A matrix data region contains both dynamic columns and rows: they expand to accommodate the data. A matrix can have dynamic columns and rows and static columns and rows. Columns or rows can contain other columns or rows, and can be used to group data. For information about adding a matrix to a report, see [Create a Matrix (Report Builder and SSRS)](../../Topics/TopicNameContainA/Create-a-Matrix--Report-Builder-and-SSRS-.md)  
  
## List  
 A list is a data region that presents data arranged in a freeform fashion. You can arrange report items to create a form with text boxes, images, and other data regions placed anywhere within the list. For information about adding a list to a report, see [Create Invoices and Forms with Lists (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Create-Invoices-and-Forms-with-Lists--Report-Builder-and-SSRS-.md).  
  
## Chart  
 A chart presents data graphically. Examples of charts include bar, pie, and line charts, but many more styles are supported. For information about adding a chart to a report, see [Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Charts--Report-Builder-and-SSRS-.md).  
  
## Gauge  
 A gauge presents data as a range with an indicator pointing to a specific value within the range. Gauges are used to display key performance indicators (KPIs) and other metrics. Examples of gauges include linear and circular. For more information about adding a gauge to a report, see [Gauges (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Gauges--Report-Builder-and-SSRS-.md).  
  
## Map  
 A map enables you to present data against a geographical background. Map data can be spatial data from a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] query, an ESRI shapefile, or [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Bing map tiles. Spatial data consists of sets of coordinates that define polygons that represent shapes or areas, lines that represent routes or paths, and points represented by markers. You can associate aggregate data with map elements to automatically vary their color and size. For example, you can vary the marker type for a store based on sales amount or the color for a road based on speed limit. For more information, see [Maps (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Maps--Report-Builder-and-SSRS-.md).  
  
## Data Regions in the Report Layout  
 You can add multiple data regions to a report. Data regions grow to accommodate the data from the report dataset that they are linked to. For example, a matrix that displays sales for each product by year has a row group based on product names and a column group based on years. When you run the report, the matrix expands down the page for each product and across the page for each year. A chart that is placed next to the matrix on the report design surface displays next to the expanded matrix in the rendered report. The way data regions render on a page follows a set of rules based on the output format of a report. For example, to help control how a chart and matrix render on a page, you might use a rectangle as a container or nest both data regions in a list. For more information, see [Page Layout and Rendering (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Page-Layout-and-Rendering--Report-Builder-and-SSRS-.md).  
  
## Nested Data Regions  
 You can nest data regions within other data regions. For example, if you want to create a sales record for each sales person in a database, you can create a list with text boxes and an image to display information about the employee, and then add table and chart data regions to the list to show the employee's sales record. For more information, see [Nested Data Regions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Nested-Data-Regions--Report-Builder-and-SSRS-.md).  
  
## Multiple Data Regions Linked to the Same Dataset  
 You can link more than one data region to the same dataset to provide different views of the same data. For example, you can show the same data in a table and in a chart. You can author the report to provide interactive sort buttons on the table, so that when you sort the table, the chart is also automatically sorted. For more information, see [Linking Multiple Data Regions to the Same Dataset (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Linking-Multiple-Data-Regions-to-the-Same-Dataset--Report-Builder-and-SSRS-.md).  
  
## Data for a Data Region  
 Each tablix, chart, and gauge is designed to display data from a single dataset. A map displays spatial data and analytical data from the same or different datasets. You can also include values from datasets that are not linked to the data region in the following ways:  
  
-   Aggregate values that do not depend on sort order or grouping that are scoped to a different dataset.  
  
-   Lookup values from name/value pairs in a different dataset.  
  
 For more information, see [Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expressions--Report-Builder-and-SSRS-.md).  
  
## See Also  
 [Report Authoring Concepts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Report-Authoring-Concepts--Report-Builder-and-SSRS-.md)   
 [Reports, Report Parts, and Report Definitions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Reports--Report-Parts--and-Report-Definitions--Report-Builder-and-SSRS-.md)   
 [Page Layout and Rendering (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Page-Layout-and-Rendering--Report-Builder-and-SSRS-.md)   
 [Tutorials (Report Builder)](assetId:///c99495c3-899b-4c84-af87-76e96d4afa23)   
 [Tutorials (SSRS)](assetId:///e90cc448-563b-4dbb-9776-defb8640ec66)