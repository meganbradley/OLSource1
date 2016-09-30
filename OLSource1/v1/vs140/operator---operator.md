---
title: "operator&amp;&amp; Operator"
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
  - "ppltasks/concurrency::operator&&"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator&& operator"
ms.assetid: 1334b94a-c4de-4180-bbab-76849ca44309
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&amp;&amp; Operator
Creates a task that will complete succesfully when both of the tasks supplied as arguments complete successfully.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the returned task.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first task to combine into the resulting task.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second task to combine into the resulting task.  
  
## Return Value  
 A task that completes successfully when both of the input tasks have completed successfully. If the input tasks are of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the output of this function will be a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If the input tasks are of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> the output task will also be a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 If one of the tasks is canceled or throws an exception, the returned task will complete early, in the canceled state, and the exception, if one is encoutered, will be thrown if you call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> on that task.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md)