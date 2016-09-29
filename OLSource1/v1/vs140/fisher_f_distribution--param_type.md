---
title: "fisher_f_distribution::param_type"
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
  - "fisher_f_distribution::param_type"
  - "random/std::tr1::fisher_f_distribution::param_type"
  - "std::tr1::fisher_f_distribution::param_type"
  - "std.tr1.fisher_f_distribution.param_type"
  - "fisher_f_distribution.param_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "param_type method"
ms.assetid: 934be723-654a-47ca-a09c-31601b3648e0
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fisher_f_distribution::param_type
Stores the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef fisher_f_distribution<RealType> distribution_type;  
    param_type(RealType m = 1.0, RealType n = 1.0);  
    RealType m() const;  
    RealType n() const;  
    ......  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [extreme_value_distribution Class](../vs140/extreme_value_distribution-class.md).  
  
## Remarks  
 **Precondition:** `0.0 < m` and `0.0 < n`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [extreme_value_distribution Class](../vs140/extreme_value_distribution-class.md)