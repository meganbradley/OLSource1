---
title: "float_round_style"
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
  - "limits/std::float_round_style"
  - "std::float_round_style"
  - "float_round_style"
  - "std.float_round_style"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "float_round_style typedef"
  - "float_round_style function"
ms.assetid: 0b07019c-7185-4686-9227-45a03ba1bf1b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# float_round_style
The enumeration describes the various methods that an implementation can choose for rounding a floating-point value to an integer value.  
  
## Syntax  
  
```  
  
   enum float_round_style {  
round_indeterminate = -1,  
round_toward_zero = 0,  
round_to_nearest = 1,  
round_toward_infinity = 2,  
round_toward_neg_infinity = 3  
};  
```  
  
## Return Value  
 The enumeration returns:  
  
-   **round_indeterminate** if the rounding method cannot be determined.  
  
-   **round_toward_zero** if the round toward zero.  
  
-   **round_to_nearest** if the round to nearest integer.  
  
-   **round_toward_infinity** if the round away from zero.  
  
-   **round_toward_neg_infinity** if the round to more negative integer.  
  
## Example  
 See [numeric_limits::round_style](../vs140/numeric_limits--round_style.md) for an example in which the values of this enumeration may be accessed.  
  
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std