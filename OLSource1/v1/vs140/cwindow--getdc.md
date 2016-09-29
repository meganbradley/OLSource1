---
title: "CWindow::GetDC"
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
  - "ATL.CWindow.GetDC"
  - "ATL::CWindow::GetDC"
  - "CWindow.GetDC"
  - "CWindow::GetDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDC method"
ms.assetid: 25c34628-020f-4c32-a133-a3a09dac2638
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetDC
Retrieves a device context for the client area.  
  
## Syntax  
  
```  
  
HDC GetDC( ) throw();  
```  
  
## Remarks  
 See [GetDC](http://msdn.microsoft.com/library/windows/desktop/dd144871) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#9](../vs140/codesnippet/CPP/cwindow--getdc_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetDCEx](../vs140/cwindow--getdcex.md)   
 [CWindow::GetWindowDC](../vs140/cwindow--getwindowdc.md)   
 [CWindow::ReleaseDC](../vs140/cwindow--releasedc.md)