---
title: "Decimal Data Type (Visual Basic)"
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
  - "vb.Decimal"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "literal type characters, D"
  - "trailing zeros"
  - "real numbers"
  - "trailing 0 characters"
  - "Decimal data type"
  - "D literal type character"
  - "decimals, Decimal data type"
  - "0 characters, trailing"
  - "data types [Visual Basic], assigning"
  - "decimal keyword"
  - "numbers, real"
  - "variable-precision numbers"
  - "zeros, trailing"
  - "@ identifier type character"
  - "identifier type characters, @"
ms.assetid: 1d855b45-afe2-45b0-a623-96b6f63a43d5
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Decimal Data Type (Visual Basic)
Holds signed 128-bit (16-byte) values representing 96-bit (12-byte) integer numbers scaled by a variable power of 10. The scaling factor specifies the number of digits to the right of the decimal point; it ranges from 0 through 28. With a scale of 0 (no decimal places), the largest possible value is +/-79,228,162,514,264,337,593,543,950,335 (+/-7.9228162514264337593543950335E+28). With 28 decimal places, the largest value is +/-7.9228162514264337593543950335, and the smallest nonzero value is +/-0.0000000000000000000000000001 (+/-1E-28).  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data type provides the greatest number of significant digits for a number. It supports up to 29 significant digits and can represent values in excess of 7.9228 x 10^28. It is particularly suitable for calculations, such as financial, that require a large number of digits but cannot tolerate rounding errors.  
  
 The default value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is 0.  
  
## Programming Tips  
  
-   **Precision.** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not a floating-point data type. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure holds a binary integer value, together with a sign bit and an integer scaling factor that specifies what portion of the value is a decimal fraction. Because of this, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> numbers have a more precise representation in memory than floating-point types (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>).  
  
-   **Performance.** The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> data type is the slowest of all the numeric types. You should weigh the importance of precision against performance before choosing a data type.  
  
-   **Widening.** The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> data type widens to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. This means you can convert <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to either of these types without encountering a \<xref:System.OverflowException*?displayProperty=fullName> error.  
  
-   **Trailing Zeros.** Visual Basic does not store trailing zeros in a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> literal. However, a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> variable preserves any trailing zeros acquired computationally. The following example illustrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The output of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in the preceding example is as follows:  
  
     d1 = 2.375, d2 = 1.625, d3 = 4.000, d4 = 4  
  
-   **Type Characters.** Appending the literal type character <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to a literal forces it to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> data type. Appending the identifier type character <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to any identifier forces it to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.Decimal*?displayProperty=fullName> structure.  
  
## Range  
 You might need to use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> type character to assign a large value to a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> variable or constant. This requirement is because the compiler interprets a literal as <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> unless a literal type character follows the literal, as the following example shows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The declaration for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> doesn't produce an overflow because the value that's assigned to it falls within the range for <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> value can be assigned to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> variable.  
  
 The declaration for <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> generates an overflow error because the value that's assigned to it is too large for <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. Because the numeric literal can't first be interpreted as a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, it can't be assigned to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> variable.  
  
 For <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, the literal type character <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> solves the problem by forcing the compiler to interpret the literal as a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> instead of as a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
## See Also  
 \<xref:System.Decimal*?displayProperty=fullName>   
 \<xref:System.Decimal.#ctor*?displayProperty=fullName>   
 \<xref:System.Math.Round*?displayProperty=fullName>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Single Data Type (Visual Basic)](../vs140/single-data-type--visual-basic-.md)   
 [Double Data Type (Visual Basic)](../vs140/double-data-type--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)