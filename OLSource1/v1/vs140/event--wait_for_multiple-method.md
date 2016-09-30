---
title: "event::wait_for_multiple Method"
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
  - "concrt/concurrency::event::wait_for_multiple"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait_for_multiple method"
ms.assetid: 61f627f6-b2a3-4884-a75d-07cc970156d8
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# event::wait_for_multiple Method
Waits for multiple events to become signaled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An array of events to wait on. The number of events within the array is indicated by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The count of events within the array supplied in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If set to the value <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the parameter specifies that all events within the array supplied in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter must become signaled in order to satisfy the wait. If set to the value <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, it specifies that any event within the array supplied in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter becoming signaled will satisfy the wait.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Indicates the number of milliseconds before the wait times out. The value <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> signifies that there is no timeout.  
  
## Return Value  
 If the wait was satisfied, the index within the array supplied in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter which satisfied the wait condition; otherwise, the value <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to indicate that the wait timed out without the condition being satisfied.  
  
## Remarks  
 If the parameter <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is set to the value <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to indicate that all events must become signaled to satisfy the wait, the index returned by the function carries no special significance other than the fact that it is not the value <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
> [!IMPORTANT]
>  In a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, do not call <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> on the ASTA thread because this call can block the current thread and can cause the app to become unresponsive.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [event Class](../vs140/event-class.md)   
 [event::wait Method](../vs140/event--wait-method.md)   
 [COOPERATIVE_TIMEOUT_INFINITE](../vs140/cooperative_timeout_infinite-constant.md)   
 [COOPERATIVE_WAIT_TIMEOUT](../vs140/cooperative_wait_timeout-constant.md)