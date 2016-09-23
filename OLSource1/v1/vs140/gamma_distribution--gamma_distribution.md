---
title: "gamma_distribution::gamma_distribution"
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
  - gamma_distribution::gamma_distribution
  - tr1.gamma_distribution.gamma_distribution
  - tr1::gamma_distribution::gamma_distribution
  - gamma_distribution
  - random/std::tr1::gamma_distribution::gamma_distribution
  - std.tr1.gamma_distribution.gamma_distribution
  - gamma_distribution.gamma_distribution
  - std::tr1::gamma_distribution::gamma_distribution
dev_langs: 
  - C++
helpviewer_keywords: 
  - gamma_distribution method
  - gamma_distribution constructor [TR1]
ms.assetid: d82ebecf-6f87-4d05-a730-e07312066e0b
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# gamma_distribution::gamma_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit gamma_distribution(RealType alpha = 1.0, RealType beta = 1.0);  
  
explicit gamma_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `alpha`  
 The `alpha` distribution parameter.  
  
 `beta`  
 The `beta` distribution parameter.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `0.0 < alpha` and `0.0 < beta`  
  
 The first constructor constructs an object whose stored `alpha` value holds the value `alpha` and whose stored `beta` value holds the value `beta`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [gamma_distribution Class](../vs140/gamma_distribution-class.md)