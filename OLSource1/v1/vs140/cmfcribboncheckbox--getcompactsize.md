---
title: "CMFCRibbonCheckBox::GetCompactSize"
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
  - "CMFCRibbonCheckBox::GetCompactSize"
  - "GetCompactSize"
  - "CMFCRibbonCheckBox.GetCompactSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCompactSize method"
ms.assetid: f2e71ac0-6c0b-4f1a-ae36-6fb783527a6d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCheckBox::GetCompactSize
When overridden, gets the compact size of the checkbox.  
  
## Syntax  
  
```  
virtual CSize GetCompactSize(  
   CDC* pDC  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to the `CDC` associated with the checkbox.  
  
## Return Value  
 Returns a `CSize` object that contains the compact size of the checkbox.  
  
## Remarks  
 If not overridden, returns the intermediate size of the checkbox.  
  
## Requirements  
 **Header:** afxribboncheckbox.h  
  
## See Also  
 [CMFCRibbonCheckBox Class](../vs140/cmfcribboncheckbox-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)