---
title: "negative_binomial_distribution::negative_binomial_distribution"
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
  - "negative_binomial_distribution::negative_binomial_distribution"
  - "std::tr1::negative_binomial_distribution::negative_binomial_distribution"
  - "std.tr1.negative_binomial_distribution.negative_binomial_distribution"
  - "negative_binomial_distribution.negative_binomial_distribution"
  - "tr1::negative_binomial_distribution::negative_binomial_distribution"
  - "negative_binomial_distribution"
  - "random/std::tr1::negative_binomial_distribution::negative_binomial_distribution"
  - "tr1.negative_binomial_distribution.negative_binomial_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "negative_binomial_distribution method"
ms.assetid: 11fe5b9f-0ef7-435f-8538-e8bb49fa6877
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# negative_binomial_distribution::negative_binomial_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit negative_binomial_distribution(IntType k = 1, double p = 0.5);  
  
explicit negative_binomial_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `k`  
 The `k` distribution parameter.  
  
 `p`  
 The `p` distribution parameter.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `0.0 < k` and `0.0 < p ≤ 1.0`  
  
 The first constructor constructs an object whose stored `p` value holds the value `p` and whose stored `k` value holds the value `k`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [negative_binomial_distribution Class](../vs140/negative_binomial_distribution-class.md)