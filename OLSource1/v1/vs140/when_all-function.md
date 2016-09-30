---
title: "when_all Function"
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
  - "ppltasks/concurrency::when_all"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "when_all function"
ms.assetid: 1c80cc05-8211-43d4-a8d7-1b3415899823
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# when_all Function
Creates a task that will complete successfully when all of the tasks supplied as arguments complete successfully.  
  
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
  
## Return Value  
 A task that completes sucessfully when all of the input tasks have completed successfully. If the input tasks are of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the output of this function will be a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If the input tasks are of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> the output task will also be a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a non-blocking function that produces a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as its result. Unlike [task::wait](../vs140/task--wait-method.md), it is safe to call this function in a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app on the ASTA (Application STA) thread.  
  
 If one of the tasks is canceled or throws an exception, the returned task will complete early, in the canceled state, and the exception, if one is encoutered, will be thrown if you call [task::get](../vs140/task--get-method.md) or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> on that task.  
  
 For more information, see [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md)