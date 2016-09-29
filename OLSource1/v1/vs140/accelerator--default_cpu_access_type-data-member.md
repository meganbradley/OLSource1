---
title: "accelerator::default_cpu_access_type Data Member"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 02c9d160-610f-4d6b-bd8a-9d94df60897f
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::default_cpu_access_type Data Member
The default cpu [access_type](../vs140/access_type-enumeration.md) for arrays and implicit memory allocations made on this this `accelerator`.  
  
## Syntax  
  
```  
__declspec(property(get=get_default_cpu_access_type)) access_type default_cpu_access_type;  
```  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)