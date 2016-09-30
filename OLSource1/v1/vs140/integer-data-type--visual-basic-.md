---
title: "Integer Data Type (Visual Basic)"
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
  - "vb.Integer"
  - "Integer"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "numbers, whole"
  - "enumerated values"
  - "whole numbers"
  - "integral data types"
  - "integer numbers"
  - "numbers, integer"
  - "integers, data types"
  - "literal type characters, I"
  - "integers, types"
  - "data types [Visual Basic], integral"
  - "% identifier type character"
  - "data types [Visual Basic], assigning"
  - "identifier type characters, %"
  - "I literal type character"
  - "Integer data type"
ms.assetid: a8f233b4-4be3-455c-861b-05af2fbb6c60
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Integer Data Type (Visual Basic)
Holds signed 32-bit (4-byte) integers that range in value from -2,147,483,648 through 2,147,483,647.  
  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data type provides optimal performance on a 32-bit processor. The other integral types are slower to load and store from and to memory.  
  
 The default value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is 0.  
  
## Programming Tips  
  
-   **Interop Considerations.** If you are interfacing with components not written for the .NET Framework, for example Automation or COM objects, remember that <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has a different data width (16 bits) in other environments. If you are passing a 16-bit argument to such a component, declare it as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in your new Visual Basic code.  
  
-   **Widening.** The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> data type widens to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This means you can convert <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to any one of these types without encountering a \<xref:System.OverflowException*?displayProperty=fullName> error.  
  
-   **Type Characters.** Appending the literal type character <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to a literal forces it to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> data type. Appending the identifier type character <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to any identifier forces it to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.Int32*?displayProperty=fullName> structure.  
  
## Range  
 If you try to set a variable of an integral type to a number outside the range for that type, an error occurs. If you try to set it to a fraction, the number is rounded up or down to the nearest integer value. If the number is equally close to two integer values, the value is rounded to the nearest even integer. This behavior minimizes rounding errors that result from consistently rounding a midpoint value in a single direction. The following code shows examples of rounding.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Int32*?displayProperty=fullName>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Long Data Type](../vs140/long-data-type--visual-basic-.md)   
 [Short Data Type](../vs140/short-data-type--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)