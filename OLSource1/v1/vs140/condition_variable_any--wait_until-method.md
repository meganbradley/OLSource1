---
title: "condition_variable_any::wait_until Method"
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
  - "condition_variable/std::condition_variable_any::wait_until"
dev_langs: 
  - "C++"
ms.assetid: 385b2c6b-5255-45f1-ab0c-43b8dcfcefbd
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable_any::wait_until Method
Blocks a thread, and sets a maximum point in time at which the thread unblocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A mutex object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A [chrono::time_point](../vs140/time_point-class.md) object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Any expression that returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 Methods that return a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the wait terminates when <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> elapses. Otherwise, the methods return <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 Methods that return a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> return the value of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first method blocks until the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object is signaled by a call to [notify_one](../vs140/condition_variable--notify_one-method.md) or [notify_all](../vs140/condition_variable--notify_all-method.md), or until <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. It can also wake up spuriously.  
  
 The second method in effect executes the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The third and fourth methods use a pointer to an object of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to replace the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object specifies the maximum amount of time to wait for a signal.  
  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
## See Also  
 [condition_variable_any Class](../vs140/condition_variable-class.md)   
 [\<condition_variable>](../vs140/-condition_variable-.md)