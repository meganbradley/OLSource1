---
title: "CListCtrl::GetOrigin"
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
  - CListCtrl::GetOrigin
  - GetOrigin
  - CListCtrl.GetOrigin
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetOrigin method
ms.assetid: 544d7377-a15f-43d4-839a-33781fa59f59
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::GetOrigin
Retrieves the current view origin for a list view control.  
  
## Syntax  
  
```  
  
      BOOL GetOrigin(  
   LPPOINT lpPoint   
) const;  
```  
  
#### Parameters  
 `lpPoint`  
 Address of a [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that receives the view origin.  
  
## Return Value  
 Nonzero if successful; otherwise zero. However, if the control is in report view, the return value is always zero.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItemPosition](../vs140/clistctrl--getitemposition.md)   
 [CListCtrl::SetItemPosition](../vs140/clistctrl--setitemposition.md)