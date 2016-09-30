---
title: "numeric_limits::denorm_min"
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
  - "denorm_min"
  - "limits/std::numeric_limits::denorm_min"
  - "std::numeric_limits::denorm_min"
  - "numeric_limits::denorm_min"
  - "std.numeric_limits.denorm_min"
  - "numeric_limits.denorm_min"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "denorm_min method"
ms.assetid: 2b9b0c5b-465c-4024-8849-ff816b1d2132
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::denorm_min
Returns the smallest nonzero denormalized value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The smallest nonzero denormalized value.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the same as **double** for the C++ compiler.  
  
 The function returns the minimum value for the type, which is the same as [min](../vs140/numeric_limits--min.md) if [has_denorm](../vs140/numeric_limits--has_denorm.md) is not equal to **denorm_present**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The smallest nonzero denormalized value**  
 **for float objects is: 1.4013e-045**  
**The smallest nonzero denormalized value**  
 **for double objects is: 4.94066e-324**  
**The smallest nonzero denormalized value**  
 **for long double objects is: 4.94066e-324**  
**0**  
**0**  
**0**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)