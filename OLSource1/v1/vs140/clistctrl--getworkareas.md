---
title: "CListCtrl::GetWorkAreas"
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
  - "CListCtrl.GetWorkAreas"
  - "GetWorkAreas"
  - "CListCtrl::GetWorkAreas"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWorkAreas method"
ms.assetid: 40f59cd5-6704-448f-871a-09774b0b178a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetWorkAreas
Retrieves the current working areas of a list view control.  
  
## Syntax  
  
```  
  
      void GetWorkAreas(  
   int nWorkAreas,  
   LPRECT prc   
) const;  
```  
  
#### Parameters  
 `nWorkAreas`  
 The number of `RECT` structures contained in the *prc* array.  
  
 `prc`  
 A pointer to an array of `RECT` structures (or [CRect](../vs140/crect-class.md) objects) that receive the working areas of the list view control. Values in these structures are in client coordinates.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_GetWorkAreas](http://msdn.microsoft.com/library/windows/desktop/bb775024), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CListCtrl::GetNumberOfWorkAreas](../vs140/clistctrl--getnumberofworkareas.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetNumberOfWorkAreas](../vs140/clistctrl--getnumberofworkareas.md)