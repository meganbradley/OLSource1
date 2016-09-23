---
title: "CWnd::OnChildActivate"
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
  - CWnd::OnChildActivate
  - WM_CHILDACTIVATE
  - OnChildActivate
  - CWnd.OnChildActivate
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnChildActivate method
  - WM_CHILDACTIVATE
ms.assetid: 01b45104-46a0-440e-8a8a-1f07dd17f903
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnChildActivate
If the `CWnd` object is a multiple document interface (MDI) child window, `OnChildActivate` is called by the framework when the user clicks the window's title bar or when the window is activated, moved, or sized.  
  
## Syntax  
  
```  
  
afx_msg void OnChildActivate( );  
```  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md)   
 [WM_CHILDACTIVATE](http://msdn.microsoft.com/library/windows/desktop/ms632616)