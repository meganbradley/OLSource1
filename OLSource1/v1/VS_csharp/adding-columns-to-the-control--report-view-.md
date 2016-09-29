---
title: "Adding Columns to the Control (Report View)"
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
  - "CListCtrl class, adding columns"
  - "report view in CListCtrl class"
  - "views, report"
  - "columns [C++], adding to CListCtrl"
  - "CListCtrl class, report view"
ms.assetid: 7392c0d7-f8a5-4e7b-9ae7-b53dc9dd80ae
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding Columns to the Control (Report View)
> [!NOTE]
>  The following procedure applies to either a [CListView](../VS_csharp/clistview-class.md) or [CListCtrl](../VS_csharp/clistctrl-class.md) object.  
  
 When a list control is in report view, columns are displayed, providing a method of organizing the various subitems of each list control item. This organization is implemented with a one-to-one correspondence between a column in the list control and the associated subitem of the list control item. For more information on subitems, see [Adding Items to the Control](../VS_csharp/adding-items-to-the-control.md). An example of a list control in report view is provided by the Details view in Windows 95 and Windows 98 Explorer. The first column lists folder, file icons, and labels. Other columns list file size, file type, date last modified, and so on.  
  
 Even though columns can be added to a list control at any time, the columns are visible only when the control has the `LVS_REPORT` style bit turned on.  
  
 Each column has an associated header item (see [CHeaderCtrl](../VS_csharp/cheaderctrl-class.md)) object that labels the column and allows users to resize the column.  
  
 If your list control supports a report view, you need to add a column for each possible subitem in a list control item. Add a column by preparing an [LV_COLUMN](http://msdn.microsoft.com/library/windows/desktop/bb774743) structure and then making a call to [InsertColumn](../Topic/CListCtrl::InsertColumn.md). After adding the necessary columns (sometimes referred to as header items), you can reorder them using member functions and styles belonging to the embedded header control. For more information, see [Ordering Items in the Header Control](../VS_csharp/ordering-items-in-the-header-control.md).  
  
> [!NOTE]
>  If the list control is created with the **LVS_NOCOLUMNHEADER** style, any attempt to insert columns will be ignored.  
  
## See Also  
 [Using CListCtrl](../VS_csharp/using-clistctrl.md)   
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)