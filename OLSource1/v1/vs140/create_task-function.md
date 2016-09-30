---
title: "create_task Function"
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
  - "ppltasks/concurrency::create_task"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "create_task function"
ms.assetid: 6e364052-c923-4006-9e03-8516bf041482
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# create_task Function
Creates a PPL [task](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f) object. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> can be used anywhere you would have used a task constructor. It is provided mainly for convenience, because it allows use of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword while creating tasks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the parameter from which the task is to be constructed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The parameter from which the task is to be constructed. This could be a lambda or function object, a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object, a different <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object, or a Windows::Foundation::IAsyncInfo interface if you are using tasks in your Windows Store app.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
## Return Value  
 A new task of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, that is inferred from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first overload behaves like a task constructor that takes a single parameter.  
  
 The second overload associates the cancellation token provided with the newly created task. If you use this overload you are not allowed to pass in a different <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object as the first parameter.  
  
 The type of the returned task is inferred from the first parameter to the function. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or a functor that returns either type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the type of the created task is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 In a Windows Store app, if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is of type Windows::Foundation::IAsyncOperation\<T>^ or Windows::Foundation::IAsyncOperationWithProgress\<T,P>^, or a functor that returns either of those types, the created task will be of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is of type Windows::Foundation::IAsyncAction^ or Windows::Foundation::IAsyncActionWithProgress\<P>^, or a functor that returns either of those types, the created task will have type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task Class](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f)   
 [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md)