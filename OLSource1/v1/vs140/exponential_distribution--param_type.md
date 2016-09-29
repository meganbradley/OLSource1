---
title: "exponential_distribution::param_type"
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
  - "exponential_distribution::param_type"
  - "exponential_distribution.param_type"
  - "std::tr1::exponential_distribution::param_type"
  - "random/std::tr1::exponential_distribution::param_type"
  - "std.tr1.exponential_distribution.param_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "param_type method"
ms.assetid: c23503cd-cd4a-4389-a5ba-e9f0b59724c9
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# exponential_distribution::param_type
Stores the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef exponential_distribution<RealType> distribution_type;  
    param_type(RealType lambda = 1.0);  
    RealType lambda() const;  
    .....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [exponential_distribution Class](../vs140/exponential_distribution-class.md).  
  
## Remarks  
 **Precondition:** `0.0 < lambda`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [exponential_distribution Class](../vs140/exponential_distribution-class.md)