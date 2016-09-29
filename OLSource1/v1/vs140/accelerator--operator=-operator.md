---
title: "accelerator::operator= Operator"
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
  - "amprt/Concurrency::accelerator::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: 66e2f395-9000-4e4c-be53-ccf1188753ed
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::operator= Operator
Copies the contents of the specified [accelerator](../vs140/accelerator-class.md) object to this one.  
  
## Syntax  
  
```  
accelerator &operator=(  
   const accelerator &_Other                       
);  
```  
  
#### Parameters  
 `_Other`  
 The `accelerator` object to copy from.  
  
## Return Value  
 A reference to this `accelerator` object.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)