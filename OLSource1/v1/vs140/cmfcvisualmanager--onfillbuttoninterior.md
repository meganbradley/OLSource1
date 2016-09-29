---
title: "CMFCVisualManager::OnFillButtonInterior"
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
  - "CMFCVisualManager::OnFillButtonInterior"
  - "CMFCVisualManager.OnFillButtonInterior"
  - "OnFillButtonInterior"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillButtonInterior method"
ms.assetid: 02685cfa-c331-4ed2-b575-7d849395677f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillButtonInterior
The framework calls this method when it fills the background of a toolbar button.  
  
## Syntax  
  
```  
virtual void OnFillButtonInterior(  
   CDC* pDC,  
   CMFCToolBarButton* pButton,  
   CRect rect,  
   CMFCVisualManager::AFX_BUTTON_STATE state  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context of a toolbar button.  
  
 [in] `pButton`  
 A pointer to a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md). The framework fills the background for this button.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the toolbar button.  
  
 [in] `state`  
 The state of the toolbar button.  
  
## Remarks  
 The default implementation of this method uses the default color to fill the background. Override this method in a derived visual manager to customize the background of a toolbar button.  
  
 The possible states of a toolbar button are `ButtonsIsRegular`, `ButtonsIsPressed`, or `ButtonsIsHighlighted`.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)