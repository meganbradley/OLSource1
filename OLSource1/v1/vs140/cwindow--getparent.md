---
title: "CWindow::GetParent"
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
  - "CWindow::GetParent"
  - "CWindow.GetParent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParent method"
ms.assetid: bfe5d4de-8620-4e2c-b4ae-498e71fccbe5
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetParent
Retrieves the immediate parent window.  
  
## Syntax  
  
```  
  
HWND GetParent( ) const throw();  
```  
  
## Remarks  
 See [GetParent](http://msdn.microsoft.com/library/windows/desktop/ms633510) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#11](../vs140/codesnippet/CPP/cwindow--getparent_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SetParent](../vs140/cwindow--setparent.md)