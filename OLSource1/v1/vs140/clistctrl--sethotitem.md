---
title: "CListCtrl::SetHotItem"
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
  - CListCtrl::SetHotItem
  - CListCtrl.SetHotItem
  - SetHotItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetHotItem method
ms.assetid: c2f0354d-e522-40b8-af55-712295945108
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::SetHotItem
Sets the current hot item of a list view control.  
  
## Syntax  
  
```  
  
      int SetHotItem(  
   int iIndex   
);  
```  
  
#### Parameters  
 `iIndex`  
 Zero-based index of the item to be set as the hot item.  
  
## Return Value  
 The zero-based index of the previously hot item.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_SetHotItem](http://msdn.microsoft.com/library/windows/desktop/bb775083), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CListCtrl::GetHotItem](../vs140/clistctrl--gethotitem.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetHotCursor](../vs140/clistctrl--gethotcursor.md)   
 [CListCtrl::GetHotItem](../vs140/clistctrl--gethotitem.md)