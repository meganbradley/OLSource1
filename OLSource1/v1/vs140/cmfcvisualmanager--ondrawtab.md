---
title: "CMFCVisualManager::OnDrawTab"
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
  - "CMFCVisualManager.OnDrawTab"
  - "OnDrawTab"
  - "CMFCVisualManager::OnDrawTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTab method"
ms.assetid: 932233d5-5bc3-4466-bc4c-411e960b5fd3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawTab
The framework calls this method when it draws the tabs for a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawTab(  
   CDC* pDC,  
   CRect rectTab,  
   int iTab,  
   BOOL bIsActive,  
   const CMFCBaseTabCtrl* pTabWnd  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectTab`  
 A rectangle that specifies the boundaries of the tab control.  
  
 [in] `iTab`  
 The index of the tab that the framework draws.  
  
 [in] `bIsActive`  
 A Boolean parameter that specifies whether the tab is active.  
  
 [in] `pTabWnd`  
 A pointer to a `CMFCBaseTabCtrl` object. The framework draws this tab control.  
  
## Remarks  
 A `CMFCBaseTabCtrl` object calls this method when it processes the WM_PAINT message.  
  
 Override this method in a derived class to customize the look of tabs.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)