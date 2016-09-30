---
title: "CWnd::SetFont"
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
  - "CWnd.SetFont"
  - "CWnd::SetFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFont method"
  - "fonts [C++], window"
  - "windows [C++], setting fonts"
ms.assetid: fe7308ce-0f51-4f59-9197-f1478295e2ad
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetFont
Sends the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> message to the window to use the specified font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for the window to redraw immediately after it processes the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> message; otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method has no effect unless the window processes the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> message. Many MFC classes that derive from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> process this message because they are attached to a predefined window class that includes a message handler for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> message. To use this method, classes that you derive from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> must define a method handler for the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> message.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetFont](../vs140/cwnd--getfont.md)   
 [WM_SETFONT](http://msdn.microsoft.com/library/windows/desktop/ms632642)