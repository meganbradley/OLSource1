---
title: "random_device::entropy"
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
  - "std.tr1.random_device.entropy"
  - "tr1::random_device::entropy"
  - "random/std::tr1::random_device::entropy"
  - "entropy"
  - "tr1.random_device.entropy"
  - "std::tr1::random_device::entropy"
  - "random_device::entropy"
  - "random_device.entropy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "entropy method [TR1]"
  - "entropy method"
ms.assetid: 9a177aa9-bd70-42df-8034-3fc1d100c4af
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# random_device::entropy
Estimates the randomness of the source.  
  
## Syntax  
  
```  
double entropy() const noexcept;  
```  
  
## Remarks  
 The member function returns an estimate of the randomness of the source, as measured in bits.  
  
 For example code, see [random_device](../vs140/random_device-class.md).  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [random_device](../vs140/random_device-class.md)