---
title: "UShort Data Type (Visual Basic)"
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
  - "vb.ushort"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "numbers, whole"
  - "literal type characters, US"
  - "whole numbers"
  - "integral data types"
  - "integer numbers"
  - "numbers, integer"
  - "integers, data types"
  - "integers, types"
  - "data types [Visual Basic], integral"
  - "UShort data type"
  - "US literal type characters"
ms.assetid: 138db892-665d-4ba8-9cae-d8d91c4a8f39
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UShort Data Type (Visual Basic)
Holds unsigned 16-bit (2-byte) integers ranging in value from 0 through 65,535.  
  
## Remarks  
 Use the `UShort` data type to contain binary data too large for `Byte`.  
  
 The default value of `UShort` is 0.  
  
## Programming Tips  
  
-   **Negative Numbers.** Because `UShort` is an unsigned type, it cannot represent a negative number. If you use the unary minus (`-`) operator on an expression that evaluates to type `UShort`, Visual Basic converts the expression to `Integer` first.  
  
-   **CLS Compliance.** The `UShort` data type is not part of the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS), so CLS-compliant code cannot consume a component that uses it.  
  
-   **Widening.** The `UShort` data type widens to `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, and `Double`. This means you can convert `UShort` to any of these types without encountering a <xref:System.OverflowException*?displayProperty=fullName> error.  
  
-   **Type Characters.** Appending the literal type characters `US` to a literal forces it to the `UShort` data type. `UShort` has no identifier type character.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the <xref:System.UInt16*?displayProperty=fullName> structure.  
  
## See Also  
 <xref:System.UInt16*>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [How to: Call a Windows Function that Takes Unsigned Types](../vs140/how-to--call-a-windows-function-that-takes-unsigned-types--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)