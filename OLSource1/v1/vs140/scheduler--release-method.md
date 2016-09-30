---
title: "Scheduler::Release Method"
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
  - "concrt/concurrency::Scheduler::Release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Release method"
ms.assetid: 2fc72a34-2715-4452-a2a6-b98fe1e80352
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::Release Method
Decrements the scheduler reference count.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The newly decremented reference count.  
  
## Remarks  
 This is typically used to manage the lifetime of the scheduler for composition. When the reference count of a scheduler falls to zero, the scheduler will shut down and destruct itself after all work on the scheduler has completed.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)   
 [Scheduler::Reference Method](../vs140/scheduler--reference-method.md)   
 [Scheduler::Create Method](../vs140/scheduler--create-method.md)