---
title: "fisher_f_distribution::fisher_f_distribution"
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
  - fisher_f_distribution::fisher_f_distribution
  - tr1::fisher_f_distribution::fisher_f_distribution
  - std::tr1::fisher_f_distribution::fisher_f_distribution
  - std.tr1.fisher_f_distribution.fisher_f_distribution
  - tr1.fisher_f_distribution.fisher_f_distribution
  - fisher_f_distribution
  - fisher_f_distribution.fisher_f_distribution
  - random/std::tr1::fisher_f_distribution::fisher_f_distribution
dev_langs: 
  - C++
helpviewer_keywords: 
  - fisher_f_distribution method
ms.assetid: ffd70e4e-34e4-4628-9f3c-bf33735a426c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# fisher_f_distribution::fisher_f_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
explicit fisher_f_distribution(RealType m = 1.0, RealType n = 1.0);  
  
explicit fisher_f_distribution(const param_type& parm);  
```  
  
#### Parameters  
 `m`  
 The `m` distribution parameter.  
  
 `n`  
 The `n` distribution parameter.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 **Precondition:** `0.0 < m` and `0.0 < n`  
  
 The first constructor constructs an object whose stored `m` value holds the value `m` and whose stored `n` value holds the value `n`.  
  
 The second constructor constructs an object whose stored parameters are initialized from `parm`. You can obtain and set the current parameters of an existing distribution by calling the `param()` member function.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [fisher_f_distribution Class](../vs140/fisher_f_distribution-class.md)