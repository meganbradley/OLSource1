---
title: "Tree Control Item Position"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - CTreeCtrl class, item position
  - item position in tree controls
  - tree controls, item position
  - position, CTreeCtrl items
ms.assetid: cd264344-2cf9-4d90-9ea8-c6900b6f60e7
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Tree Control Item Position
An item's initial position is set when the item is added to the tree control ([CTreeCtrl](../vs140/ctreectrl-class.md)) by using the `InsertItem` member function. The member function call specifies the handle of the parent item and the handle of the item after which the new item is to be inserted. The second handle must identify either a child item of the given parent or one of these values: `TVI_FIRST`, `TVI_LAST`, or `TVI_SORT`.  
  
 When `TVI_FIRST` or `TVI_LAST` is specified, the tree control places the new item at the beginning or end of the given parent item's list of child items. When `TVI_SORT` is specified, the tree control inserts the new item into the list of child items in alphabetical order based on the text of the item labels.  
  
 You can put a parent item's list of child items into alphabetical order by calling the [SortChildren](../vs140/ctreectrl--sortchildren.md) member function. This function includes a parameter that specifies whether all levels of child items descending from the given parent item are also sorted in alphabetical order.  
  
 The [SortChildrenCB](../vs140/ctreectrl--sortchildrencb.md) member function allows you to sort child items based on criteria that you define. When you call this function, you specify an application-defined callback function that the tree control can call whenever the relative order of two child items needs to be decided. The callback function receives two 32-bit application-defined values for the items being compared and a third 32-bit value that you specify when calling `SortChildrenCB`.  
  
## See Also  
 [Using CTreeCtrl](../vs140/using-ctreectrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)