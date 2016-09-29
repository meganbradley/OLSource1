---
title: "CListCtrl::InsertGroupSorted"
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
  - "InsertGroupSorted"
  - "CListCtrl::InsertGroupSorted"
  - "CListCtrl.InsertGroupSorted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertGroupSorted method"
ms.assetid: fe20025a-52bc-4e71-bbf8-27dcb577c0ae
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::InsertGroupSorted
Inserts the specified group into an ordered list of groups.  
  
## Syntax  
  
```  
  
      LRESULT InsertGroupSorted(  
   PLVINSERTGROUPSORTED pStructInsert   
);  
```  
  
#### Parameters  
 *pStructInsert*  
 A pointer to an [LVINSERTGROUPSORTED](http://msdn.microsoft.com/library/windows/desktop/bb774756) structure that contains the group to insert.  
  
## Return Value  
 The return value is not used.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_INSERTGROUPSORTED](http://msdn.microsoft.com/library/windows/desktop/bb761105) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)