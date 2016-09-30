---
title: "CWnd::OnPaint"
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
  - "CWnd.OnPaint"
  - "CWnd::OnPaint"
  - "WM_PAINT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPaint method"
  - "WM_PAINT"
ms.assetid: eb3b1ad8-2183-42ca-a0e6-64d8667a88c8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnPaint
The framework calls this member function when Windows or an application makes a request to repaint a portion of an application's window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145137) message is sent when the [UpdateWindow](../vs140/cwnd--updatewindow.md) or [RedrawWindow](../vs140/cwnd--redrawwindow.md) member function is called.  
  
 A window may receive internal paint messages as a result of calling the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function with the **RDW_INTERNALPAINT** flag set. In this case, the window may not have an update region. An application should call the [GetUpdateRect](../vs140/cwnd--getupdaterect.md) member function to determine whether the window has an update region. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns 0, the application should not call the [BeginPaint](../vs140/cwnd--beginpaint.md) and [EndPaint](../vs140/cwnd--endpaint.md) member functions.  
  
 It is an application's responsibility to check for any necessary internal repainting or updating by looking at its internal data structures for each <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> message because a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message may have been caused by both an invalid area and a call to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function with the **RDW_INTERNALPAINT** flag set.  
  
 An internal <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> message is sent only once by Windows. After an internal <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> message is sent to a window by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member function, no further <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> messages will be sent or posted until the window is invalidated or until the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member function is called again with the **RDW_INTERNALPAINT** flag set.  
  
 For information on rendering an image in document/view applications, see [CView::OnDraw](../vs140/cview--ondraw.md).  
  
 For more information about using **WM_Paint**, see the following topics in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]:  
  
-   [The WM_PAINT Message](http://msdn.microsoft.com/library/windows/desktop/dd145137)  
  
-   [Using the WM_PAINT Message](http://msdn.microsoft.com/library/windows/desktop/dd145193)  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::BeginPaint](../vs140/cwnd--beginpaint.md)   
 [CWnd::EndPaint](../vs140/cwnd--endpaint.md)   
 [CWnd::RedrawWindow](../vs140/cwnd--redrawwindow.md)   
 [CPaintDC Class](../vs140/cpaintdc-class.md)   
 [CView::OnDraw](../vs140/cview--ondraw.md)