---
title: "CMFCPopupMenu::UpdateAllShadows"
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
  - "CMFCPopupMenu.UpdateAllShadows"
  - "CMFCPopupMenu::UpdateAllShadows"
  - "UpdateAllShadows"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateAllShadows method"
ms.assetid: 2765ef1e-57a0-47c7-b4e3-44b8266198f2
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::UpdateAllShadows
Updates the shadows for all opened pop-up menus.  
  
## Syntax  
  
```  
static void UpdateAllShadows(  
   LPRECT lprectScreen = NULL  
);  
```  
  
#### Parameters  
 [in] `lprectScreen`  
 A rectangle that specifies the region to update, in screen coordinates.  
  
## Remarks  
 This method is useful when pop-up menus are displayed over animated controls or other windows that have dynamic content.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)