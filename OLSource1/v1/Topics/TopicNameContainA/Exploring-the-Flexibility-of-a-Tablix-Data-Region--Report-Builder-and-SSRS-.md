---
title: Exploring the Flexibility of a Tablix Data Region (Report Builder and SSRS)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fef19359-a618-4d21-a7e4-e391cdefd4eb
manager: mblythe
---
# Exploring the Flexibility of a Tablix Data Region (Report Builder and SSRS)
When you add a table, matrix, or list data region from the Insert tab on the ribbon, you start with an initial template for a tablix data region, but you are not limited by that template. You can continue to develop how your data displays by adding or removing any tablix data region feature such as  groups, rows, and columns.  
  
 When you delete a row or column group, you have the option of deleting the rows and columns that are used to display group values. You can also add or remove rows and columns manually. To understand how rows and columns are used to display detail and group data, see [Tablix Data Region (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Tablix-Data-Region--Report-Builder-and-SSRS-.md).  
  
 After you change the structure of the tablix data region, you can set properties to help control the way the report renders the data region; for example, you can repeat column headers at the top of every page, or keep a group header with the group. For more information, see [Controlling the Tablix Data Region Display on a Report Page (Report Builder and SSRS)](../../Topics/TopicNameContainA/Controlling-the-Tablix-Data-Region-Display-on-a-Report-Page--Report-Builder-and-SSRS-.md).  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Changing a Table to a Matrix  
 By default, a table has detail rows that display the values from the report dataset. Typically, a table includes row groups that organize the detail data by group, and then includes aggregated values based on each group. To change the table to a matrix, add column groups. Typically, you would remove the details group when the data region has both row and column groups so that you can display only the summary values for the groups. For more information, see [Add or Delete a Group in a Data Region (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-or-Delete-a-Group-in-a-Data-Region--Report-Builder-and-SSRS-.md).  
  
 By definition, when you create a matrix, you add a tablix corner cell. You can merge cells in this area and add a label. For more information, see [Merge Cells in a Data Region (Report Builder and SSRS)](../../Topics/TopicNameContainA/Merge-Cells-in-a-Data-Region--Report-Builder-and-SSRS-.md).  
  
## Changing a Matrix to a Table  
 By default, a matrix has row groups and column groups and no detail group. To change a matrix to a table, remove column groups and add a details group to display on the details row. For more information, see [Add or Delete a Group in a Data Region (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-or-Delete-a-Group-in-a-Data-Region--Report-Builder-and-SSRS-.md) and [Add a Details Group (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-a-Details-Group--Report-Builder-and-SSRS-.md).  
  
## Changing a Default List to a Grouped List  
 By default, a list has detail rows and no groups. To change the list to use a group row, rename the details group and specify a group expression. For more information, see [Add or Delete a Group in a Data Region (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-or-Delete-a-Group-in-a-Data-Region--Report-Builder-and-SSRS-.md)  
  
## Creating Stepped Displays  
 By default, when you add groups to a tablix data region, cells in the row group header area display group values in column. When you have nested groups, each group displays in a separate column. To create a stepped display, remove all group columns except one, and format the remaining column to display the group hierarchy as an indented text display. For more information, see [Create a Stepped Report (Report Builder and SSRS)](../../Topics/TopicNameContainA/Create-a-Stepped-Report--Report-Builder-and-SSRS-.md).  
  
## Adding an Adjacent Details Group  
 By default, the details group is the innermost child group in a group hierarchy. You cannot nest a group under the details group. You can create additional adjacent details groups, to display the top 5 products and the bottom 5 products by sales, for example. Because you can add filter and sort expressions on each group, you can show two views of detail data from the same dataset in one tablix data region. For more information, see [Understanding Groups (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Understanding-Groups--Report-Builder-and-SSRS-.md), [Add or Delete a Group in a Data Region (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-or-Delete-a-Group-in-a-Data-Region--Report-Builder-and-SSRS-.md), and [Add a Filter to a Dataset (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-a-Filter-to-a-Dataset--Report-Builder-and-SSRS-.md).  
  
## See Also  
 [Tablix Data Region (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Tablix-Data-Region--Report-Builder-and-SSRS-.md)   
 [Tables, Matrices, and Lists (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Tables--Matrices--and-Lists--Report-Builder-and-SSRS-.md)   
 [Tables (Report Builder  and SSRS)](../../Topics/TopicNameNotContainA/Tables--Report-Builder--and-SSRS-.md)   
 [Create a Matrix (Report Builder and SSRS)](../../Topics/TopicNameContainA/Create-a-Matrix--Report-Builder-and-SSRS-.md)   
 [Create Invoices and Forms with Lists (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Create-Invoices-and-Forms-with-Lists--Report-Builder-and-SSRS-.md)