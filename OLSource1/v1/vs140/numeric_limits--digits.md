---
title: "numeric_limits::digits"
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
  - "std.numeric_limits.digits"
  - "std::numeric_limits::digits"
  - "numeric_limits::digits"
  - "limits/std::numeric_limits::digits"
  - "digits"
  - "numeric_limits.digits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "digits method"
ms.assetid: bc515ce2-da5c-4061-8400-577adaa929dc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::digits
Returns the number of radix digits that the type can represent without loss of precision.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of radix digits that the type can represent without loss of precision.  
  
## Remarks  
 The member stores the number of radix digits that the type can represent without change, which is the number of bits other than any sign bit for a predefined integer type, or the number of mantissa digits for a predefined floating-point type.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **24**  
**53**  
**53**  
**31**  
**63**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)