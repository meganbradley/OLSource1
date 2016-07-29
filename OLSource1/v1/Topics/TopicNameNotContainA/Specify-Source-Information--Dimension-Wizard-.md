---
title: "Specify Source Information (Dimension Wizard)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0538b490-5185-49e1-a783-4ce3539a0de5
caps.latest.revision: 28
manager: mblythe
---
# Specify Source Information (Dimension Wizard)
Use the **Select the Main Dimension Table** page to select the data source view, main dimension table, key columns, and member name column for the dimension to be created.  
  
 **To open the Dimension Wizard**  
  
-   In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], in **Solution Explorer**, right-click the **Dimensions** folder for an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] project, and then click **New Dimension**.  
  
## Options  
 **Data source view**  
 Select a data source view.  
  
 **Main table**  
 Select a table from the selected data source view to use as the main table for the dimension.  
  
 **Key columns**  
 Select the key columns from the table specified in **Main table** for the key attribute of the dimension.  
  
> [!NOTE]  
>  More than one column can be selected. If the table contains a composite primary key, select all the columns included in the composite primary key. The order of the key columns is important.  
  
 **Name column**  
 Select the column from the table specified in **Main table** that provides the member names for the dimension. A name column must be specified when a composite key is used. To create a name column for a composite key, we recommend that you create a named calculation in the data source view that concatenates the specified key columns. When a single key is used, the name column is optional.  
  
## See Also  
 [Dimension Wizard F1 Help](../../Topics/TopicNameNotContainA/Dimension-Wizard-F1-Help.md)   
 [Dimensions (SSAS)](assetId:///2b114135-2572-4479-8c81-3ccf0cfeb9f7)   
 [Dimensions in Multidimensional Models](../../Topics/TopicNameNotContainA/Dimensions-in-Multidimensional-Models.md)