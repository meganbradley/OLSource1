---
title: "condition_variable::wait_for Method"
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
  - "condition_variable/std::condition_variable::wait_for"
dev_langs: 
  - "C++"
ms.assetid: 6952f1c6-cb33-41ac-8269-f6db38e51d1f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable::wait_for Method
Blocks a thread, and sets a time interval after which the thread unblocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A [unique_lock\<mutex>](unique_lock<mutex>) object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that specifies the amount of time before the thread wakes up.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Any expression that returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 The first method returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the wait terminates when <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has elapsed. Otherwise, the method returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The second method returns the value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first method blocks until the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object is signaled by a call to [notify_one](../vs140/condition_variable--notify_one-method.md) or [notify_all](../vs140/condition_variable--notify_all-method.md) or until the time interval <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has elapsed. It can also wake up spuriously.  
  
 In effect, the second method executes the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
## See Also  
 [condition_variable Class](../vs140/condition_variable-class.md)   
 [\<condition_variable>](../vs140/-condition_variable-.md)