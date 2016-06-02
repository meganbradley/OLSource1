---
title: Data Conversion Transformation Editor
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7b4e4873-e8fe-4549-a965-65bebdb270bc
---
# Data Conversion Transformation Editor
  Use the **Data Conversion Transformation Editor** dialog box to select the columns to convert, select the data type to which the column is converted, and set conversion attributes.  
  
> [!NOTE]  
>  The **FastParse** property of the output columns of the Data Conversion transformation is not available in the **Data Conversion Transformation Editor**, but can be set by using the **Advanced Editor**. For more information on this property, see the Data Conversion Transformation section of [Transformation Custom Properties](../../Topics\TopicNameNotContainA/Transformation-Custom-Properties.md).  
  
 To learn more about the Data Conversion transformation, see [Data Conversion Transformation](../../Topics\TopicNameNotContainA/Data-Conversion-Transformation.md).  
  
## Options  
 **Available Input Columns**  
 Select columns to convert by using the check boxes. Your selections add input columns to the table below.  
  
 **Input Column**  
 Select columns to convert from the list of available input columns. Your selections are reflected in the check box selections above.  
  
 **Output Alias**  
 Type an alias for each new column. The default is **Copy of** followed by the input column name; however, you can choose any unique, descriptive name.  
  
 **Data Type**  
 Select an available data type from the list. For more information, see [Integration Services Data Types](../../Topics\TopicNameNotContainA/Integration-Services-Data-Types.md).  
  
 **Length**  
 Set the column length for string data.  
  
 **Precision**  
 Set the precision for numeric data.  
  
 **Scale**  
 Set the scale for numeric data.  
  
 **Code page**  
 Select the appropriate code page for columns of type DT\_STR.  
  
 **Configure error output**  
 Specify how to handle row\-level errors by using the [Configure Error Output](../../Topics\TopicNameNotContainA/Configure-Error-Output.md) dialog box.  
  
## See Also  
 [Integration Services Error and Message Reference](../../Topics\TopicNameNotContainA/Integration-Services-Error-and-Message-Reference.md)   
 [Convert Data to a Different Data Type by Using the Data Conversion Transformation](../../Topics\TopicNameContainA/Convert-Data-to-a-Different-Data-Type-by-Using-the-Data-Conversion-Transformation.md)  
  
  