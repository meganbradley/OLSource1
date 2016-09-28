---
title: "COleMessageFilter::EndBusyState"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "EndBusyState"
  - "COleMessageFilter::EndBusyState"
  - "COleMessageFilter.EndBusyState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EndBusyState method"
  - "COleMessageFilter class, operations"
ms.assetid: 6a8ac04e-008c-4702-bb6f-cfbfa3b91a2e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleMessageFilter::EndBusyState
Call this function to end a busy state.  
  
## Syntax  
  
```  
  
virtual void EndBusyState( );  
```  
  
## Remarks  
 It works in conjunction with [BeginBusyState](../vs140/colemessagefilter--beginbusystate.md) to control the application's busy state. The function [SetBusyReply](../vs140/colemessagefilter--setbusyreply.md) determines the application's reply to calling applications when it is busy.  
  
 The `BeginBusyState` and `EndBusyState` calls increment and decrement, respectively, a counter that determines whether the application is busy. For example, two calls to `BeginBusyState` and one call to `EndBusyState` still result in a busy state. To cancel a busy state it is necessary to call `EndBusyState` the same number of times `BeginBusyState` has been called.  
  
 By default, the framework enters the busy state during idle processing, which is performed by [CWinApp::OnIdle](../vs140/cwinapp--onidle.md). While the application is handling `ON_UPDATE_COMMAND_UI` notifications, incoming calls are handled after idle processing is complete.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleMessageFilter Class](../vs140/colemessagefilter-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleMessageFilter::BeginBusyState](../vs140/colemessagefilter--beginbusystate.md)   
 [COleMessageFilter::SetBusyReply](../vs140/colemessagefilter--setbusyreply.md)   
 [CWinApp::OnIdle](../vs140/cwinapp--onidle.md)