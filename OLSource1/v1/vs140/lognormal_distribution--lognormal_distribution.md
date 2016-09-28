---
title: "lognormal_distribution::lognormal_distribution"
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
  - "tr1.lognormal_distribution.lognormal_distribution"
  - "std::tr1::lognormal_distribution::lognormal_distribution"
  - "tr1::lognormal_distribution::lognormal_distribution"
  - "lognormal_distribution"
  - "random/std::tr1::lognormal_distribution::lognormal_distribution"
  - "std.tr1.lognormal_distribution.lognormal_distribution"
  - "lognormal_distribution.lognormal_distribution"
  - "lognormal_distribution::lognormal_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lognormal_distribution method"
ms.assetid: 7fb3d165-8df5-45c4-90a5-8e2fcfdd98a1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lognormal_distribution::lognormal_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit lognormal_distribution(RealType m = 0.0, RealType s = 1.0);  
  
explicit lognormal_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `m`  
 The `m` distribution parameter.  
  
 `s`  
 The `s` distribution parameter.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `0.0 < s`  
  
 The first constructor constructs an object whose stored `m` value holds the value `m` and whose stored `s` value holds the value `s`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [lognormal_distribution Class](../vs140/lognormal_distribution-class.md)