---
title: "CWnd::OnRenderAllFormats"
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
  - "CWnd::OnRenderAllFormats"
  - "CWnd.OnRenderAllFormats"
  - "OnRenderAllFormats"
  - "WM_RENDERALLFORMATS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_RENDERALLFORMATS"
  - "OnRenderAllFormats method"
ms.assetid: 1d19453f-9a68-488e-851d-bbefb52d709c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnRenderAllFormats
The Clipboard owner's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function is called by the framework when the owner application is being destroyed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The Clipboard owner should render the data in all the formats it is capable of generating and pass a data handle for each format to the Clipboard by calling the [SetClipboardData](http://msdn.microsoft.com/library/windows/desktop/ms649051) Windows function. This ensures that the Clipboard contains valid data even though the application that rendered the data is destroyed. The application should call the [OpenClipboard](../vs140/cwnd--openclipboard.md) member function before calling the [SetClipboardData](http://msdn.microsoft.com/library/windows/desktop/ms649051) Windows function and call the [CloseClipboard](http://msdn.microsoft.com/library/windows/desktop/ms649035) Windows function afterward.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CloseClipboard](http://msdn.microsoft.com/library/windows/desktop/ms649035)   
 [CWnd::OpenClipboard](../vs140/cwnd--openclipboard.md)   
 [SetClipboardData](http://msdn.microsoft.com/library/windows/desktop/ms649051)   
 [CWnd::OnRenderFormat](../vs140/cwnd--onrenderformat.md)   
 [WM_RENDERALLFORMATS](http://msdn.microsoft.com/library/windows/desktop/ms649029)