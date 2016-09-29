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
  
```  
static size_t __cdecl wait_for_multiple(  
   _In_reads_(_Count) event ** _PPEvents,  
   size_t _Count,  
   bool _FWaitAll,  
   unsigned int _Timeout = COOPERATIVE_TIMEOUT_INFINITE  
);  
```  
  
#### Parameters  
 `_PPEvents`  
 An array of events to wait on. The number of events within the array is indicated by the `_Count` parameter.  
  
 `_Count`  
 The count of events within the array supplied in the `_PPEvents` parameter.  
  
 `_FWaitAll`  
 If set to the value `true`, the parameter specifies that all events within the array supplied in the `_PPEvents` parameter must become signaled in order to satisfy the wait. If set to the value `false`, it specifies that any event within the array supplied in the `_PPEvents` parameter becoming signaled will satisfy the wait.  
  
 `_Timeout`  
 Indicates the number of milliseconds before the wait times out. The value `COOPERATIVE_TIMEOUT_INFINITE` signifies that there is no timeout.  
  
## Return Value  
 If the wait was satisfied, the index within the array supplied in the `_PPEvents` parameter which satisfied the wait condition; otherwise, the value `COOPERATIVE_WAIT_TIMEOUT` to indicate that the wait timed out without the condition being satisfied.  
  
## Remarks  
 If the parameter `_FWaitAll` is set to the value `true` to indicate that all events must become signaled to satisfy the wait, the index returned by the function carries no special significance other than the fact that it is not the value `COOPERATIVE_WAIT_TIMEOUT`.  
  
> [!IMPORTANT]
>  In a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, do not call `wait_for_multiple` on the ASTA thread because this call can block the current thread and can cause the app to become unresponsive.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [event Class](../vs140/event-class.md)   
 [event::wait Method](../vs140/event--wait-method.md)   
 [COOPERATIVE_TIMEOUT_INFINITE](../vs140/cooperative_timeout_infinite-constant.md)   
 [COOPERATIVE_WAIT_TIMEOUT](../vs140/cooperative_wait_timeout-constant.md)