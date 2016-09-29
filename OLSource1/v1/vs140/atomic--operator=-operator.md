---
title: "atomic::operator= Operator"
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
  - "atomic/std::atomic::operator="
dev_langs: 
  - "C++"
ms.assetid: fe161d57-47ae-4bad-92bf-ce32ac8d5953
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::operator= Operator
Stores a specified value.  
  
## Syntax  
  
```  
Ty operator=(  
   Ty Val  
) volatile _NOEXCEPT;  
Ty operator=(  
   Ty Val  
) _NOEXCEPT;  
  
```  
  
#### Parameters  
 `Val`  
 A `Ty` object.  
  
## Return Value  
 Returns `Val`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [atomic Structure](../vs140/atomic-structure.md)   
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic::store](../vs140/atomic--store-method.md)