---
title: "cauchy_distribution::cauchy_distribution"
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
  - "cauchy_distribution"
  - "tr1.cauchy_distribution.cauchy_distribution"
  - "cauchy_distribution.cauchy_distribution"
  - "random/std::tr1::cauchy_distribution::cauchy_distribution"
  - "std::tr1::cauchy_distribution::cauchy_distribution"
  - "cauchy_distribution::cauchy_distribution"
  - "tr1::cauchy_distribution::cauchy_distribution"
  - "std.tr1.cauchy_distribution.cauchy_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cauchy_distribution method"
ms.assetid: 8f9f6dba-7cfd-48e6-92f2-fd15d82ab83b
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cauchy_distribution::cauchy_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit cauchy_distribution(RealType a = 0.0, RealType b = 1.0);  
  
explicit cauchy_distribution(const param_type& parm);  
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
 [cauchy_distribution Class](../vs140/cauchy_distribution-class.md)