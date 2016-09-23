---
title: "poisson_distribution::poisson_distribution"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - poisson_distribution
  - poisson_distribution.poisson_distribution
  - tr1::poisson_distribution::poisson_distribution
  - std::tr1::poisson_distribution::poisson_distribution
  - random/std::tr1::poisson_distribution::poisson_distribution
  - tr1.poisson_distribution.poisson_distribution
  - std.tr1.poisson_distribution.poisson_distribution
  - poisson_distribution::poisson_distribution
dev_langs: 
  - C++
helpviewer_keywords: 
  - poisson_distribution constructor [TR1]
  - poisson_distribution method
ms.assetid: e3bb7372-aebb-4624-842c-489ab663f7dc
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# poisson_distribution::poisson_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit poisson_distribution(RealType mean = 1.0);  
  
explicit binomial_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `mean`  
 The `mean` distribution parameter.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `0.0 < mean`  
  
 The first constructor constructs an object whose stored `p` value holds the value `p`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [poisson_distribution](../vs140/poisson_distribution-class.md)