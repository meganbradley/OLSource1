---
title: "uniform_int_distribution::uniform_int_distribution"
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
  - "tr1.uniform_int_distribution.uniform_int_distribution"
  - "random/std::tr1::uniform_int_distribution::uniform_int_distribution"
  - "uniform_int_distribution"
  - "std.tr1.uniform_int_distribution.uniform_int_distribution"
  - "uniform_int_distribution.uniform_int_distribution"
  - "std::tr1::uniform_int_distribution::uniform_int_distribution"
  - "tr1::uniform_int_distribution::uniform_int_distribution"
  - "uniform_int_distribution::uniform_int_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uniform_int_distribution method"
ms.assetid: 4ca958e2-ff75-4272-af3a-45710cc1d783
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uniform_int_distribution::uniform_int_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit uniform_int_distribution(result_type a = 0, result_type b = std::numeric_limits<IntType>::max());  
  
explicit uniform_int_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `a`  
 The lower bound for random values, inclusive.  
  
 `b`  
 The upper bound for random values, inclusive.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `a ≤ b`  
  
 The first constructor constructs an object whose stored `a` value holds the value `a` and whose stored `b` value holds the value `b`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [uniform_int_distribution Class](../vs140/uniform_int_distribution-class.md)