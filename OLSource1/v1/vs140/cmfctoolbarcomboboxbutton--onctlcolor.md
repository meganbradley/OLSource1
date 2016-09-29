---
title: "CMFCToolBarComboBoxButton::OnCtlColor"
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
  - "CMFCToolBarComboBoxButton.OnCtlColor"
  - "CMFCToolBarComboBoxButton::OnCtlColor"
  - "OnCtlColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCtlColor method"
ms.assetid: 15443c7f-e064-4c8c-b3d6-f8808ad6a650
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::OnCtlColor
Called by the framework when the user changes the parent toolbar color to set the combo box button color.  
  
## Syntax  
  
```  
virtual HBRUSH OnCtlColor(  
   CDC* pDC,  
   UINT nCtlColor  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 The device context that displays the combo box button.  
  
 [in] `nCtlColor`  
 Unused.  
  
## Return Value  
 Handle to the brush that the framework uses to paint the background of the combo box button.  
  
## Remarks  
 This method also sets the combo box button text color.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)