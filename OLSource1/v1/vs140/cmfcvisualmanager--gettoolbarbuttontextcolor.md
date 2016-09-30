---
title: "CMFCVisualManager::GetToolbarButtonTextColor"
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
  - "CMFCVisualManager.GetToolbarButtonTextColor"
  - "GetToolbarButtonTextColor"
  - "CMFCVisualManager::GetToolbarButtonTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolbarButtonTextColor method"
ms.assetid: 24989b9e-98dc-410e-9793-cb7540cbe0f1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::GetToolbarButtonTextColor
The framework calls this method to determine the text color of a toolbar button.  
  
## Syntax  
  
```  
virtual COLORREF GetToolbarButtonTextColor(  
   CMFCToolBarButton* pButton,  
   CMFCVisualManager::AFX_BUTTON_STATE state   
);  
```  
  
#### Parameters  
 [in] `pButton`  
 A pointer to the toolbar button.  
  
 [in] `state`  
 The state of the toolbar button.  
  
## Return Value  
 The text color of `pButton` when it has the state indicated by `state`.  
  
## Remarks  
 The text color of a [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md) object depends on the state of the button. The possible states of a toolbar button are `ButtonsIsRegular`, `ButtonsIsPressed`, or `ButtonsIsHighlighted`.  
  
 Override this function to customize the text color of a toolbar button in your application.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)