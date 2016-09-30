---
title: "cancel_current_task Function"
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
  - "ppltasks/concurrency::cancel_current_task"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cancel_current_task function"
ms.assetid: 03a5e7bb-20bc-49b7-b119-83421845769b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cancel_current_task Function
Cancels the currently executing task. This function can be called from within the body of a task to abort the task's execution and cause it to enter the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> state.  
  
 It is not a supported scenario to call this function if you are not within the body of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Doing so will result in undefined behavior such as a crash or a hang in your application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task Class](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f)