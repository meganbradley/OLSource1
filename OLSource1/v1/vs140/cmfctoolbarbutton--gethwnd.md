---
title: "CMFCToolBarButton::GetHwnd"
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
  - CMFCToolBarButton::GetHwnd
  - GetHwnd
  - CMFCToolBarButton.GetHwnd
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetHwnd method
ms.assetid: 301a5c3e-0ca3-4705-999a-bba7bcb376e5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarButton::GetHwnd
Retrieves the window handle that is associated with the toolbar button.  
  
## Syntax  
  
```  
virtual HWND GetHwnd();  
```  
  
## Return Value  
 The window handle that is associated with the toolbar button or `NULL` if the toolbar button has no associated window handle.  
  
## Remarks  
 The default implementation of this method returns `NULL`. Override this method to return the window handle of your specific control.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)