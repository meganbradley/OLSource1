---
title: "task::is_apartment_aware Method"
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
  - "ppltasks/concurrency::task::is_apartment_aware"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_apartment_aware method"
ms.assetid: 729fa9b7-6af3-45ad-94b6-ab205d9be1d2
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task::is_apartment_aware Method
Determines whether the task unwraps a Windows Runtime `IAsyncInfo` interface or is descended from such a task.  
  
## Syntax  
  
```  
bool is_apartment_aware() const;  
```  
  
## Return Value  
 `true` if the task unwraps an `IAsyncInfo` interface or is descended from such a task, `false` otherwise.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task Class (Concurrency Runtime)](../vs140/task-class--concurrency-runtime-.md)