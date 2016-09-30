---
title: "CListCtrl::SortItemsEx"
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
  - "SortItemsEx method"
  - "CListCtrl.SortItemsEx"
  - "CListCtrl::SortItemsEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SortItemsEx method"
ms.assetid: cf6001e4-330a-4e42-bc06-a493b79750ac
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SortItemsEx
Sorts the items of the current list-view control by using an application-defined comparison function.  
  
## Syntax  
  
```  
BOOL SortItemsEx(  
     PFNLVCOMPARE pfnCompare,   
     DWORD_PTR dwData  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pfnCompare`|Address of the application-defined comparison function.\<br />\<br /> The sort operation calls the comparison function each time the relative order of two list items needs to be determined. The comparison function must be either a static member of a class or a stand-alone function that is not a member of any class.|  
|[in] `dwData`|Application-defined value passed to the comparison function.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method changes the index of each item to reflect the new sequence.  
  
 The comparison function, `pfnCompare`, has the following form:  
  
```  
int CALLBACK CompareFunc(LPARAM lParam1, LPARAM lParam2, LPARAM lParamSort);   
```  
  
 This message is like [LVM_SORTITEMS](http://msdn.microsoft.com/library/windows/desktop/bb761227), except for the type of information passed to the comparison function. In [LVM_SORTITEMS](http://msdn.microsoft.com/library/windows/desktop/bb761227), `lParam1` and `lParam2` are the values of the items to compare. In [LVM_SORTITEMSEX](http://msdn.microsoft.com/library/windows/desktop/bb761228), `lParam1` is the current index of the first item to compare and `lParam2` is the current index of the second item. You can send an [LVM_GETITEMTEXT](http://msdn.microsoft.com/library/windows/desktop/bb761055) message to retrieve more information about an item.  
  
 The comparison function must return a negative value if the first item should precede the second, a positive value if the first item should follow the second, or zero if the two items are equal.  
  
> [!NOTE]
>  During the sorting process, the list-view contents are unstable. If the callback function sends any messages to the list-view control other than [LVM_GETITEM](http://msdn.microsoft.com/library/windows/desktop/bb774953), the results are unpredictable.  
  
 This method sends the [LVM_SORTITEMSEX](http://msdn.microsoft.com/library/windows/desktop/bb761228) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in Windows 2000, Windows NT 4.0 with Internet Explorer 5, Windows 98, and later.  
  
## Example  
 The following code example defines a variable, `m_listCtrl`, that is used to access the current list-view control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CListCtrl_s2#6](../vs140/codesnippet/CPP/clistctrl--sortitemsex_1.h)]  
  
## Example  
 The following code example demonstrates the `SortItemEx` method. In an earlier section of this code example, we created a list-view control that displays two columns titled "ClientID" and "Grade" in a report view. The following code example sorts the table by using the values in the "Grade" column.  
  
 [!code[NVC_MFC_CListCtrl_s2#1](../vs140/codesnippet/CPP/clistctrl--sortitemsex_2.cpp)]  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_SORTITEMSEX](http://msdn.microsoft.com/library/windows/desktop/bb761228)   
 [CListCtrl::SortItems](../vs140/clistctrl--sortitems.md)   
 [LVM_SORTITEMS](http://msdn.microsoft.com/library/windows/desktop/bb761227)   
 [LVM_GETITEM](http://msdn.microsoft.com/library/windows/desktop/bb774953)