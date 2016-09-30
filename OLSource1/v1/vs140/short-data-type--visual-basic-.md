---
title: "Short Data Type (Visual Basic)"
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
  - "vb.Short"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "numbers, whole"
  - "whole numbers"
  - "integral data types"
  - "integer numbers"
  - "numbers, integer"
  - "integers, data types"
  - "integers, types"
  - "data types [Visual Basic], integral"
  - "S literal type character"
  - "Short data type"
  - "literal type characters, S"
ms.assetid: 65fcbcf3-a841-400e-885e-301497729a8b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Short Data Type (Visual Basic)
Holds signed 16-bit (2-byte) integers that range in value from -32,768 through 32,767.  
  
## Remarks  
 Use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> data type to contain integer values that do not require the full data width of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. In some cases, the common language runtime can pack your <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> variables closely together and save memory consumption.  
  
 The default value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is 0.  
  
## Programming Tips  
  
-   **Widening.** The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> data type widens to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. This means you can convert <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to any one of these types without encountering a \<xref:System.OverflowException*?displayProperty=fullName> error.  
  
-   **Type Characters.** Appending the literal type character <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to a literal forces it to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> data type. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has no identifier type character.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.Int16*?displayProperty=fullName> structure.  
  
## See Also  
 \<xref:System.Int16*?displayProperty=fullName>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Integer Data Type](../vs140/integer-data-type--visual-basic-.md)   
 [Long Data Type](../vs140/long-data-type--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)