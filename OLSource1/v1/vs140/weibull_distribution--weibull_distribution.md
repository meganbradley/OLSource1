---
title: "weibull_distribution::weibull_distribution"
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
  - "weibull_distribution"
  - "std.tr1.weibull_distribution.weibull_distribution"
  - "tr1.weibull_distribution.weibull_distribution"
  - "tr1::weibull_distribution::weibull_distribution"
  - "std::tr1::weibull_distribution::weibull_distribution"
  - "weibull_distribution::weibull_distribution"
  - "weibull_distribution.weibull_distribution"
  - "random/std::tr1::weibull_distribution::weibull_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "weibull_distribution method"
ms.assetid: 7771ecfb-39d5-41cd-ae68-400c8736edb5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weibull_distribution::weibull_distribution
## Syntax  
  
```  
explicit weibull_distribution(RealType a = 1.0, RealType b = 1.0);  
  
explicit weibull_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `a`  
 The `a` distribution parameter.  
  
 `b`  
 The `b` distribution parameter.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `0.0 < a` and `0.0 < b`  
  
 The first constructor constructs an object whose stored `a`value holds the value `a` and whose stored `b` value holds the value `b`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [weibull_distribution Class](../vs140/weibull_distribution-class.md)