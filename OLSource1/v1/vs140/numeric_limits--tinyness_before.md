---
title: "numeric_limits::tinyness_before"
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
  - "numeric_limits::tinyness_before"
  - "tinyness_before"
  - "std.numeric_limits.tinyness_before"
  - "limits/std::numeric_limits::tinyness_before"
  - "std::numeric_limits::tinyness_before"
  - "numeric_limits.tinyness_before"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tinyness_before method"
ms.assetid: 2cb23ad1-2196-44fd-9d46-138f4eeee134
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::tinyness_before
Tests whether a type can determine that a value is too small to represent as a normalized value before rounding it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the type can detect tiny values before rounding; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if it cannot.  
  
## Remarks  
 Types that can detect tinyness were included as an option with IEC 559 floating-point representations and its implementation can affect some results.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Whether float types can detect tinyness before rounding: 1**  
**Whether double types can detect tinyness before rounding: 1**  
**Whether long int types can detect tinyness before rounding: 0**  
**Whether unsigned char types can detect tinyness before rounding: 0**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)