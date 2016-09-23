---
title: "CListCtrl::GetNumberOfWorkAreas"
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
  - CListCtrl::GetNumberOfWorkAreas
  - CListCtrl.GetNumberOfWorkAreas
  - GetNumberOfWorkAreas
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetNumberOfWorkAreas method
ms.assetid: d227009f-25c7-4959-9709-2294b3d90013
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::GetNumberOfWorkAreas
Retrieves the current number of working areas for a list view control.  
  
## Syntax  
  
```  
  
UINT GetNumberOfWorkAreas( ) const;  
  
```  
  
## Return Value  
 Not used at this time.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_GetNumberOfWorkAreas](http://msdn.microsoft.com/library/windows/desktop/bb774988), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CListCtrl#25](../vs140/codesnippet/CPP/clistctrl--getnumberofworkareas_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetWorkAreas](../vs140/clistctrl--getworkareas.md)