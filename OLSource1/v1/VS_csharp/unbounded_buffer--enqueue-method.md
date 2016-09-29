---
title: "unbounded_buffer::enqueue Method"
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
  - "agents/concurrency::unbounded_buffer::enqueue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "enqueue method"
ms.assetid: 14f43212-ca8d-4b13-a9d1-f46134ae26fd
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unbounded_buffer::enqueue Method
Adds an item to the `unbounded_buffer` messaging block.  
  
## Syntax  
  
```  
bool enqueue(  
   _Type const& _Item  
);  
```  
  
#### Parameters  
 `_Item`  
 The item to add.  
  
## Return Value  
 `true` if the item was accepted, `false` otherwise.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [unbounded_buffer Class](../VS_csharp/unbounded_buffer-class.md)