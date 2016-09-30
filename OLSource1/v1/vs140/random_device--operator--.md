---
title: "random_device::operator()"
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
  - "std.tr1.random_device.operator()"
  - "std::tr1::random_device::operator()"
  - "operator()"
  - "random_device.operator()"
  - "random_device::operator()"
  - "tr1.random_device.operator()"
  - "tr1::random_device::operator()"
  - "random/std::tr1::random_device::operator()"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator() operator [TR1]"
  - "operator()"
ms.assetid: ca5fc937-79b4-489d-a43c-3720fb87c9c7
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# random_device::operator()
Returns a random value.  
  
## Syntax  
  
```  
result_type operator()();  
```  
  
## Remarks  
 Returns values uniformly distributed in the closed interval [`min, max`] as determined by member functions `min()` and `max()`. Throws a value of an implementation-defined type derived from [exception](../vs140/exception-class.md) if a random number could not be obtained.  
  
 For example code, see [random_device](../vs140/random_device-class.md).  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [random_device](../vs140/random_device-class.md)