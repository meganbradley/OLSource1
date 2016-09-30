---
title: "condition_variable::condition_variable Constructor"
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
  - "condition_variable/std::condition_variable::condition_variable"
dev_langs: 
  - "C++"
ms.assetid: 9c7d91bf-ca11-4f57-bee0-60135940fd8c
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable::condition_variable Constructor
Constructs a `condition_variable` object.  
  
## Syntax  
  
```  
condition_variable();  
```  
  
## Remarks  
 If not enough memory is available, the constructor throws a [system_error](../vs140/system_error-class.md) object that has a `not_enough_memory` error code. If the object cannot be constructed because some other resource is not available, the constructor throws a `system_error` object that has a `resource_unavailable_try_again` error code.  
  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
## See Also  
 [condition_variable Class](../vs140/condition_variable-class.md)   
 [\<condition_variable>](../vs140/-condition_variable-.md)