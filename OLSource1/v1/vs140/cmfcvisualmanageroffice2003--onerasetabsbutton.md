---
title: "CMFCVisualManagerOffice2003::OnEraseTabsButton"
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
  - "CMFCVisualManagerOffice2003.OnEraseTabsButton"
  - "OnEraseTabsButton"
  - "CMFCVisualManagerOffice2003::OnEraseTabsButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEraseTabsButton method"
ms.assetid: b07b6551-107e-4545-b3b1-90471d956919
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnEraseTabsButton
The framework calls this method when it erases the text and icon of a tab button.  
  
## Syntax  
  
```  
virtual void OnEraseTabsButton(  
   CDC* pDC,  
   CRect rect,  
   CMFCButton* pButton,  
   CMFCBaseTabCtrl* pWndTab  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the tab button.  
  
 [in] `pButton`  
 A pointer to a tab button. The framework erases the text and icon for this button.  
  
 [in] `pWndTab`  
 A pointer to the tab control that contains the tab button.  
  
## Remarks  
 The framework erases the text and icon for a button when a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object processes the `WM_ERASEBKGND` message  
  
 Override this method in a derived visual manager to customize the appearance of tab buttons.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)