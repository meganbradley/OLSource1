---
title: "UInteger Data Type"
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
  - "vb.uinteger"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "numbers, whole"
  - "UInteger data type"
  - "literal type characters, UI"
  - "whole numbers"
  - "integral data types"
  - "integer numbers"
  - "numbers, integer"
  - "integers, data types"
  - "integers, types"
  - "UI literal type characters"
  - "data types [Visual Basic], integral"
ms.assetid: db7ddd34-4f23-46f5-84dd-8b0f83bb8729
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UInteger Data Type
Holds unsigned 32-bit (4-byte) integers ranging in value from 0 through 4,294,967,295.  
  
## Remarks  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> data type provides the largest unsigned value in the most efficient data width.  
  
 The default value of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is 0.  
  
## Programming Tips  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data types provide optimal performance on a 32-bit processor, because the smaller integer types (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>), even though they use fewer bits, take more time to load, store, and fetch.  
  
-   **Negative Numbers.** Because <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is an unsigned type, it cannot represent a negative number. If you use the unary minus (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) operator on an expression that evaluates to type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, Visual Basic converts the expression to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> first.  
  
-   **CLS Compliance.** The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> data type is not part of the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS), so CLS-compliant code cannot consume a component that uses it.  
  
-   **Interop Considerations.** If you are interfacing with components not written for the .NET Framework, for example Automation or COM objects, keep in mind that types such as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> can have a different data width (16 bits) in other environments. If you are passing a 16-bit argument to such a component, declare it as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in your managed Visual Basic code.  
  
-   **Widening.** The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> data type widens to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. This means you can convert <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to any of these types without encountering a \<xref:System.OverflowException*?displayProperty=fullName> error.  
  
-   **Type Characters.** Appending the literal type characters <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to a literal forces it to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> data type. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> has no identifier type character.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.UInt32*?displayProperty=fullName> structure.  
  
## See Also  
 \<xref:System.UInt32*>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [How to: Call a Windows Function that Takes Unsigned Types](../vs140/how-to--call-a-windows-function-that-takes-unsigned-types--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)