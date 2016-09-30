---
title: "CWnd::OnTimer"
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
  - "CWnd::OnTimer"
  - "WM_TIMER"
  - "CWnd.OnTimer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_TIMER"
  - "OnTimer method"
ms.assetid: eaeaa6af-fcf0-4185-b7d6-67fd16c500b7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnTimer
The framework calls this member function after each interval specified in the [SetTimer](../vs140/cwnd--settimer.md) member function used to install a timer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the identifier of the timer.  
  
## Remarks  
 The [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows function sends a [WM_TIMER](http://msdn.microsoft.com/library/windows/desktop/ms644902) message when no other messages are in the application's message queue.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Example  
 See the example in [CWnd::SetTimer](../vs140/cwnd--settimer.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetTimer](../vs140/cwnd--settimer.md)   
 [WM_TIMER](http://msdn.microsoft.com/library/windows/desktop/ms644902)