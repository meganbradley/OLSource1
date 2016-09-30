---
title: "numeric_limits::has_denorm"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "numeric_limits.has_denorm"
  - "limits/std::numeric_limits::has_denorm"
  - "has_denorm"
  - "numeric_limits::has_denorm"
  - "std.numeric_limits.has_denorm"
  - "std::numeric_limits::has_denorm"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_denorm method"
ms.assetid: 40c3cdd9-fd70-4a1b-9454-e38cf8ac4019
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::has_denorm
Tests whether a type allows denormalized values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An enumeration value of type **const** <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, indicating whether the type allows denormalized values.  
  
## Remarks  
 The member stores **denorm_present** for a floating-point type that has denormalized values, effectively a variable number of exponent bits.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Whether float objects allow denormalized values: 1**  
**Whether double objects allow denormalized values: 1**  
**Whether long int objects allow denormalized values: 0**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)