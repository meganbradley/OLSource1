---
title: "uniform_int_distribution::param_type"
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
  - "uniform_int_distribution::param_type"
  - "random/std::tr1::uniform_int_distribution::param_type"
  - "std.tr1.uniform_int_distribution.param_type"
  - "uniform_int_distribution.param_type"
  - "std::tr1::uniform_int_distribution::param_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "param_type method"
ms.assetid: aefd44ed-a2bf-45e0-8117-ec7ca9a58188
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# uniform_int_distribution::param_type
Stores the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef uniform_int_distribution<IntType> distribution_type;  
    param_type(IntType a = 0, IntType b = std::numeric_limits<IntType>::max());  
    result_type a() const;  
    result_type b() const;  
    .....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [uniform_int_distribution Class](../vs140/uniform_int_distribution-class.md).  
  
## Remarks  
 **Precondition:** `a ≤ b`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [uniform_int_distribution Class](../vs140/uniform_int_distribution-class.md)