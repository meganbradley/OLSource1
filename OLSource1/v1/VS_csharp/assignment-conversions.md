---
title: "Assignment Conversions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "conversions, assignment"
  - "assignment conversions"
ms.assetid: 4ee01013-de32-4aae-b12e-0051d0cde927
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Assignment Conversions
In assignment operations, the type of the value being assigned is converted to the type of the variable that receives the assignment. C allows conversions by assignment between integral and floating types, even if information is lost in the conversion. The conversion method used depends on the types involved in the assignment, as described in [Usual Arithmetic Conversions](../VS_csharp/usual-arithmetic-conversions.md) and in the following sections:  
  
-   [Conversions from Signed Integral Types](../VS_csharp/conversions-from-signed-integral-types.md)  
  
-   [Conversions from Unsigned Integral Types](../VS_csharp/conversions-from-unsigned-integral-types.md)  
  
-   [Conversions from Floating-Point Types](../VS_csharp/conversions-from-floating-point-types.md)  
  
-   [Conversions to and from Pointer Types](../VS_csharp/conversions-to-and-from-pointer-types.md)  
  
-   [Conversions from Other Types](../VS_csharp/conversions-from-other-types.md)  
  
 Type qualifiers do not affect the allowability of the conversion although a **const** l-value cannot be used on the left side of the assignment.  
  
## See Also  
 [Type Conversions (C/C++ Languages)](../VS_csharp/type-conversions--c-.md)