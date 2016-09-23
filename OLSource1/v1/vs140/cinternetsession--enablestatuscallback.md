---
title: "CInternetSession::EnableStatusCallback"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - EnableStatusCallback
  - CInternetSession.EnableStatusCallback
  - CInternetSession::EnableStatusCallback
dev_langs: 
  - C++
helpviewer_keywords: 
  - Internet status, reporting
  - Internet status, callback
  - CInternetSession class, operations
  - EnableStatusCallback method
  - asynchronous Internet operations
  - Internet status
  - status callback for Internet sessions
ms.assetid: 2952a591-c93e-4051-9d3b-e40d11ad79a3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CInternetSession::EnableStatusCallback
Call this member function to enable status callback.  
  
## Syntax  
  
```  
  
      BOOL EnableStatusCallback(  
   BOOL bEnable = TRUE   
);  
```  
  
#### Parameters  
 `bEnable`  
 Specifies whether callback is enabled or disabled. The default is **TRUE**.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
## Remarks  
 When handling status callback, you can provide status about the progress of the operation (such as resolving name, connecting to server, and so on) in the status bar of the application. Displaying operation status is especially desirable during a long-term operation.  
  
 Because callbacks occur during the request's processing, the application should spend as little time as possible in the callback to prevent degradation of data throughput to the network. For example, putting up a dialog box in a callback may be such a lengthy operation that the server terminates the request.  
  
 The status callback cannot be removed as long as any callbacks are pending.  
  
 To handle any operations asynchronously, you must either create your own thread or use the WinInet functions without MFC.  
  
## Exceptions  
 This method can throw exceptions of type `CInternetException*`.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession::CInternetSession](../vs140/cinternetsession--cinternetsession.md)