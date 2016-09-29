---
title: "accelerator::operator!= Operator"
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
  - "amprt/Concurrency::accelerator::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!="
ms.assetid: fafee516-c2f1-402e-ab11-1fee2e2144cf
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::operator!= Operator
Compares this `accelerator` object with another and returns `false` if they are the same; otherwise, returns `true`.  
  
## Syntax  
  
```  
bool operator!=(  
   const accelerator &_Other                       
) const;  
```  
  
#### Parameters  
 `_Other`  
 The `accelerator` object to compare with this one.  
  
## Return Value  
 `false` if the two `accelerator` objects are the same; otherwise, `true`.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)