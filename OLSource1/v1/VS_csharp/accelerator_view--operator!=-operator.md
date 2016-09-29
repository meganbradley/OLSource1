---
title: "accelerator_view::operator!= Operator"
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
  - "amprt/Concurrency::accelerator_view::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!="
ms.assetid: e27cc235-d333-453c-b5d6-2eacb6c9fb9d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator_view::operator!= Operator
Compares this [accelerator_view](../VS_csharp/accelerator_view-class.md) object with another and returns `false` if they are the same; otherwise, returns `true`.  
  
## Syntax  
  
```  
bool operator!=(  
   const accelerator_view &_Other  
  
) const;  
```  
  
#### Parameters  
 `_Other`  
 The `accelerator_view` object to compare with this one.  
  
## Return Value  
 `false` if the two objects are the same; otherwise, `true`.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator_view Class](../VS_csharp/accelerator_view-class.md)