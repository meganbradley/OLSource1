---
title: "CMFCColorPopupMenu::GetMenuBar"
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
  - CMFCColorPopupMenu.GetMenuBar
  - CMFCColorPopupMenu::GetMenuBar
  - GetMenuBar
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetMenuBar method
ms.assetid: d9f8239e-fb3a-4d17-8a34-797959b3fcb5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCColorPopupMenu::GetMenuBar
Returns the [CMFCPopupMenuBar](../vs140/cmfcpopupmenubar-class.md) that is embedded inside the pop-up menu.  
  
## Syntax  
  
```  
virtual CMFCPopupMenuBar* GetMenuBar();  
```  
  
## Return Value  
 A pointer to the embedded `CMFCPopupMenuBar`.  
  
## Remarks  
 The color pop-up menu has an embedded [CMFCPopupMenuBar Class](../vs140/cmfcpopupmenubar-class.md) object. Override this method in a derived class if your application uses a different embedded type.  
  
## Requirements  
 **Header:** afxcolorpopupmenu.h  
  
## See Also  
 [CMFCColorPopupMenu Class](../vs140/cmfccolorpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCPopupMenuBar Class](../vs140/cmfcpopupmenubar-class.md)