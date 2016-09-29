---
title: "student_t_distribution::param_type"
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
  - "std.tr1.student_t_distribution.param_type"
  - "std::tr1::student_t_distribution::param_type"
  - "random/std::tr1::student_t_distribution::param_type"
  - "student_t_distribution::param_type"
  - "student_t_distribution.param_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "param_type method"
ms.assetid: 4e88ff07-d031-491b-98f8-d65092afc499
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# student_t_distribution::param_type
Stores all the parameters of the distribution.  
  
## Syntax  
  
```  
struct param_type {  
    typedef student_t_distribution<RealType> distribution_type;  
    param_type(RealType n = 1.0);  
    RealType n() const;  
    .....  
    bool operator==(const param_type& right) const;  
    bool operator!=(const param_type& right) const;  
};  
```  
  
#### Parameters  
 See parent topic [student_t_distribution Class](../vs140/student_t_distribution-class.md).  
  
## Remarks  
 **Precondition:** `0.0 < n`  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the `param()` member function to set the stored parameters of an existing distribution, and to `operator()` to be used in place of the stored parameters.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [student_t_distribution Class](../vs140/student_t_distribution-class.md)