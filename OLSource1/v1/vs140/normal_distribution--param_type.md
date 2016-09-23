---
title: "normal_distribution::param_type"
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
  - normal_distribution::param_type
  - std::tr1::normal_distribution::param_type
  - random/std::tr1::normal_distribution::param_type
  - std.tr1.normal_distribution.param_type
  - normal_distribution.param_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - param_type method
ms.assetid: ab041da3-2618-4363-8e5b-0dd35ad166da
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# normal_distribution::param_type
Stores the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef normal_distribution<RealType> distribution_type;  
    param_type(RealType mean = 0.0, RealType stddev = 1.0);  
    RealType mean() const;  
    RealType stddev() const;  
    .....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [normal_distribution Class](../vs140/normal_distribution-class.md).  
  
## Remarks  
 **Precondition:** `0.0 ≤ stddev`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [normal_distribution Class](../vs140/normal_distribution-class.md)