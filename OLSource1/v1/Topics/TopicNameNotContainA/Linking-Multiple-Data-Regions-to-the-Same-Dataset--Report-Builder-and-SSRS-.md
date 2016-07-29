---
title: "Linking Multiple Data Regions to the Same Dataset (Report Builder and SSRS)"
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
ms.assetid: 90c94a91-8fb2-42cb-b998-563691f30d2d
caps.latest.revision: 10
manager: mblythe
---
# Linking Multiple Data Regions to the Same Dataset (Report Builder and SSRS)
You can add multiple data regions to a report to provide different views of data from the same report dataset. For example, you might want to display data in a table and also display it visually in a chart. To do so, you must use identical expressions and scopes for the appropriate filter expressions, sort expressions, and group expressions.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
 To use a chart and a table or matrix to display the same data, it helps to understand the similarities between a table and shape charts, and a matrix and area, bar, and column charts. A table with a single row group can easily be displayed as a pie chart. As you add multiple row groups, you can choose different types of charts to best display the nested groups. Adding nested row groups to a pie chart increases the number of slices in the pie. You must decide if the number of group instances for the parent group and child group combined is too many to display in a single pie chart. For multiple group values that display as small slices on a pie chart, you can set a property so that all values below a certain threshold display as one pie slice. For more information, see [Collect Small Slices on a Pie Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Collect-Small-Slices-on-a-Pie-Chart--Report-Builder-and-SSRS-.md).  
  
 A table with multiple row groups can be shown as a column chart with multiple category groups. For more information, see [Display the Same Data on a Matrix and a Chart (Report Builder)](../../Topics/TopicNameContainA/Display-the-Same-Data-on-a-Matrix-and-a-Chart--Report-Builder-.md). For an example of a table and chart that present different views of the same report dataset, see the Product Line Sales report in AdventureWorks Report Samples. Because both the table and the chart are linked to the same dataset in this report, when you click the interactive sort button for Employee Name in the sort the Top Employees table, the Top Employees chart also automatically shows the new sort order. For more information about downloading this sample report and others, see [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)][Report Builder and Report Designer sample reports](http://go.microsoft.com/fwlink/?LinkId=198283).  
  
 A matrix with multiple row and column groups can best be displayed by using an area, bar, or column chart with both category and series groups. Use the same group expressions for column groups on the matrix and category groups on the chart, and the same group expressions for row groups on the matrix and series groups on the chart. You must keep in mind that the number of group instances affects the readability of the chart. You can define groups based on range values to reduce the number of group instances in a report. For more information, see [Group Expression Examples (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Group-Expression-Examples--Report-Builder-and-SSRS-.md).  
  
## See Also  
 [Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Charts--Report-Builder-and-SSRS-.md)   
 [Tables, Matrices, and Lists (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Tables--Matrices--and-Lists--Report-Builder-and-SSRS-.md)   
 [Nested Data Regions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Nested-Data-Regions--Report-Builder-and-SSRS-.md)