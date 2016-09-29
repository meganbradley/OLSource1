---
title: "invalid_compute_domain::invalid_compute_domain Constructor"
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
  - "amprt/Concurrency::invalid_compute_domain::invalid_compute_domain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "invalid_compute_domain, constructor"
ms.assetid: d304a551-19da-4191-90fe-1cbaf4a737f7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# invalid_compute_domain::invalid_compute_domain Constructor
Initializes a new instance of the [invalid_compute_domain](../vs140/invalid_compute_domain-class.md) class.  
  
## Syntax  
  
```  
explicit invalid_compute_domain(  
   const char * _Message  
) throw();  
  
invalid_compute_domain() throw();  
```  
  
#### Parameters  
 `_Message`  
 A description of the error.  
  
## Return Value  
 An instance of the `invalid_compute_domain` class  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [invalid_compute_domain Class](../vs140/invalid_compute_domain-class.md)