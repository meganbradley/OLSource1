---
title: "bernoulli_distribution::bernoulli_distribution"
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
  - "bernoulli_distribution.bernoulli_distribution"
  - "std.tr1.bernoulli_distribution.bernoulli_distribution"
  - "bernoulli_distribution::bernoulli_distribution"
  - "bernoulli_distribution"
  - "std::tr1::bernoulli_distribution::bernoulli_distribution"
  - "tr1::bernoulli_distribution::bernoulli_distribution"
  - "tr1.bernoulli_distribution.bernoulli_distribution"
  - "random/std::tr1::bernoulli_distribution::bernoulli_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bernoulli_distribution constructor [TR1]"
  - "bernoulli_distribution method"
ms.assetid: 004524dc-fc9e-426f-b9e1-34525aa80c78
caps.latest.revision: 27
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bernoulli_distribution::bernoulli_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit bernoulli_distribution(double p = 0.5);  
  
explicit bernoulli_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `p`  
 The stored `p` distribution parameter.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `0.0 ≤ p ≤ 1.0`  
  
 The first constructor constructs an object whose stored `p` value holds the value `p`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
 For more information and a code example, see [bernoulli_distribution Class](../vs140/binomial_distribution-class.md).  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [bernoulli_distribution Class](../vs140/bernoulli_distribution-class.md)