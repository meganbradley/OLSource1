---
title: "CWindow::GetIcon"
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
  - "CWindow.GetIcon"
  - "CWindow::GetIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetIcon method"
ms.assetid: e05604ce-8def-4056-b37b-ad528ff7cca0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetIcon
Retrieves the handle to the window's large or small icon.  
  
## Syntax  
  
```  
  
HICON GetIcon( BOOL   
bBigIcon  
 = TRUE ) const;  
  
```  
  
#### Parameters  
 `bBigIcon`  
 [in] If **TRUE** (the default value) the method returns the large icon. Otherwise, it returns the small icon.  
  
## Return Value  
 An icon handle.  
  
## Remarks  
 `GetIcon` sends a [WM_GETICON](http://msdn.microsoft.com/library/windows/desktop/ms632625) message to the window.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SetIcon](../vs140/cwindow--seticon.md)