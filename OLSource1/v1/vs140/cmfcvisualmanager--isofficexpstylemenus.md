---
title: "CMFCVisualManager::IsOfficeXPStyleMenus"
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
  - "CMFCVisualManager.IsOfficeXPStyleMenus"
  - "IsOfficeXPStyleMenus"
  - "CMFCVisualManager::IsOfficeXPStyleMenus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsOfficeXPStyleMenus method"
ms.assetid: c3e5dc90-d489-4a76-b06a-7428a29846fa
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::IsOfficeXPStyleMenus
Indicates whether the visual manager implements Office XP-style menus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the visual manager displays Office XP-style menus; otherwise 0.  
  
## Remarks  
 The [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md) calls this method when it has to draw the menu and shadow. By default, this method returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. If you want to use pop-up menus similar to the pop-up menus in Office XP, override this method in a custom visual manager and return <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)