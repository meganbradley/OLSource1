---
title: "Long Data Type (Visual Basic)"
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
caps.latest.revision: 20
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
# Long Data Type (Visual Basic)
Holds signed 64-bit (8-byte) integers ranging in value from -9,223,372,036,854,775,808 through 9,223,372,036,854,775,807 (9.2...E+18).  
  
## Remarks  
 Use the `Long` data type to contain integer numbers that are too large to fit in the `Integer` data type.  
  
 The default value of `Long` is 0.  
  
## Programming Tips  
  
-   **Interop Considerations.** If you are interfacing with components not written for the .NET Framework, for example Automation or COM objects, remember that `Long` has a different data width (32 bits) in other environments. If you are passing a 32-bit argument to such a component, declare it as `Integer` instead of `Long` in your new Visual Basic code.  
  
     Furthermore, Automation does not support 64-bit integers on Windows 95, Windows 98, Windows ME, or Windows 2000. You cannot pass a Visual Basic `Long` argument to an Automation component on these operating systems.  
  
-   **Widening.** The `Long` data type widens to `Decimal`, `Single`, or `Double`. This means you can convert `Long` to any one of these types without encountering a \<xref:System.OverflowException?displayProperty=fullName> error.  
  
-   **Type Characters.** Appending the literal type character `L` to a literal forces it to the `Long` data type. Appending the identifier type character `&` to any identifier forces it to `Long`.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.Int64?displayProperty=fullName> structure.  
  
## See Also  
 \<xref:System.Int64>   
 [Data Types](../VS_visualbasic/data-type-summary--visual-basic-.md)   
 [Integer Data Type](../VS_visualbasic/integer-data-type--visual-basic-.md)   
 [Short Data Type](../VS_visualbasic/short-data-type--visual-basic-.md)   
 [Type Conversion Functions](../VS_visualbasic/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../VS_visualbasic/conversion-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../VS_visualbasic/efficient-use-of-data-types--visual-basic-.md)