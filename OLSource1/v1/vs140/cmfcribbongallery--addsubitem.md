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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonGallery::AddSubItem
Adds a new menu item to the drop-down menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the item to add to the menu.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the zero-based index of a location where to insert the item.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to specify that the item should be inserted before the ribbon gallery; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 You can combine popup galleries with popup menu items by calling this method. Menu items can be placed before or after the gallery.  
  
 To insert the item before the gallery, set <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Set <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to insert the item below the gallery.  
  
> [!NOTE]
>  The parameter <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> specifies the insertion index both at the top of the gallery and at the bottom of the gallery. For example, if you need to insert an item one position before the gallery, set <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to 1 and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Similarly, if you need to insert an item one position below the gallery, set <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to 1 and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxRibbonPaletteGallery.h  
  
## See Also  
 [CMFCRibbonGallery Class](../vs140/cmfcribbongallery-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)