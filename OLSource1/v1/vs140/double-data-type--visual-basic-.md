---
title: "Double Data Type (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Double"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "identifier type characters, #"
  - "trailing zeros"
  - "real numbers"
  - "trailing 0 characters"
  - "0 characters, trailing"
  - "literal type characters, R"
  - "data types [Visual Basic], assigning"
  - "Double data type [Visual Basic]"
  - "# identifier type character"
  - "double-precision numbers"
  - "floating-point numbers, Double data type"
  - "R literal type character"
  - "zeros, trailing"
  - "Double data type"
ms.assetid: 0c5670f7-fcb1-453a-bef1-374730cd38fd
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Double Data Type (Visual Basic)
Holds signed IEEE 64-bit (8-byte) double-precision floating-point numbers that range in value from -1.79769313486231570E+308 through -4.94065645841246544E-324 for negative values and from 4.94065645841246544E-324 through 1.79769313486231570E+308 for positive values. Double-precision numbers store an approximation of a real number.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data type provides the largest and smallest possible magnitudes for a number.  
  
 The default value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is 0.  
  
## Programming Tips  
  
-   **Precision.** When you work with floating-point numbers, remember that they do not always have a precise representation in memory. This could lead to unexpected results from certain operations, such as value comparison and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator. For more information, see [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md).  
  
-   **Trailing Zeros.** The floating-point data types do not have any internal representation of trailing zero characters. For example, they do not distinguish between 4.2000 and 4.2. Consequently, trailing zero characters do not appear when you display or print floating-point values.  
  
-   **Type Characters.** Appending the literal type character <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to a literal forces it to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> data type. For example, if an integer value is followed by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the value is changed to a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     Appending the identifier type character <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to any identifier forces it to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. In the following example, the variable <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is typed as a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.Double*?displayProperty=fullName> structure.  
  
## See Also  
 \<xref:System.Double*?displayProperty=fullName>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Decimal Data Type (Visual Basic)](../vs140/decimal-data-type--visual-basic-.md)   
 [Single Data Type](../vs140/single-data-type--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [Type Characters](../vs140/type-characters--visual-basic-.md)