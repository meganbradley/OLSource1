---
title: "geometric_distribution::geometric_distribution"
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
  - "tr1.geometric_distribution.geometric_distribution"
  - "std::tr1::geometric_distribution::geometric_distribution"
  - "tr1::geometric_distribution::geometric_distribution"
  - "geometric_distribution.geometric_distribution"
  - "random/std::tr1::geometric_distribution::geometric_distribution"
  - "std.tr1.geometric_distribution.geometric_distribution"
  - "geometric_distribution"
  - "geometric_distribution::geometric_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "geometric_distribution method"
  - "geometric_distribution constructor [TR1]"
ms.assetid: 05fbd8f2-c92a-4596-95fa-11422cfd0f28
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# geometric_distribution::geometric_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit geometric_distribution(RealType p = 0.5);  
  
explicit geometric_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `p`  
 The `p` distribution parameter.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `0.0 < p && p < 1.0`  
  
 The first constructor constructs an object whose stored `p` value holds the value `p`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [geometric_distribution](../vs140/geometric_distribution-class.md)