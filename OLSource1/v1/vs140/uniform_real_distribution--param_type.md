---
title: "uniform_real_distribution::param_type"
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
  - "uniform_real_distribution::param_type"
  - "std.tr1.uniform_real_distribution.param_type"
  - "random/std::tr1::uniform_real_distribution::param_type"
  - "uniform_real_distribution.param_type"
  - "std::tr1::uniform_real_distribution::param_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "param_type method"
ms.assetid: 9926648b-7195-4c78-a65f-d400eedcb86a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uniform_real_distribution::param_type
Stores all the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef uniform_real_distribution<RealType> distribution_type;  
    param_type(RealType a = 0.0, RealType b = 1.0);  
    RealType a() const;  
    RealType b() const;  
    .....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [uniform_real_distribution Class](../vs140/uniform_real_distribution-class.md).  
  
## Remarks  
 **Precondition:** `a < b`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [uniform_real_distribution Class](../vs140/uniform_real_distribution-class.md)