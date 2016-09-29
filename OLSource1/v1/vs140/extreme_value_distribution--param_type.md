---
title: "extreme_value_distribution::param_type"
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
  - "std.tr1.extreme_value_distribution.param_type"
  - "extreme_value_distribution.param_type"
  - "std::tr1::extreme_value_distribution::param_type"
  - "random/std::tr1::extreme_value_distribution::param_type"
  - "extreme_value_distribution::param_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "param_type method"
ms.assetid: 18c7a1ef-fcac-44a8-b11a-a795d9b139a1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extreme_value_distribution::param_type
Stores the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef extreme_value_distribution<RealType> distribution_type;  
    param_type(RealType a = 0.0, RealType b = 1.0);  
    RealType a() const;  
    RealType b() const;  
    .....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [extreme_value_distribution Class](../vs140/extreme_value_distribution-class.md).  
  
## Remarks  
 **Precondition:** `0.0 < b`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [extreme_value_distribution Class](../vs140/extreme_value_distribution-class.md)