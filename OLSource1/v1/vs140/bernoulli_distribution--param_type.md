---
title: "bernoulli_distribution::param_type"
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
  - "random/std::tr1::bernoulli_distribution::param_type"
  - "bernoulli_distribution::param_type"
  - "bernoulli_distribution.param_type"
  - "std::tr1::bernoulli_distribution::param_type"
  - "std.tr1.bernoulli_distribution.param_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "param_type method"
ms.assetid: 48df15a9-6a98-44d5-a1d8-3e298967340c
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bernoulli_distribution::param_type
Contains the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef bernoulli_distribution distribution_type;  
    param_type(double p = 0.5);  
    double p() const;  
    .....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [bernoulli_distribution Class](../vs140/bernoulli_distribution-class.md).  
  
## Remarks  
 **Precondition:** `0.0 ≤ p ≤ 1.0`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [bernoulli_distribution Class](../vs140/bernoulli_distribution-class.md)