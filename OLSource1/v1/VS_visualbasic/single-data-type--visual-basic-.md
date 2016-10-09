---
title: "Single Data Type (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Single"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Single data type"
  - "F literal type character"
  - "trailing zeros"
  - "real numbers"
  - "literal type characters, F"
  - "trailing 0 characters"
  - "identifier type characters, !"
  - "single-precision numbers"
  - "! identifier type character"
  - "0 characters, trailing"
  - "data types [Visual Basic], assigning"
  - "floating-point numbers, Single data type"
  - "numbers, real"
  - "zeros, trailing"
  - "numbers, floating point"
ms.assetid: 224a2795-4cd5-496c-8f7a-a4f05a06d45d
caps.latest.revision: 15
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Single Data Type (Visual Basic)
Holds signed IEEE 32-bit (4-byte) single-precision floating-point numbers ranging in value from -3.4028235E+38 through -1.401298E-45 for negative values and from 1.401298E-45 through 3.4028235E+38 for positive values. Single-precision numbers store an approximation of a real number.  
  
## Remarks  
 Use the `Single` data type to contain floating-point values that do not require the full data width of `Double`. In some cases the common language runtime might be able to pack your `Single` variables closely together and save memory consumption.  
  
 The default value of `Single` is 0.  
  
## Programming Tips  
  
-   **Precision.** When you work with floating-point numbers, keep in mind that they do not always have a precise representation in memory. This could lead to unexpected results from certain operations, such as value comparison and the `Mod` operator. For more information, see [Troubleshooting Data Types](../VS_visualbasic/troubleshooting-data-types--visual-basic-.md).  
  
-   **Widening.** The `Single` data type widens to `Double`. This means you can convert `Single` to `Double` without encountering a \<xref:System.OverflowException?displayProperty=fullName> error.  
  
-   **Trailing Zeros.** The floating-point data types do not have any internal representation of trailing 0 characters. For example, they do not distinguish between 4.2000 and 4.2. Consequently, trailing 0 characters do not appear when you display or print floating-point values.  
  
-   **Type Characters.** Appending the literal type character `F` to a literal forces it to the `Single` data type. Appending the identifier type character `!` to any identifier forces it to `Single`.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.Single?displayProperty=fullName> structure.  
  
## See Also  
 \<xref:System.Single?displayProperty=fullName>   
 [Data Types](../VS_visualbasic/data-type-summary--visual-basic-.md)   
 [Decimal Data Type](../VS_visualbasic/decimal-data-type--visual-basic-.md)   
 [Double Data Type](../VS_visualbasic/double-data-type--visual-basic-.md)   
 [Type Conversion Functions](../VS_visualbasic/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../VS_visualbasic/conversion-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../VS_visualbasic/efficient-use-of-data-types--visual-basic-.md)   
 [Troubleshooting Data Types](../VS_visualbasic/troubleshooting-data-types--visual-basic-.md)