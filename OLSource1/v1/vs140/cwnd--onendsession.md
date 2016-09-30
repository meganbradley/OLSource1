---
title: "CWnd::OnEndSession"
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
  - "OnEndSession"
  - "CWnd::OnEndSession"
  - "CWnd.OnEndSession"
  - "WM_ENDSESSION"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEndSession method"
  - "WM_ENDSESSION"
ms.assetid: e90c94a3-5589-41c7-8f13-464a1351075d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnEndSession
The framework calls this member function after the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object has returned a nonzero value from a [OnQueryEndSession](../vs140/cwnd--onqueryendsession.md) member function call.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether or not the session is being ended. It is **TRUE** if the session is being ended; otherwise **FALSE**.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> call informs the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object whether the session is actually ending.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is **TRUE**, Windows can terminate any time after all applications have returned from processing this call. Consequently, have an application perform all tasks required for termination within <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 You do not need to call the [DestroyWindow](../vs140/cwnd--destroywindow.md) member function or [PostQuitMessage](http://msdn.microsoft.com/library/windows/desktop/ms644945) Windows function when the session is ending.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DestroyWindow](../vs140/cwnd--destroywindow.md)   
 [CWnd::OnQueryEndSession](../vs140/cwnd--onqueryendsession.md)   
 [ExitWindows](http://msdn.microsoft.com/library/windows/desktop/aa376867)   
 [PostQuitMessage](http://msdn.microsoft.com/library/windows/desktop/ms644945)   
 [CWnd::OnQueryEndSession](../vs140/cwnd--onqueryendsession.md)   
 [CWnd::Default](../vs140/cwnd--default.md)   
 [WM_ENDSESSION](http://msdn.microsoft.com/library/windows/desktop/aa376889)