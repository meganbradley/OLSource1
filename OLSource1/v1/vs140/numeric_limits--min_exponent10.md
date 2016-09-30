---
title: "numeric_limits::min_exponent10"
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
  - "numeric_limits.min_exponent10"
  - "std::numeric_limits::min_exponent10"
  - "std.numeric_limits.min_exponent10"
  - "min_exponent10"
  - "numeric_limits::min_exponent10"
  - "limits/std::numeric_limits::min_exponent10"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "min_exponent10 method"
ms.assetid: e0b9bc9b-c3d7-49b5-a9d6-bfeee2a5a3c4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::min_exponent10
Returns the maximum negative integral exponent that the floating-point type can represent as a finite value when a base of ten is raised to that power.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The minimum integral base 10 exponent representable by the type.  
  
## Remarks  
 The member function is meaningful only for floating-point types. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the value FLT_MIN_10_EXP for type **float**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The minimum base 10 exponent for type float is:  -37**  
**The minimum base 10 exponent for type double is:  -307**  
**The minimum base 10 exponent for type long double is:  -307**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)