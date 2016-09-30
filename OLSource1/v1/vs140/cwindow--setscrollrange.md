---
title: "CWindow::SetScrollRange"
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
  - "ATL::CWindow::SetScrollRange"
  - "CWindow.SetScrollRange"
  - "ATL.CWindow.SetScrollRange"
  - "CWindow::SetScrollRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetScrollRange method"
ms.assetid: cbc9737b-be33-4ae9-9589-e4cd4c0683ec
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::SetScrollRange
Changes the scroll bar range.  
  
## Syntax  
  
```  
  
      BOOL SetScrollRange(  
   int nBar,  
   int nMinPos,  
   int nMaxPos,  
   BOOL bRedraw = TRUE   
) throw();  
```  
  
## Remarks  
 See [SetScrollRange](http://msdn.microsoft.com/library/windows/desktop/bb787599) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetScrollRange](../vs140/cwindow--getscrollrange.md)