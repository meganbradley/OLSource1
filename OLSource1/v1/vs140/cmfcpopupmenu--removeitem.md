---
title: "CMFCPopupMenu::RemoveItem"
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
  - "RemoveItem"
  - "CMFCPopupMenu::RemoveItem"
  - "CMFCPopupMenu.RemoveItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveItem method"
ms.assetid: 2f5b7981-15f6-4270-ba23-e4b39b5fdf03
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::RemoveItem
Removes the specified item from the pop-up menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of the item to delete.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the method is successful; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method automatically arranges any separators that are affected by the removal of an item. For more information about how the framework rearranges separators, see [CMFCToolBar::RemoveButton](../vs140/cmfctoolbar--removebutton.md).  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)