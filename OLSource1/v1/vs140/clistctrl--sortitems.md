---
title: "CListCtrl::SortItems"
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
  - "CListCtrl.SortItems"
  - "SortItems"
  - "CListCtrl::SortItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SortItems method"
ms.assetid: 24a540d4-21af-48b5-abe2-77ac60ddbaa5
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SortItems
Sorts list view items by using an application-defined comparison function.  
  
## Syntax  
  
```  
BOOL SortItems(  
   PFNLVCOMPARE pfnCompare,  
   DWORD_PTR dwData   
);  
```  
  
#### Parameters  
 [in] `pfnCompare`  
 Address of the application-defined comparison function.  
  
 The sort operation calls the comparison function each time the relative order of two list items needs to be determined. The comparison function must be either a static member of a class or a stand-alone function that is not a member of any class.  
  
 [in] `dwData`  
 Application-defined value that is passed to the comparison function.  
  
## Return Value  
 `true` if the method successful; otherwise `false`.  
  
## Remarks  
 This method changes the index of each item to reflect the new sequence.  
  
 The comparison function, `pfnCompare`, has the following form:  
  
```  
int CALLBACK CompareFunc(LPARAM lParam1, LPARAM lParam2, LPARAM lParamSort);  
```  
  
 The comparison function must return a negative value if the first item should precede the second, a positive value if the first item should follow the second, or zero if the two items are equal.  
  
 The `lParam1` parameter is the 32-bit value associated with the first item that is compared, and the `lParam2` parameter is the value associated with the second item. These are the values that were specified in the `lParam` member of the items' [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure when they were inserted into the list. The `lParamSort` parameter is the same as the `dwData` value.  
  
 This method sends the [LVM_SORTITEMS](http://msdn.microsoft.com/library/windows/desktop/bb761227) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following is a simple comparison function that results in items being sorted by their `lParam` values.  
  
 [!code[NVC_MFC_CListCtrl#40](../vs140/codesnippet/CPP/clistctrl--sortitems_1.cpp)]  
  
 [!code[NVC_MFC_CListCtrl#44](../vs140/codesnippet/CPP/clistctrl--sortitems_2.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported under Windows NT 3.51 or later.  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::FindItem](../vs140/clistctrl--finditem.md)   
 [CListCtrl::SortItemsEx](../vs140/clistctrl--sortitemsex.md)