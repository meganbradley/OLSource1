---
title: "CMFCToolBarComboBoxButton::SetACCData"
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
  - "SetACCData"
  - "CMFCToolBarComboBoxButton::SetACCData"
  - "CMFCToolBarComboBoxButton.SetACCData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetACCData method"
ms.assetid: e1f2f6fa-b73b-4f34-a3ee-08b6ae4630bb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::SetACCData
Populates the specified `CAccessibilityData` object by using accessibility data from the combo box button.  
  
## Syntax  
  
```  
 virtual BOOL SetACCData(  
   CWnd* pParent,  
   CAccessibilityData& data  
);  
```  
  
#### Parameters  
 [in] `pParent`  
 The parent window of the combo box button.  
  
 [out] `data`  
 A `CAccessibilityData` object that receives the accessibility data from the combo box button.  
  
## Return Value  
 `TRUE` if the method was successful; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)