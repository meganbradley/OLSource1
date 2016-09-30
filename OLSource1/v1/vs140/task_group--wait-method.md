---
title: "task_group::wait Method"
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
  - "ppl/concurrency::task_group::wait"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait method"
ms.assetid: 19ee5bbc-8654-40a7-9f22-d5329cec6e96
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_group::wait Method
Waits until all work on the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object has either completed or been canceled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An indication of whether the wait was satisfied or the task group was canceled, due to either an explicit cancel operation or an exception being thrown from one of its tasks. For more information, see [task_group_status](../vs140/task_group_status-enumeration.md).  
  
## Remarks  
 Note that one or more of the tasks scheduled to this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object may execute inline on the calling context.  
  
 If one or more of the tasks scheduled to this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method.  
  
 Calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object resets it to a clean state where it can be reused. This includes the case where the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object was canceled.  
  
 In the non-exceptional path of execution, you have a mandate to call either this method or the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method before the destructor of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> executes.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_group Class](../vs140/task_group-class.md)