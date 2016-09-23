---
title: "CListCtrl::SetWorkAreas"
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
  - SetWorkAreas
  - CListCtrl.SetWorkAreas
  - CListCtrl::SetWorkAreas
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetWorkAreas method
ms.assetid: 18a0d19a-4379-4b38-ba70-86dd73b9d437
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::SetWorkAreas
Sets the area where icons can be displayed in a list view control.  
  
## Syntax  
  
```  
  
      void SetWorkAreas(  
   int nWorkAreas,  
   LPRECT lpRect   
);  
```  
  
#### Parameters  
 `nWorkAreas`  
 The number of `RECT` structures (or [CRect](../vs140/crect-class.md) objects) in the array pointed to by `lpRect`.  
  
 `lpRect`  
 The address of an array of `RECT` structures (or `CRect` objects) that specify the new work areas of the list view control. These areas must be specified in client coordinates. If this parameter is **NULL**, the working area will be set to the client area of the control.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_SetWorkAreas](http://msdn.microsoft.com/library/windows/desktop/bb775128), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CListCtrl#39](../vs140/codesnippet/CPP/clistctrl--setworkareas_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)