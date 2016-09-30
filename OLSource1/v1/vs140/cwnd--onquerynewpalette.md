---
title: "CWnd::OnQueryNewPalette"
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
  - "OnQueryNewPalette"
  - "WM_QUERYNEWPALETTE"
  - "CWnd.OnQueryNewPalette"
  - "CWnd::OnQueryNewPalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_QUERYNEWPALETTE"
  - "OnQueryNewPalette method"
ms.assetid: 3bbf0a2d-9004-4298-b781-e1bb74f7eb0a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnQueryNewPalette
The framework calls this member function when the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is about to receive the input focus, giving the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> an opportunity to realize its logical palette when it receives the focus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> realizes its logical palette; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Default](../vs140/cwnd--default.md)   
 [CWnd::OnPaletteChanged](../vs140/cwnd--onpalettechanged.md)   
 [WM_QUERYNEWPALETTE](http://msdn.microsoft.com/library/windows/desktop/dd145218)