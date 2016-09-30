---
title: "CWnd::PostMessage"
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
  - "CWnd.PostMessage"
  - "CWnd::PostMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "posting messages"
  - "window message functions"
  - "PostMessage method"
  - "messages, posting"
  - "message functions"
ms.assetid: 3f7f2cd5-07ac-43a1-81cd-5ad39f3c8229
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::PostMessage
Places a message in the window's message queue and then returns without waiting for the corresponding window to process the message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the message to be posted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies additional message information. The content of this parameter depends on the message being posted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies additional message information. The content of this parameter depends on the message being posted.  
  
## Return Value  
 Nonzero if the message is posted; otherwise 0.  
  
## Remarks  
 Messages in a message queue are retrieved by calls to the [GetMessage](http://msdn.microsoft.com/library/windows/desktop/ms644936) or [PeekMessage](http://msdn.microsoft.com/library/windows/desktop/ms644943) Windows function.  
  
 The Windows [PostMessage](http://msdn.microsoft.com/library/windows/desktop/ms644944) function can be used to access another application.  
  
## Example  
 See the example for [AfxGetMainWnd](../vs140/afxgetmainwnd.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetMessage](http://msdn.microsoft.com/library/windows/desktop/ms644936)   
 [PeekMessage](http://msdn.microsoft.com/library/windows/desktop/ms644943)   
 [PostMessage](http://msdn.microsoft.com/library/windows/desktop/ms644944)   
 [PostThreadMessage](http://msdn.microsoft.com/library/windows/desktop/ms644946)   
 [CWnd::SendMessage](../vs140/cwnd--sendmessage.md)