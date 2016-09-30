---
title: "condition_variable_any::wait_for Method"
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
  - "condition_variable/std::condition_variable_any::wait_for"
dev_langs: 
  - "C++"
ms.assetid: d22dee7d-7e96-4935-ae26-b044472af36f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable_any::wait_for Method
Blocks a thread, and sets a time interval after which the thread unblocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object of any type.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that specifies the amount of time before the thread wakes up.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Any expression that returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Return Value  
 The first method returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the wait terminates when <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> has elapsed. Otherwise, the method returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 The second method returns the value of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first method blocks until the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object is signaled by a call to [notify_one](../vs140/condition_variable--notify_one-method.md) or [notify_all](../vs140/condition_variable--notify_all-method.md), or until the time interval <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> has elapsed. It can also wake up spuriously.  
  
 The second method in effect executes the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
## See Also  
 [condition_variable_any Class](../vs140/condition_variable_any-class.md)   
 [\<condition_variable>](../vs140/-condition_variable-.md)