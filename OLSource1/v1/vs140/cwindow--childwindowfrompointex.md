---
title: "CWindow::ChildWindowFromPointEx"
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
  - "ChildWindowFromPointEx"
  - "CWindow::ChildWindowFromPointEx"
  - "CWindow.ChildWindowFromPointEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ChildWindowFromPointEx method"
ms.assetid: 24f05db1-dd3e-40b0-82c9-6ec6ccfc3d14
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::ChildWindowFromPointEx
Retrieves a particular type of child window containing the specified point.  
  
## Syntax  
  
```  
  
      HWND ChildWindowFromPoint(  
   POINT point,  
   UINT uFlags   
) const throw();  
```  
  
## Remarks  
 See [ChildWindowFromPointEx](http://msdn.microsoft.com/library/windows/desktop/ms632677) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::ChildWindowFromPoint](../vs140/cwindow--childwindowfrompoint.md)   
 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805)