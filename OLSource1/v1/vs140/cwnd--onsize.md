---
title: "CWnd::OnSize"
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
  - "CWnd::OnSize"
  - "WM_SIZE"
  - "OnSize"
  - "CWnd.OnSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_SIZE"
  - "OnSize method"
ms.assetid: b10298b1-b1fe-4db0-8ac2-ca603aa1e8a4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnSize
The framework calls this member function after the window's size has changed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the type of resizing requested. This parameter can be one of the following values:  
  
-   **SIZE_MAXIMIZED** Window has been maximized.  
  
-   **SIZE_MINIMIZED** Window has been minimized.  
  
-   **SIZE_RESTORED** Window has been resized, but neither **SIZE_MINIMIZED** nor **SIZE_MAXIMIZED** applies.  
  
-   **SIZE_MAXHIDE** Message is sent to all pop-up windows when some other window is maximized.  
  
-   **SIZE_MAXSHOW** Message is sent to all pop-up windows when some other window has been restored to its former size.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the new width of the client area.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the new height of the client area.  
  
## Remarks  
 If the [SetScrollPos](../vs140/cwnd--setscrollpos.md) or [MoveWindow](../vs140/cwnd--movewindow.md) member function is called for a child window from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> should be nonzero to cause the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to be repainted.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Example  
 [!code[NVC_MFCWindowing#109](../vs140/codesnippet/CPP/cwnd--onsize_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::MoveWindow](../vs140/cwnd--movewindow.md)   
 [CWnd::SetScrollPos](../vs140/cwnd--setscrollpos.md)   
 [WM_SIZE](http://msdn.microsoft.com/library/windows/desktop/ms632646)