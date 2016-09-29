---
title: "CMFCRibbonGallery::AddSubItem"
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
  - "AddSubItem"
  - "CMFCRibbonGallery::AddSubItem"
  - "CMFCRibbonGallery.AddSubItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddSubItem method"
ms.assetid: a644d335-76e0-420a-9335-4eac9664719c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonGallery::AddSubItem
Adds a new menu item to the drop-down menu.  
  
## Syntax  
  
```  
void AddSubItem(  
    CMFCRibbonBaseElement* pSubItem,  
    int nIndex=-1,  
    BOOL bOnTop=FALSE   
);  
```  
  
#### Parameters  
 [in] `pSubItem`  
 A pointer to the item to add to the menu.  
  
 [in] `nIndex`  
 Specifies the zero-based index of a location where to insert the item.  
  
 [in] `bOnTop`  
 `TRUE` to specify that the item should be inserted before the ribbon gallery; otherwise, `FALSE`.  
  
## Remarks  
 You can combine popup galleries with popup menu items by calling this method. Menu items can be placed before or after the gallery.  
  
 To insert the item before the gallery, set `bOnTop` to `TRUE`. Set `bOnTop` to `FALSE` to insert the item below the gallery.  
  
> [!NOTE]
>  The parameter `nIndex` specifies the insertion index both at the top of the gallery and at the bottom of the gallery. For example, if you need to insert an item one position before the gallery, set `nIndex` to 1 and `bOnTop` to `TRUE`. Similarly, if you need to insert an item one position below the gallery, set `nIndex` to 1 and `bOnTop` to `FALSE`.  
  
## Requirements  
 **Header:** afxRibbonPaletteGallery.h  
  
## See Also  
 [CMFCRibbonGallery Class](../vs140/cmfcribbongallery-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)