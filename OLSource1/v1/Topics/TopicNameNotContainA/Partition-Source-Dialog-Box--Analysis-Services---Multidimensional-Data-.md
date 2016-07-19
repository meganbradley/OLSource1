---
title: Partition Source Dialog Box (Analysis Services - Multidimensional Data)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c414dabe-9bad-49b7-9a3c-dfca87fef92b
manager: mblythe
---
# Partition Source Dialog Box (Analysis Services - Multidimensional Data)
Use the **Partition Source** dialog box in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] to specify the source of fact table data for a partition. You can display the **Partition Source** dialog box by:  
  
-   Clicking the **...** button on a cell from the **Partitions** grid of a selected measure group in the **Measure Groups** pane on the **Partitions** tab in Cube Designer.  
  
-   Clicking the **...** button on the **Source** property value of a **Partition** object in the **Properties** window in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)].  
  
## Options  
  
|Option|Definition|  
|------------|----------------|  
|**Binding type**|Select the binding type to use for the source of the specified partition. The following options are available:<br /><br /> **Table binding**:<br />                      Select to display the **Table Binding Detail** pane and indicate that the partition is bound to the contents of a table in a data source or data source view. For more information about the **Table Binding Detail** pane, see [Table Binding Detail (Partition Source Dialog Box) (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Table-Binding-Detail--Partition-Source-Dialog-Box---Analysis-Services---Multidimensional-Data-.md).<br /><br /> **Detail**:<br />                      Select to display the **Query Binding Detail** pane and indicate that the partition is bound to the contents of a query executed on a data source. For more information about the **Query Binding Detail** pane, see [Query Binding Detail (Partition Source Dialog Box) (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Query-Binding-Detail--Partition-Source-Dialog-Box---Analysis-Services---Multidimensional-Data-.md).|  
|**Detail**|Displays either the **Table Binding Detail** dialog box or the **Query Binding Detail** dialog box, depending on the value of the **Binding type** option.|  
  
## See Also  
 [Partitions (Cube Designer) (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Partitions--Cube-Designer---Analysis-Services---Multidimensional-Data-.md)   
 [Analysis Services Designers and Dialog Boxes (Multidimensional Data)](../../Topics/TopicNameNotContainA/Analysis-Services-Designers-and-Dialog-Boxes--Multidimensional-Data-.md)