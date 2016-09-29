---
title: "Context::operator delete Operator"
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
  - "concrt/Concurrency::Context::operator delete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator delete operator"
ms.assetid: 3d01275c-907b-4503-852a-5df7494150d8
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Context::operator delete Operator
A `Context` object is destroyed internally by the runtime. It can not be explicitly deleted.  
  
## Syntax  
  
```  
void operator delete(  
   void * _PObject  
);  
```  
  
#### Parameters  
 `_PObject`  
 A pointer to the object to be deleted.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Context Class](../VS_csharp/context-class.md)