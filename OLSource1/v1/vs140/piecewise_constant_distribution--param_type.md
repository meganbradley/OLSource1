---
title: "piecewise_constant_distribution::param_type"
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
  - "random/std::tr1::piecewise_constant_distribution::param_type"
  - "std.tr1.piecewise_constant_distribution.param_type"
  - "piecewise_constant_distribution.param_type"
  - "std::tr1::piecewise_constant_distribution::param_type"
  - "piecewise_constant_distribution::param_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "param_type method"
ms.assetid: 5b1f5411-4661-4c41-8893-7e8c926df17d
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# piecewise_constant_distribution::param_type
Stores all the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef piecewise_constant_distribution<RealType> distribution_type;  
    param_type();  
    template<class IterI, class IterW>  
    param_type(IterI firstI, IterI lastI, IterW firstW);  
    template<class UnaryOperation>  
    param_type(size_t count, RealType xmin, RealType xmax,   
        UnaryOperation weightfunc);  
    std::vector<RealType> densities() const;  
    std::vector<RealType> intervals() const;  
    .....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [piecewise_constant_distribution Class](../vs140/piecewise_constant_distribution-class.md).  
  
## Remarks  
 **Precondition:** `xmin < xmax`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [piecewise_constant_distribution Class](../vs140/piecewise_constant_distribution-class.md)