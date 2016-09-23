---
title: "CMFCPopupMenu::GetMenuBar"
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
  - CMFCPopupMenu.GetMenuBar
  - CMFCPopupMenu::GetMenuBar
  - GetMenuBar
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetMenuBar method
ms.assetid: 583e6751-ebb0-48e1-ac25-376733a90b5c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPopupMenu::GetMenuBar
Returns the [CMFCPopupMenuBar](../vs140/cmfcpopupmenubar-class.md) embedded inside the pop-up menu.  
  
## Syntax  
  
```  
virtual CMFCPopupMenuBar* GetMenuBar();  
```  
  
## Return Value  
 A pointer to the embedded `CMFCPopupMenuBar`.  
  
## Remarks  
 The pop-up menu has an embedded `CMFCPopupMenuBar` object. You must override this method in a derived class if you are using a different embedded class.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCPopupMenuBar Class](../vs140/cmfcpopupmenubar-class.md)