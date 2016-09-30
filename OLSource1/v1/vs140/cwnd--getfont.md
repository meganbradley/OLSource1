---
title: "CWnd::GetFont"
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
  - "CWnd::GetFont"
  - "CWnd.GetFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFont method"
ms.assetid: 34f5b74e-3d8d-4ee1-9982-b3c0585e0abe
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetFont
Sends the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> message to the window to retrieve the current font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Pointer to a [CFont](../vs140/cfont-class.md) object that is attached to the current font for the window.  
  
## Remarks  
 This method has no effect unless the window processes the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> message. Many MFC classes that derive from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> process this message because they are attached to a predefined window class that includes a message handler for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message. To use this method, classes that you derive from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must define a method handler for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> message.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetFont](../vs140/cwnd--setfont.md)   
 [WM_GETFONT](http://msdn.microsoft.com/library/windows/desktop/ms632624)   
 [CFont Class](../vs140/cfont-class.md)