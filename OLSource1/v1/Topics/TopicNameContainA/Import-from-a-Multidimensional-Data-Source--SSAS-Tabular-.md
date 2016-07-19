---
title: Import from a Multidimensional Data Source (SSAS Tabular)
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
ms.assetid: 7f0793ea-a4c7-42e9-b722-2164a454ebca
manager: mblythe
---
# Import from a Multidimensional Data Source (SSAS Tabular)
You can use an Analysis Services cube database as a data source for a tabular model. In order to import data from an Analysis Services cube, you must define an MDX Query to select data to import.  
  
 Any data that is contained in a SQL Server Analysis Services database can be imported into a model. You can extract all or part of a dimension, or get slices and aggregates from the cube, such as the sum of sales, month by month, for the current year, etc. However, you should keep in mind all data that you import from a cube is flattened. Therefore, if you define a query that retrieves measures along multiple dimensions, the data will be imported with each dimension in a separate column.  
  
 Analysis Services cubes must be version SQL Server 2005, SQL Server 2008, SQL Server 2008 R2, [!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)], or [!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)].  
  
### To import data from an Analysis Services cube  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], click the **Model** menu, and then click **Import from Data Source**.  
  
2.  On the **Connect to a Data Source** page, select **Microsoft Analysis Services**, and then click **Next**.  
  
3.  Follow the steps in the Table Import Wizard. You will be able to specify an MDX query on the **Specify a MDX Query** page. To use the MDX Query Designer, on the Specify a MDX Query page, click **Design**.  
  
## See Also  
 [Import Data (SSAS Tabular)](../../Topics/TopicNameNotContainA/Import-Data--SSAS-Tabular-.md)   
 [Data Sources Supported (SSAS Tabular)](../../Topics/TopicNameNotContainA/Data-Sources-Supported--SSAS-Tabular-.md)