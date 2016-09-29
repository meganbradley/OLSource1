---
title: "CMFCVisualManager::OnDrawButtonBorder"
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
  - "CMFCVisualManager::OnDrawButtonBorder"
  - "CMFCVisualManager.OnDrawButtonBorder"
  - "OnDrawButtonBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawButtonBorder method"
ms.assetid: 298f2233-beda-484c-b3d0-96ffd2290347
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawButtonBorder
The framework calls this method when it draws the border of a toolbar button.  
  
## Syntax  
  
```  
virtual void OnDrawButtonBorder(  
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
 A pointer to a toolbar button. The framework draws the border of this button.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the toolbar button.  
  
 [in] `state`  
 An enumerated data type that specifies the current state of the toolbar button.  
  
## Remarks  
 The default implementation of this method displays the standard border. Override this method in a derived visual manager to customize the appearance of the border of a toolbar button.  
  
 The possible states of a toolbar button are `ButtonsIsRegular`, `ButtonsIsPressed`, or `ButtonsIsHighlighted`.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)