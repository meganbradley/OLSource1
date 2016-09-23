---
title: "task::operator= Operator"
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
  - ppltasks/concurrency::task::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator= operator
ms.assetid: 0894a90a-9385-4bfd-86a6-7e09ed322ca0
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# task::operator= Operator
Replaces the contents of one `task` object with another.  
  
## Syntax  
  
```  
task& operator=(  
   const task& _Other  
);  
  
task& operator=(  
   task&& _Other  
);  
```  
  
#### Parameters  
 `_Other`  
 The source `task` object.  
  
## Return Value  
  
## Remarks  
 As `task` behaves like a smart pointer, after a copy assignment, this `task` objects represents the same actual task as `_Other` does.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task Class (Concurrency Runtime)](../vs140/task-class--concurrency-runtime-.md)