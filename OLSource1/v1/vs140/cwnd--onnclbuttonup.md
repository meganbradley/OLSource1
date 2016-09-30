---
title: "CWnd::OnNcLButtonUp"
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
  - "WM_NCLBUTTONUP"
  - "CWnd::OnNcLButtonUp"
  - "CWnd.OnNcLButtonUp"
  - "OnNcLButtonUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_NCLBUTTONUP"
  - "OnNcLButtonUp method"
ms.assetid: b8d8fadb-eb02-4f61-9912-8f0473b36a99
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcLButtonUp
The framework calls this member function when the user releases the left mouse button while the cursor is within a nonclient area.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the [hit-test code](../vs140/cwnd--onnchittest.md). A hit test is a test that determines the location of the cursor.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that contains the x and y screen coordinates of the cursor position. These coordinates are always relative to the upper-left corner of the screen.  
  
## Remarks  
 If appropriate, [WM_SYSCOMMAND](../vs140/cwnd--onsyscommand.md) is sent.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnNcHitTest](../vs140/cwnd--onnchittest.md)   
 [CWnd::OnNcLButtonDown](../vs140/cwnd--onnclbuttondown.md)   
 [CWnd::OnSysCommand](../vs140/cwnd--onsyscommand.md)   
 [CWnd::OnNcLButtonUp](../vs140/cwnd--onnclbuttonup.md)