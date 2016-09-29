---
title: "CWindow::GetWindowDC"
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
  - "CWindow.GetWindowDC"
  - "ATL::CWindow::GetWindowDC"
  - "CWindow::GetWindowDC"
  - "GetWindowDC"
  - "ATL.CWindow.GetWindowDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWindowDC method"
ms.assetid: 1b5d4ac6-25dc-4671-ad8f-bc82aa213da7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetWindowDC
Retrieves a device context for the entire window.  
  
## Syntax  
  
```  
  
HDC GetWindowDC() throw();  
```  
  
## Remarks  
 See [GetWindowDC](http://msdn.microsoft.com/library/windows/desktop/dd144947) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#14](../vs140/codesnippet/CPP/cwindow--getwindowdc_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetDC](../vs140/cwindow--getdc.md)   
 [CWindow::GetDCEx](../vs140/cwindow--getdcex.md)   
 [CWindow::ReleaseDC](../vs140/cwindow--releasedc.md)