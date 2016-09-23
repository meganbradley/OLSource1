---
title: "CMFCTabCtrl::IsTabDocumentsMenu"
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
  - CMFCTabCtrl::IsTabDocumentsMenu
  - IsTabDocumentsMenu
  - CMFCTabCtrl.IsTabDocumentsMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsTabDocumentsMenu method
ms.assetid: 5464a7de-8d3d-44ff-9cfd-c546e84e92dc
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTabCtrl::IsTabDocumentsMenu
Indicates whether the tab control displays scroll buttons or a button that displays a menu of tabbed windows.  
  
## Syntax  
  
```  
BOOL IsTabDocumentsMenu() const;  
```  
  
## Return Value  
 `TRUE` if tabbed windows are scrolled using a popup menu of tabbed window labels; `FALSE` if tabbed windows are scrolled using forward and backward scroll buttons.  
  
## Remarks  
 Use the [CMFCTabCtrl::EnableTabDocumentsMenu](../vs140/cmfctabctrl--enabletabdocumentsmenu.md) method to specify the method of scrolling tabbed windows.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCTabCtrl::EnableTabDocumentsMenu](../vs140/cmfctabctrl--enabletabdocumentsmenu.md)