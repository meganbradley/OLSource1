---
title: "event::wait Method"
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
  - "concrt/concurrency::event::wait"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait method"
ms.assetid: ecb63000-4ed0-4e3c-890a-d9662c182ad5
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# event::wait Method
Waits for the event to become signaled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates the number of milliseconds before the wait times out. The value <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> signifies that there is no timeout.  
  
## Return Value  
 If the wait was satisfied, the value <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is returned; otherwise, the value <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to indicate that the wait timed out without the event becoming signaled.  
  
> [!IMPORTANT]
>  In a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, do not call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on the ASTA thread because this call can block the current thread and can cause the app to become unresponsive.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [event Class](../vs140/event-class.md)   
 [event::set Method](../vs140/event--set-method.md)   
 [COOPERATIVE_TIMEOUT_INFINITE](../vs140/cooperative_timeout_infinite-constant.md)   
 [COOPERATIVE_WAIT_TIMEOUT](../vs140/cooperative_wait_timeout-constant.md)