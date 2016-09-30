---
title: "numeric_limits::has_infinity"
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
  - "std::numeric_limits::has_infinity"
  - "numeric_limits::has_infinity"
  - "std.numeric_limits.has_infinity"
  - "has_infinity"
  - "numeric_limits.has_infinity"
  - "limits/std::numeric_limits::has_infinity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_infinity method"
ms.assetid: 4ef2d2f1-eb1b-4a9d-9b8a-c9a7759fde2a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::has_infinity
Tests whether a type has a representation for positive infinity.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 **true** if the type has a representation for positive infinity; **false** if not.  
  
## Remarks  
 The member returns **true** if [is_iec559](../vs140/numeric_limits--is_iec559.md) is **true**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Whether float objects have infinity: 1**  
**Whether double objects have infinity: 1**  
**Whether long int objects have infinity: 0**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)