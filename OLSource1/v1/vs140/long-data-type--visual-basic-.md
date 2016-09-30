---
title: "Long Data Type (Visual Basic)"
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
  - "vb.Long"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "identifier type characters, &"
  - "numbers, whole"
  - "whole numbers"
  - "integral data types"
  - "& identifier type character"
  - "integer numbers"
  - "literal type characters, L"
  - "numbers, integer"
  - "integers, data types"
  - "L literal type character"
  - "integers, types"
  - "Long keyword"
  - "data types [Visual Basic], integral"
  - "data types [Visual Basic], assigning"
  - "Long data type"
ms.assetid: b4770c34-1804-4f8c-b512-c10b0893e516
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Long Data Type (Visual Basic)
Holds signed 64-bit (8-byte) integers ranging in value from -9,223,372,036,854,775,808 through 9,223,372,036,854,775,807 (9.2...E+18).  
  
## Remarks  
 Use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> data type to contain integer numbers that are too large to fit in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data type.  
  
 The default value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is 0.  
  
## Programming Tips  
  
-   **Interop Considerations.** If you are interfacing with components not written for the .NET Framework, for example Automation or COM objects, remember that <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has a different data width (32 bits) in other environments. If you are passing a 32-bit argument to such a component, declare it as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in your new Visual Basic code.  
  
     Furthermore, Automation does not support 64-bit integers on Windows 95, Windows 98, Windows ME, or Windows 2000. You cannot pass a Visual Basic <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument to an Automation component on these operating systems.  
  
-   **Widening.** The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> data type widens to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This means you can convert <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to any one of these types without encountering a \<xref:System.OverflowException*?displayProperty=fullName> error.  
  
-   **Type Characters.** Appending the literal type character <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to a literal forces it to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> data type. Appending the identifier type character <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to any identifier forces it to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.Int64*?displayProperty=fullName> structure.  
  
## See Also  
 \<xref:System.Int64*>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Integer Data Type](../vs140/integer-data-type--visual-basic-.md)   
 [Short Data Type](../vs140/short-data-type--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)