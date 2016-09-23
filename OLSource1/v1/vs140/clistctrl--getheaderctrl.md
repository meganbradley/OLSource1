---
title: "CListCtrl::GetHeaderCtrl"
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
  - CListCtrl.GetHeaderCtrl
  - CListCtrl::GetHeaderCtrl
  - GetHeaderCtrl
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetHeaderCtrl method
ms.assetid: 4b5160dd-a057-44cb-8c27-2343a36b512a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::GetHeaderCtrl
Retrieves the header control of a list view control.  
  
## Syntax  
  
```  
  
CHeaderCtrl* GetHeaderCtrl( );  
  
```  
  
## Return Value  
 A pointer to the header control, used by the list view control.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_GetHeader](http://msdn.microsoft.com/library/windows/desktop/bb761290), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CListCtrl::GetColumnOrderArray](../vs140/clistctrl--getcolumnorderarray.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)