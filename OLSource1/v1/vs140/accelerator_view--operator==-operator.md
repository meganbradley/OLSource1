---
title: "accelerator_view::operator== Operator"
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
  - "amprt/Concurrency::accelerator_view::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=="
ms.assetid: bd8db2fd-1c44-4e9a-ae1b-1995e915b142
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator_view::operator== Operator
Compares this [accelerator_view](../vs140/accelerator_view-class.md) object with another and returns `true` if they are the same; otherwise, returns `false`.  
  
## Syntax  
  
```  
bool operator==(  
   const accelerator_view &_Other                       
) const;  
```  
  
#### Parameters  
 `_Other`  
 The `accelerator_view` object to compare with this one.  
  
## Return Value  
 `true` if the two objects are the same; otherwise, `false`.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator_view Class](../vs140/accelerator_view-class.md)