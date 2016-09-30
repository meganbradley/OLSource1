---
title: "numeric_limits::infinity"
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
  - "std::numeric_limits::infinity"
  - "limits/std::numeric_limits::infinity"
  - "std.numeric_limits.infinity"
  - "numeric_limits::infinity"
  - "numeric_limits.infinity"
  - "infinity"
  - "Infinity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "infinity method"
ms.assetid: 7c739089-be18-49d5-bb92-fd45fb3f1300
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::infinity
The representation of positive infinity for a type, if available.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The representation of positive infinity for a type, if available.  
  
## Remarks  
 The return value is meaningful only if [has_infinity](../vs140/numeric_limits--has_infinity.md) is **true**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1**  
**1**  
**1**  
**0**  
**0**  
**The representation of infinity for type float is: 1.#INF**  
**The representation of infinity for type double is: 1.#INF**  
**The representation of infinity for type long double is: 1.#INF**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)