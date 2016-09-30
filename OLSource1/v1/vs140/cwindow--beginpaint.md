---
title: "CWindow::BeginPaint"
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
  - "CWindow.BeginPaint"
  - "CWindow::BeginPaint"
  - "ATL.CWindow.BeginPaint"
  - "ATL::CWindow::BeginPaint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BeginPaint method"
  - "BeginPaint method, CWindow"
ms.assetid: f7422ecb-deb6-4e8f-aad1-7b607d1752eb
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::BeginPaint
Prepares the window for painting.  
  
## Syntax  
  
```  
  
      HDC BeginPaint(  
   LPPAINTSTRUCT lpPaint   
) throw();  
```  
  
## Remarks  
 See [BeginPaint](http://msdn.microsoft.com/library/windows/desktop/dd183362) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#2](../vs140/codesnippet/CPP/cwindow--beginpaint_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::EndPaint](../vs140/cwindow--endpaint.md)