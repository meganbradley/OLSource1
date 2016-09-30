---
title: "CListCtrl::InsertGroup"
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
  - "CListCtrl::InsertGroup"
  - "InsertGroup"
  - "CListCtrl.InsertGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertGroup method"
ms.assetid: 70f9b40e-bbdc-490b-b457-eb7ed6dbf0f9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::InsertGroup
Inserts a group into the list view control.  
  
## Syntax  
  
```  
  
      LRESULT InsertGroup(  
   int index,  
   PLVGROUP pgrp   
);  
```  
  
#### Parameters  
 *index*  
 The index of the item where the group is to be inserted.  
  
 `pgrp`  
 A pointer to an [LVGROUP](http://msdn.microsoft.com/library/windows/desktop/bb774769) structure containing the group to be added.  
  
## Return Value  
 Returns the index of the item that the group was added to, or -1 if the operation failed.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_INSERTGROUP](http://msdn.microsoft.com/library/windows/desktop/bb761103) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)