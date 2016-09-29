---
title: "CMFCVisualManagerOffice2003::OnDrawTabsButtonBorder"
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
  - "CMFCVisualManagerOffice2003.OnDrawTabsButtonBorder"
  - "OnDrawTabsButtonBorder"
  - "CMFCVisualManagerOffice2003::OnDrawTabsButtonBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTabsButtonBorder method"
ms.assetid: b3f224dc-d97d-4d5c-a126-eced51ba00e0
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawTabsButtonBorder
The framework calls this method when it draws the border of a tab button.  
  
## Syntax  
  
```  
virtual void OnDrawTabsButtonBorder(  
   CDC* pDC,  
   CRect& rect,  
   CMFCButton* pButton,  
   UINT uiState,  
   CMFCBaseTabCtrl* pWndTab  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the tab button.  
  
 [in] `pButton`  
 A pointer to the [CMFCButton](../vs140/cmfcbutton-class.md) for which the framework draws the border.  
  
 [in] `uiState`  
 The state of the button (see [CButton::GetState](../vs140/cbutton--getstate.md)).  
  
 [in] `pWndTab`  
 A pointer to the parent tab window.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the border of the tab button.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)