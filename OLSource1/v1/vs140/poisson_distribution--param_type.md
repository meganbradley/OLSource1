---
title: "poisson_distribution::param_type"
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
  - std::tr1::poisson_distribution::param_type
  - random/std::tr1::poisson_distribution::param_type
  - std.tr1.poisson_distribution.param_type
  - poisson_distribution::param_type
  - poisson_distribution.param_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - param_type method
ms.assetid: a15d463e-b688-4bd1-b521-22d0b5f1603d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# poisson_distribution::param_type
Stores the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef poisson_distribution<IntType> distribution_type;  
    param_type(double mean = 1.0);  
    RealType mean() const;  
    ....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [poisson_distribution Class](../vs140/poisson_distribution-class.md).  
  
## Remarks  
 **Precondition:** `0.0 < mean`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [poisson_distribution Class](../vs140/poisson_distribution-class.md)