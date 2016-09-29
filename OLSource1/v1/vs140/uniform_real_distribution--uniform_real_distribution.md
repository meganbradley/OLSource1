---
title: "uniform_real_distribution::uniform_real_distribution"
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
  - "tr1.uniform_real_distribution.uniform_real_distribution"
  - "uniform_real_distribution.uniform_real_distribution"
  - "std::tr1::uniform_real_distribution::uniform_real_distribution"
  - "uniform_real_distribution::uniform_real_distribution"
  - "random/std::tr1::uniform_real_distribution::uniform_real_distribution"
  - "std.tr1.uniform_real_distribution.uniform_real_distribution"
  - "uniform_real_distribution"
  - "tr1::uniform_real_distribution::uniform_real_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uniform_real_distribution method"
ms.assetid: 2f09925e-c7fe-4553-9684-019b0dead773
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uniform_real_distribution::uniform_real_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit uniform_real_distribution(RealType a = 0.0, RealType b = 1.0);  
  
explicit uniform_real_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `a`  
 The lower bound for random values, inclusive.  
  
 `b`  
 The upper bound for random values, exclusive.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `a < b`  
  
 The first constructor constructs an object whose stored `a` value holds the value `a` and whose stored `b` value holds the value `b`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [uniform_real_distribution Class](../vs140/uniform_real_distribution-class.md)