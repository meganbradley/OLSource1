---
title: "lognormal_distribution::param_type"
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
  - lognormal_distribution::param_type
  - lognormal_distribution.param_type
  - random/std::tr1::lognormal_distribution::param_type
  - std::tr1::lognormal_distribution::param_type
  - std.tr1.lognormal_distribution.param_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - param_type method
ms.assetid: 438a0832-908f-4416-b06b-f0708d8b26bb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# lognormal_distribution::param_type
Stores the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef lognormal_distribution<RealType> distribution_type;  
    param_type(RealType m = 0.0, RealType s = 1.0);  
    RealType m() const;  
    RealType s() const;  
    .....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [lognormal_distribution Class](../vs140/lognormal_distribution-class.md).  
  
## Remarks  
 **Precondition:** `0.0 < s`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [lognormal_distribution Class](../vs140/lognormal_distribution-class.md)