---
title: Derived Column Transformation
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8eba755e-8e48-4233-bd1e-09a46bf2692f
---
# Derived Column Transformation
  The Derived Column transformation creates new column values by applying expressions to transformation input columns. An expression can contain any combination of variables, functions, operators, and columns from the transformation input. The result can be added as a new column or inserted into an existing column as a replacement value. The Derived Column transformation can define multiple derived columns, and any variable or input columns can appear in multiple expressions.  
  
 You can use this transformation to perform the following tasks:  
  
-   Concatenate data from different columns into a derived column. For example, you can combine values from the **FirstName** and **LastName** columns into a single derived column named **FullName**, by using the expression `FirstName + " " + LastName`.  
  
-   Extract characters from string data by using functions such as SUBSTRING, and then store the result in a derived column. For example, you can extract a person's initial from the **FirstName** column, by using the expression `SUBSTRING(FirstName,1,1)`.  
  
-   Apply mathematical functions to numeric data and store the result in a derived column. For example, you can change the length and precision of a numeric column, **SalesTax**, to a number with two decimal places, by using the expression `ROUND(SalesTax, 2)`.  
  
-   Create expressions that compare input columns and variables. For example, you can compare the variable **Version** against the data in the column **ProductVersion**, and depending on the comparison result, use the value of either **Version** or **ProductVersion**, by using the expression `ProductVersion == @Version? ProductVersion : @Version`.  
  
-   Extract parts of a datetime value. For example, you can use the GETDATE and DATEPART functions to extract the current year, by using the expression `DATEPART("year",GETDATE())`.  
  
-   Convert date strings to a specific format using an expression.  
  
## Configuration of the Derived Column Transformation  
 You can configure the Derived column transformation in the following ways:  
  
-   Provide an expression for each input column or new column that will be changed. For more information, see [Integration Services &#40;SSIS&#41; Expressions](../Topic/Integration%20Services%20\(SSIS\)%20Expressions.md).  
  
    > [!NOTE]  
    >  If an expression references an input column that is overwritten by the Derived Column transformation, the expression uses the original value of the column, not the derived value.  
  
-   If adding results to new columns and the data type is **string**, specify a code page. For more information, see [Comparing String Data](../../Topics\TopicNameNotContainA/Comparing-String-Data.md).  
  
 The Derived Column transformation includes the FriendlyExpression custom property. This property can be updated by a property expression when the package is loaded. For more information, see [Use Property Expressions in Packages](../../Topics\TopicNameNotContainA/Use-Property-Expressions-in-Packages.md), and [Transformation Custom Properties](../../Topics\TopicNameNotContainA/Transformation-Custom-Properties.md).  
  
 This transformation has one input, one regular output, and one error output.  
  
 You can set properties through [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] Designer or programmatically.  
  
 For more information about the properties that you can set in the **Derived Column Transformation Editor** dialog box, see [Derived Column Transformation Editor](../../Topics\TopicNameNotContainA/Derived-Column-Transformation-Editor.md).  
  
 The **Advanced Editor** dialog box reflects the properties that can be set programmatically. For more information about the properties that you can set in the **Advanced Editor** dialog box or programmatically, click one of the following topics:  
  
-   [Common Properties](../../Topics\TopicNameNotContainA/Common-Properties.md)  
  
-   [Transformation Custom Properties](../../Topics\TopicNameNotContainA/Transformation-Custom-Properties.md)  
  
 For more information about how to set properties, click one of the following topics:  
  
-   [Set the Properties of a Data Flow Component](../../Topics\TopicNameContainA/Set-the-Properties-of-a-Data-Flow-Component.md)  
  
## Related Tasks  
  
-   [Derive Column Values by Using the Derived Column Transformation](../../Topics\TopicNameNotContainA/Derive-Column-Values-by-Using-the-Derived-Column-Transformation.md)  
  
## Related Content  
 Technical article, [SSIS Expression Examples](http://go.microsoft.com/fwlink/?LinkId=220761), on social.technet.microsoft.com  
  
 Curated Answer, [How to Split Column Data using SSIS](http://go.microsoft.com/fwlink/?LinkId=321995), on curatedviews.cloudapp.net.  
  
  