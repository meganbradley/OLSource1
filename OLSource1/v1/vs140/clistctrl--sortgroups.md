---
title: "CListCtrl::SortGroups"
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
  - "CListCtrl::SortGroups"
  - "CListCtrl.SortGroups"
  - "SortGroups"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SortGroups method"
ms.assetid: 0c5d0369-8897-43ae-802d-ba6b6149050e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SortGroups
Uses an application-defined comparison function to sort groups by ID within a list view control.  
  
## Syntax  
  
```  
  
      BOOL SortGroups(  
   PFNLVGROUPCOMPARE _pfnGroupCompare,  
   LPVOID _plv   
);  
```  
  
#### Parameters  
 `_pfnGroupCompare`  
 A pointer to the group comparison function.  
  
 `_plv`  
 A void pointer.  
  
## Return Value  
 Returns `true` on success, `false` on failure.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_SORTGROUPS](http://msdn.microsoft.com/library/windows/desktop/bb761225) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)