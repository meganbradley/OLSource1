---
title: "CWindow::SetParent"
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
  - "CWindow::SetParent"
  - "CWindow.SetParent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetParent method"
ms.assetid: c810e1af-a55b-47cd-826b-c1b8f38fee2d
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::SetParent
Changes the parent window.  
  
## Syntax  
  
```  
  
      HWND SetParent(  
   HWND hWndNewParent   
) throw();  
```  
  
## Remarks  
 See [SetParent](http://msdn.microsoft.com/library/windows/desktop/ms633541) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#32](../vs140/codesnippet/CPP/cwindow--setparent_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetParent](../vs140/cwindow--getparent.md)