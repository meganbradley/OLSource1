---
title: "extreme_value_distribution::extreme_value_distribution"
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
  - "tr1::extreme_value_distribution::extreme_value_distribution"
  - "extreme_value_distribution.extreme_value_distribution"
  - "random/std::tr1::extreme_value_distribution::extreme_value_distribution"
  - "std::tr1::extreme_value_distribution::extreme_value_distribution"
  - "std.tr1.extreme_value_distribution.extreme_value_distribution"
  - "extreme_value_distribution::extreme_value_distribution"
  - "tr1.extreme_value_distribution.extreme_value_distribution"
  - "extreme_value_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "extreme_value_distribution method"
ms.assetid: 42e1376b-5126-4cf0-a420-d5db02f228fb
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extreme_value_distribution::extreme_value_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit extreme_value_distribution(RealType a = 0.0, RealType b = 1.0);  
  
explicit extreme_value_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `a`  
 The `a` distribution parameter.  
  
 `b`  
 The `b` distribution parameter.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `0.0 < b`  
  
 The first constructor constructs an object whose stored `a` value holds the value `a` and whose stored `b` value holds the value `b`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [extreme_value_distribution Class](../vs140/extreme_value_distribution-class.md)