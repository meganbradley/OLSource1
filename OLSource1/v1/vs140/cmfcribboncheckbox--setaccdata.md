---
title: "CMFCRibbonCheckBox::SetACCData"
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
  - "CMFCRibbonCheckBox::SetACCData"
  - "SetACCData"
  - "CMFCRibbonCheckBox.SetACCData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetACCData method"
ms.assetid: 903b2d1a-346f-40af-80ef-7a9ecb0db9e0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCheckBox::SetACCData
Sets the accessibility data for the checkbox.  
  
## Syntax  
  
```  
virtual BOOL SetACCData(  
   CWnd* pParent,  
   CAccessibilityData& data  
);  
```  
  
#### Parameters  
 `pParent`  
 The parent window of the checkbox.  
  
 `data`  
 The accessibility data for the checkbox.  
  
## Return Value  
 Always returns `TRUE`.  
  
## Remarks  
 By default this method sets the accessibility data for the checkbox and always returns `TRUE`. Override this method to set the accessibility data and return a value that indicates success or failure.  
  
## Requirements  
 **Header:**  
  
## See Also  
 [CMFCRibbonCheckBox Class](../vs140/cmfcribboncheckbox-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)