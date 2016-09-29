---
title: "CWindow::DeferWindowPos"
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
  - "ATL.CWindow.DeferWindowPos"
  - "CWindow.DeferWindowPos"
  - "ATL::CWindow::DeferWindowPos"
  - "DeferWindowPos"
  - "CWindow::DeferWindowPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeferWindowPos method"
ms.assetid: 051193f2-5777-43d0-a84a-a206cd0f602c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::DeferWindowPos
Updates the specified multiple-window-position structure for the specified window.  
  
## Syntax  
  
```  
  
      HDWP DeferWindowPos(  
   HDWP hWinPosInfo,  
   HWND hWndInsertAfter,  
   int x,  
   int y,  
   int cx,  
   int cy,  
   UINT uFlags   
) throw();  
```  
  
## Remarks  
 See [DeferWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms632681) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)