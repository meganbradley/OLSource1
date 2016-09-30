---
title: "when_any Function"
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
  - "ppltasks/concurrency::when_any"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "when_any function"
ms.assetid: 26b09c07-4c23-41a5-a1de-d71c91dc9ca2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# when_any Function
Creates a task that will complete successfully when any of the tasks supplied as arguments completes successfully.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be combined into the resulting task.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be combined into the resulting task.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The cancellation token which controls cancellation of the returned task. If you do not provide a cancellation token, the resulting task will receive the cancellation token of the task that causes it to complete.  
  
## Return Value  
 A task that completes successfully when any one of the input tasks has completed successfully. If the input tasks are of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the output of this function will be a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, where the first element of the pair is the result of the completing task, and the second element is the index of the task that finished. If the input tasks are of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> the output is a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, where the result is the index of the completing task.  
  
## Remarks  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a non-blocking function that produces a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as its result. Unlike [task::wait](../vs140/task--wait-method.md), it is safe to call this function in a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app on the ASTA (Application STA) thread.  
  
 For more information, see [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md)