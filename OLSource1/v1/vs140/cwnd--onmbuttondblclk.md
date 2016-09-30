---
title: "CWnd::OnMButtonDblClk"
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
  - "CWnd::OnMButtonDblClk"
  - "CWnd.OnMButtonDblClk"
  - "OnMButtonDblClk"
  - "WM_MBUTTONDBLCLK"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_MBUTTONDBLCLK"
  - "OnMButtonDblClk method"
ms.assetid: 31a9b65d-e912-4149-81f2-88538e8cf9f7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnMButtonDblClk
The framework calls this member function when the user double-clicks the middle mouse button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates whether various virtual keys are down. This parameter can be any combination of the following values:  
  
-   **MK_CONTROL** Set if the CTRL key is down.  
  
-   **MK_LBUTTON** Set if the left mouse button is down.  
  
-   **MK_MBUTTON** Set if the middle mouse button is down.  
  
-   **MK_RBUTTON** Set if the right mouse button is down.  
  
-   **MK_SHIFT** Set if the SHIFT key is down.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinate of the cursor. These coordinates are always relative to the upper-left corner of the window.  
  
## Remarks  
 Only windows that have the **CS_DBLCLKS** [WNDCLASS](http://msdn.microsoft.com/library/windows/desktop/ms633576) style will receive <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> calls. This is the default for all Microsoft Foundation Class windows. Windows generates an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> call when the user presses, releases, and then presses the middle mouse button again within the system's double-click time limit. Double-clicking the middle mouse button actually generates four events: [WM_MBUTTONDOWN](../vs140/cwnd--onmbuttondown.md) and [WM_MBUTTONUP](../vs140/cwnd--onmbuttonup.md) messages, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> call, and another <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> message.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnMButtonDown](../vs140/cwnd--onmbuttondown.md)   
 [CWnd::OnMButtonUp](../vs140/cwnd--onmbuttonup.md)   
 [CWnd::OnMButtonDblClk](#_mfc_cwnd.3a3a.onmbuttondblclk)