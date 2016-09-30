---
title: "SByte Data Type (Visual Basic)"
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
  - "vb.sbyte"
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
  - "SByte data type"
ms.assetid: 5c38374a-18a1-4cc2-b493-299e3dcaa60f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SByte Data Type (Visual Basic)
Holds signed 8-bit (1-byte) integers that range in value from -128 through 127.  
  
## Remarks  
 Use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> data type to contain integer values that do not require the full data width of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or even the half data width of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. In some cases the common language runtime might be able to pack your <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variables closely together and save memory consumption.  
  
 The default value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is 0.  
  
## Programming Tips  
  
-   **CLS Compliance.** The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> data type is not part of the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS), so CLS-compliant code cannot consume a component that uses it.  
  
-   **Widening.** The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> data type widens to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. This means you can convert <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to any of these types without encountering a \<xref:System.OverflowException*?displayProperty=fullName> error.  
  
-   **Type Characters.** <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> has no literal type character or identifier type character.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.SByte*?displayProperty=fullName> structure.  
  
## See Also  
 \<xref:System.SByte*?displayProperty=fullName>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Short Data Type (Visual Basic)](../vs140/short-data-type--visual-basic-.md)   
 [Integer Data Type](../vs140/integer-data-type--visual-basic-.md)   
 [Long Data Type](../vs140/long-data-type--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)