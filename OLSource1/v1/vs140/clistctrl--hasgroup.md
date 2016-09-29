---
title: "CListCtrl::HasGroup"
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
  - "CListCtrl::HasGroup"
  - "HasGroup"
  - "CListCtrl.HasGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HasGroup method"
ms.assetid: 6d8de8ef-5227-447b-b8f2-ef911a332b35
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::HasGroup
Determines if the list view control has the specified group.  
  
## Syntax  
  
```  
  
      BOOL HasGroup(  
   int iGroupId   
) const;  
```  
  
#### Parameters  
 `iGroupId`  
 The identifier of the group being requested.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_HASGROUP](http://msdn.microsoft.com/library/windows/desktop/bb761097) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)