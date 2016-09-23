---
title: "CWindow::EnableWindow"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CWindow::EnableWindow
  - ATL.CWindow.EnableWindow
  - ATL::CWindow::EnableWindow
  - CWindow.EnableWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnableWindow method
ms.assetid: 92746872-74df-46a7-9187-42aff98bb382
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::EnableWindow
Enables or disables input.  
  
## Syntax  
  
```  
  
      BOOL EnableWindow(  
   BOOL bEnable = TRUE   
) throw();  
```  
  
## Remarks  
 See [EnableWindow](http://msdn.microsoft.com/library/windows/desktop/ms646291) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#7](../vs140/codesnippet/CPP/cwindow--enablewindow_1.cpp)]
  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::IsWindowEnabled](../vs140/cwindow--iswindowenabled.md)