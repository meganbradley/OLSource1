---
title: "CWindow::GetDescendantWindow"
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
  - "CWindow.GetDescendantWindow"
  - "CWindow::GetDescendantWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDescendantWindow method"
ms.assetid: 0daa7bad-1529-4e2c-af90-d01b1e290abc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetDescendantWindow
Finds the descendant window specified by the given identifier.  
  
## Syntax  
  
```  
  
      HWND GetDescendantWindow(  
   int nID   
) const throw();  
```  
  
#### Parameters  
 `nID`  
 [in] The identifier of the descendant window to be retrieved.  
  
## Return Value  
 The handle to a descendant window.  
  
## Remarks  
 `GetDescendantWindow` searches the entire tree of child windows, not only the windows that are immediate children.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetDlgItem](../vs140/cwindow--getdlgitem.md)