---
title: "CMFCBaseTabCtrl::SetTabIcon"
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
  - "SetTabIcon"
  - "CMFCBaseTabCtrl::SetTabIcon"
  - "CMFCBaseTabCtrl.SetTabIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTabIcon method"
ms.assetid: cb28ab77-1108-45a1-976d-23016a85f967
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::SetTabIcon
Sets the icon for a tab.  
  
## Syntax  
  
```  
virtual BOOL SetTabIcon(  
   int iTab,  
   UINT uiIcon  
);  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of the tab to update.  
  
 [in] `uiIcon`  
 The icon ID for the new icon. This ID references the internal [CImageList](../vs140/cimagelist-class.md) object.  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)