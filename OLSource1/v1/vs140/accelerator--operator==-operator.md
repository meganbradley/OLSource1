---
title: "accelerator::operator== Operator"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - amprt/Concurrency::accelerator::operator==
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator==
ms.assetid: eba3c68a-1bbf-4617-9440-7baf9be66273
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# accelerator::operator== Operator
Compares this [accelerator](../vs140/accelerator-class.md) object with another and returns `true` if they are the same; otherwise, returns `false`.  
  
## Syntax  
  
```  
bool operator==(  
   const accelerator &_Other                       
) const;  
```  
  
#### Parameters  
 `_Other`  
 The `accelerator` object to compare with this one.  
  
## Return Value  
 `true` if the other `accelerator` object is same as this `accelerator` object; otherwise, `false`.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)