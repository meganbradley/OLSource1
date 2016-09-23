---
title: "CCmdUI::m_pSubMenu"
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
  - m_pSubMenu
  - CCmdUI.m_pSubMenu
  - CCmdUI::m_pSubMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_pSubMenu
  - CCmdUI class, data members
ms.assetid: d21d5542-6d0c-4f64-97df-62a114637290
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCmdUI::m_pSubMenu
Pointer (of `CMenu` type) to the contained sub-menu represented by the `CCmdUI` object.  
  
## Syntax  
  
```  
  
CMenu* m_pSubMenu;  
  
```  
  
## Remarks  
 **NULL** if the item is not a menu. If the sub menu is a pop-up, `m_nID` contains the ID of the first item in the pop-up menu. For more information, see [Technical Note 21](../vs140/tn021--command-and-message-routing.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdUI Class](../vs140/ccmdui-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu Class](../vs140/cmenu-class.md)