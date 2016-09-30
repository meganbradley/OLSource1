---
title: "Scheduler::Scheduler Constructor"
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
  - "concrt/concurrency::Scheduler::Scheduler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Scheduler, constructor"
ms.assetid: b7c4e760-02ae-414e-b6db-1e6a6ddb671b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::Scheduler Constructor
An object of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class can only created using factory methods, or implicitly.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The process' default scheduler is created implicitly when you utilize many of the runtime functions which require a scheduler to be attached to the calling context. Methods within the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class and features of the PPL and agents layers typically perform implicit attachment.  
  
 You can also create a scheduler explicitly through either the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method or the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)   
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)   
 [CurrentScheduler::Create Method](../vs140/currentscheduler--create-method.md)   
 [Scheduler::Create Method](../vs140/scheduler--create-method.md)