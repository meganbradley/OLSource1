---
title: "List Control and List View"
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
  - CListView class, and CListCtrl
  - views, list and list control
  - CListCtrl class, and CListView
  - list views
  - list controls, List view
ms.assetid: 7aee1c48-b158-4399-be0b-be366993665e
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# List Control and List View
For convenience, MFC encapsulates the list control in two ways. You can use list controls:  
  
-   Directly, by embedding a [CListCtrl](../vs140/clistctrl-class.md) object in a dialog class.  
  
-   Indirectly, by using class [CListView](../vs140/clistview-class.md).  
  
 `CListView` makes it easy to integrate a list control with the MFC document/view architecture, encapsulating the control much as [CEditView](../vs140/ceditview-class.md) encapsulates an edit control: the control fills the entire surface area of an MFC view. (The view *is* the control, cast to `CListView`.)  
  
 A `CListView` object inherits from [CCtrlView](../vs140/cctrlview-class.md) and its base classes and adds a member function to retrieve the underlying list control. Use view members to work with the view as a view. Use the [GetListCtrl](../vs140/clistview--getlistctrl.md) member function to gain access to the list control's member functions. Use these members to:  
  
-   Add, delete, or manipulate "items" in the list.  
  
-   Set or get list control attributes.  
  
 To obtain a reference to the `CListCtrl` underlying a `CListView`, call `GetListCtrl` from your list view class:  
  
 [!code[NVC_MFCListView#4](../vs140/codesnippet/CPP/list-control-and-list-view_1.cpp)]
  
  
 This topic describes both ways to use the list control.  
  
## See Also  
 [Using CListCtrl](../vs140/using-clistctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)