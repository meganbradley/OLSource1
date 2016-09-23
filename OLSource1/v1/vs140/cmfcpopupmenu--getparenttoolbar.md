---
title: "CMFCPopupMenu::GetParentToolBar"
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
  - CMFCPopupMenu::GetParentToolBar
  - CMFCPopupMenu.GetParentToolBar
  - GetParentToolBar
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetParentToolBar method
ms.assetid: 4a3ccdcf-6194-4fe9-ae32-d6478a9a0568
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPopupMenu::GetParentToolBar
Returns a pointer to the parent toolbar.  
  
## Syntax  
  
```  
CMFCToolBar* GetParentToolBar() const;  
```  
  
## Return Value  
 A pointer to the parent toolbar. `NULL` if the pop-up menu has no parent toolbar.  
  
## Remarks  
 If the [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) is a shortcut menu, then it has no parent toolbar.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)