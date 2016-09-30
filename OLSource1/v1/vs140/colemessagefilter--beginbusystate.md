---
title: "COleMessageFilter::BeginBusyState"
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
  - "COleMessageFilter::BeginBusyState"
  - "BeginBusyState"
  - "COleMessageFilter.BeginBusyState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BeginBusyState method"
  - "COleMessageFilter class, operations"
ms.assetid: 7d46af56-4911-440b-8282-e3016436d108
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleMessageFilter::BeginBusyState
Call this function to begin a busy state.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 It works in conjunction with [EndBusyState](../vs140/colemessagefilter--endbusystate.md) to control the application's busy state. The function [SetBusyReply](../vs140/colemessagefilter--setbusyreply.md) determines the application's reply to calling applications when it is busy.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> calls increment and decrement, respectively, a counter that determines whether the application is busy. For example, two calls to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and one call to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> still result in a busy state. To cancel a busy state it is necessary to call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> the same number of times <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> has been called.  
  
 By default, the framework enters the busy state during idle processing, which is performed by [CWinApp::OnIdle](../vs140/cwinapp--onidle.md). While the application is handling **ON_COMMANDUPDATEUI** notifications, incoming calls are handled later, after idle processing is complete.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleMessageFilter Class](../vs140/colemessagefilter-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleMessageFilter::EndBusyState](../vs140/colemessagefilter--endbusystate.md)   
 [COleMessageFilter::SetBusyReply](../vs140/colemessagefilter--setbusyreply.md)   
 [CWinApp::OnIdle](../vs140/cwinapp--onidle.md)