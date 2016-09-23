---
title: "CListBox::CompareItem"
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
  - CListBox::CompareItem
  - CompareItem
  - CListBox.CompareItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - CListBox class, overridables
  - CompareItem method
ms.assetid: d704e53f-6a0c-4380-9cd2-3f647f05e0f2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListBox::CompareItem
Called by the framework to determine the relative position of a new item in a sorted owner-draw list box.  
  
## Syntax  
  
```  
  
      virtual int CompareItem(  
   LPCOMPAREITEMSTRUCT lpCompareItemStruct   
);  
```  
  
#### Parameters  
 `lpCompareItemStruct`  
 A long pointer to a `COMPAREITEMSTRUCT` structure.  
  
## Return Value  
 Indicates the relative position of the two items described in the [COMPAREITEMSTRUCT](../vs140/compareitemstruct-structure.md) structure. It may be any of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|–1|Item 1 sorts before item 2.|  
|0|Item 1 and item 2 sort the same.|  
|1|Item 1 sorts after item 2.|  
  
 See [CWnd::OnCompareItem](../vs140/cwnd--oncompareitem.md) for a description of the `COMPAREITEMSTRUCT` structure.  
  
## Remarks  
 By default, this member function does nothing. If you create an owner-draw list box with the **LBS_SORT** style, you must override this member function to assist the framework in sorting new items added to the list box.  
  
## Example  
 [!code[NVC_MFC_CListBox#5](../vs140/codesnippet/CPP/clistbox--compareitem_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_COMPAREITEM](http://msdn.microsoft.com/library/windows/desktop/bb775921)   
 [CWnd::OnCompareItem](../vs140/cwnd--oncompareitem.md)   
 [CListBox::DrawItem](../vs140/clistbox--drawitem.md)   
 [CListBox::MeasureItem](../vs140/clistbox--measureitem.md)   
 [CListBox::DeleteItem](../vs140/clistbox--deleteitem.md)