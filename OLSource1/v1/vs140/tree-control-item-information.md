---
title: "Tree Control Item Information"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tree controls, item information"
  - "CTreeCtrl class, item information"
ms.assetid: 8dcab855-27de-49e9-95d8-f78ba963ea71
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Tree Control Item Information
Tree controls ([CTreeCtrl](../vs140/ctreectrl-class.md)) have a number of member functions that retrieve information about items in the control. The [GetItem](../vs140/ctreectrl--getitem.md) member function retrieves some or all of the data associated with an item. This data could include the item's text, state, images, count of child items, and an application-defined 32-bit data value. There is also a [SetItem](../vs140/ctreectrl--setitem.md) function that can set some or all of the data associated with an item.  
  
 The [GetItemState](../vs140/ctreectrl--getitemstate.md), [GetItemText](../vs140/ctreectrl--getitemtext.md), [GetItemData](../vs140/ctreectrl--getitemdata.md), and [GetItemImage](../vs140/ctreectrl--getitemimage.md) member functions retrieve individual attributes of an item. Each of these functions has a corresponding Set function for setting the attributes of an item.  
  
 The [GetNextItem](../vs140/ctreectrl--getnextitem.md) member function retrieves the tree control item that bears the specified relationship to the current item. This function can retrieve an item's parent, the next or previous visible item, the first child item, and so on. There are also member functions to traverse the tree: [GetRootItem](../vs140/ctreectrl--getrootitem.md), [GetFirstVisibleItem](../vs140/ctreectrl--getfirstvisibleitem.md), [GetNextVisibleItem](../vs140/ctreectrl--getnextvisibleitem.md), [GetPrevVisibleItem](../vs140/ctreectrl--getprevvisibleitem.md), [GetChildItem](../vs140/ctreectrl--getchilditem.md), [GetNextSiblingItem](../vs140/ctreectrl--getnextsiblingitem.md), [GetPrevSiblingItem](../vs140/ctreectrl--getprevsiblingitem.md), [GetParentItem](../vs140/ctreectrl--getparentitem.md), [GetSelectedItem](../vs140/ctreectrl--getselecteditem.md), and [GetDropHilightItem](../vs140/ctreectrl--getdrophilightitem.md).  
  
 The [GetItemRect](../vs140/ctreectrl--getitemrect.md) member function retrieves the bounding rectangle for a tree control item. The [GetCount](../vs140/ctreectrl--getcount.md) and [GetVisibleCount](../vs140/ctreectrl--getvisiblecount.md) member functions retrieve a count of the items in a tree control and a count of the items that are currently visible in the tree control's window, respectively. You can ensure that a particular item is visible by calling the [EnsureVisible](../vs140/ctreectrl--ensurevisible.md) member function.  
  
## See Also  
 [Using CTreeCtrl](../vs140/using-ctreectrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)