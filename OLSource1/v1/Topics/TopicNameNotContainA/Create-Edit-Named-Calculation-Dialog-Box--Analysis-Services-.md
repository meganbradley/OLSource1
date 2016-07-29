---
title: "Create/Edit Named Calculation Dialog Box (Analysis Services)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 66fb30ae-f5c5-4bfc-80ca-8c8a3a9bb30d
caps.latest.revision: 22
manager: mblythe
---
# Create/Edit Named Calculation Dialog Box (Analysis Services)
  Use the **Create/Edit Named Calculation** dialog box in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] to define or modify a named calculation for a table in a data source view. You can display the **Create/Edit Named Calculation** dialog box by:  
  
-   Clicking **New Named Calculation** in the **Toolbar** pane of **Data Source View Designer**.  
  
-   Right-clicking a table in either the **Tables** or **Diagram** pane of **Data Source View Designer** and selecting **New Named Calculation**.  
  
-   Right-clicking the name of a named calculation in the **Diagram** pane of **Data Source View Designer** and selecting **Edit Named Calculation**.  
  
## Options  
 **Column Name**  
 Type the name of the named calculation.  
  
 **Description**  
 Type the optional description of the named calculation.  
  
 **Expression**  
 Type a valid SQL expression that returns a scalar value. The expression is sent to the provider, and validated in the following expression:  
  
```  
SELECT <Table Name in Data Source>.* , <Expression> AS <Column Name> FROM <Table Name in Data Source>AS <Table Name in Data Source View>  
```  
  
 The expression can contain references to other tables, by means of a sub-select statement. If the expression would require parentheses in a SELECT statement, the expression entered must be enclosed between parentheses.  
  
## See Also  
 [Analysis Services Designers and Dialog Boxes &#40;Multidimensional Data&#41;](../../Topics/TopicNameNotContainA/Analysis-Services-Designers-and-Dialog-Boxes--Multidimensional-Data-.md)   
 [Data Source View Designer &#40;Analysis Services - Multidimensional Data&#41;](../../Topics/TopicNameNotContainA/Data-Source-View-Designer--Analysis-Services---Multidimensional-Data-.md)  
  
  