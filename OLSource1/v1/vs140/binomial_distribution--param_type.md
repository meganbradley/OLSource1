---
title: "binomial_distribution::param_type"
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
  - "binomial_distribution::param_type"
  - "std.tr1.binomial_distribution.param_type"
  - "random/std::tr1::binomial_distribution::param_type"
  - "binomial_distribution.param_type"
  - "std::tr1::binomial_distribution::param_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "param_type method"
ms.assetid: ffa66b86-0bdc-45ea-9f2b-4d4d7ae35755
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binomial_distribution::param_type
Stores all the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef binomial_distribution<IntType> distribution_type;  
    param_type(IntType t = 1, double p = 0.5);  
    IntType t() const;  
    double p() const;  
    .....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [binomial_distribution Class](../vs140/binomial_distribution-class.md).  
  
## Remarks  
 **Precondition:** `0 ≤ t` and `0.0 ≤ p ≤ 1.0`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [binomial_distribution Class](../vs140/binomial_distribution-class.md)