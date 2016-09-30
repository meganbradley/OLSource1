---
title: "CWnd::OnNcMButtonDown"
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
  - "CWnd.OnNcMButtonDown"
  - "WM_NCMBUTTONDOWN"
  - "CWnd::OnNcMButtonDown"
  - "OnNcMButtonDown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNcMButtonDown method"
  - "WM_NCMBUTTONDOWN"
ms.assetid: 592998eb-504e-4dfc-847c-65c9f7e99ae7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcMButtonDown
The framework calls this member function when the user presses the middle mouse button while the cursor is within a nonclient area.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the [hit-test code](../vs140/cwnd--onnchittest.md). A hit test is a test that determines the location of the cursor.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that contains the x and y screen coordinates of the cursor position. These coordinates are always relative to the upper-left corner of the screen.  
  
## Remarks  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnNcHitTest](../vs140/cwnd--onnchittest.md)   
 [CWnd::OnNcMButtonDblClk](../vs140/cwnd--onncmbuttondblclk.md)   
 [CWnd::OnNcMButtonUp](../vs140/cwnd--onncmbuttonup.md)   
 [CWnd::OnNcMButtonDown](#_mfc_cwnd.3a3a.onncmbuttondown)