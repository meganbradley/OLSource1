---
title: "CWnd::OnRButtonUp"
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
  - "OnRButtonUp"
  - "CWnd::OnRButtonUp"
  - "CWnd.OnRButtonUp"
  - "WM_RBUTTONUP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_RBUTTONUP"
  - "OnRButtonUp method"
ms.assetid: 0cb0fc44-849b-4207-9f9b-fecb2c58c78b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnRButtonUp
The framework calls this member function when the user releases the right mouse button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates whether various virtual keys are down. This parameter can be any combination of the following values:  
  
-   **MK_CONTROL** Set if CTRL key is down.  
  
-   **MK_LBUTTON** Set if left mouse button is down.  
  
-   **MK_MBUTTON** Set if middle mouse button is down.  
  
-   **MK_SHIFT** Set if SHIFT key is down.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the x and y coordinates of the cursor. These coordinates are always relative to the upper-left corner of the window.  
  
## Remarks  
 This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnRButtonDblClk](../vs140/cwnd--onrbuttondblclk.md)   
 [CWnd::OnRButtonDown](../vs140/cwnd--onrbuttondown.md)   
 [WM_RBUTTONUP](http://msdn.microsoft.com/library/windows/desktop/ms646243)