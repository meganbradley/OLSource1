---
title: "CWindow::ScreenToClient"
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
  - "CWindow::ScreenToClient"
  - "CWindow.ScreenToClient"
  - "ATL::CWindow::ScreenToClient"
  - "ATL.CWindow.ScreenToClient"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ScreenToClient method"
ms.assetid: 0ab56f1e-7d43-4860-8df0-a963dfc27f5d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::ScreenToClient
Converts screen coordinates to client coordinates.  
  
## Syntax  
  
```  
  
      BOOL ScreenToClient(  
   LPPOINT lpPoint   
) const throw();  
BOOL ScreenToClient(  
   LPRECT lpRect   
) const throw();  
```  
  
## Remarks  
 See [ScreenToClient](http://msdn.microsoft.com/library/windows/desktop/dd162952) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The second version of this method allows you to convert the coordinates of a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::ClientToScreen](../vs140/cwindow--clienttoscreen.md)   
 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805)