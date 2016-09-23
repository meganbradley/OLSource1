---
title: "CMFCMenuBar::GetMenuItem"
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
  - GetMenuItem
  - CMFCMenuBar::GetMenuItem
  - CMFCMenuBar.GetMenuItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetMenuItem method
ms.assetid: 982ec91a-4830-4c68-90af-5ee05328899a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCMenuBar::GetMenuItem
Retrieves a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object on a menu bar based on the item index.  
  
## Syntax  
  
```  
CMFCToolBarButton* GetMenuItem(  
   int iItem  
) const;  
```  
  
#### Parameters  
 [in] `iItem`  
 The index of the menu item to return.  
  
## Return Value  
 A pointer to the `CMFCToolBarButton` object that matches the index specified by `iItem`. `NULL` if the index is invalid.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)