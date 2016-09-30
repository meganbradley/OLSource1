---
title: "CMFCRibbonGallery::SetACCData"
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
  - "CMFCRibbonGallery.SetACCData"
  - "SetACCData"
  - "CMFCRibbonGallery::SetACCData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetACCData method"
ms.assetid: f7abaa55-f433-4cb1-8114-de462e5db00d
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonGallery::SetACCData
Populates the specified `CAccessibilityData` object by using accessibility data from the ribbon gallery.  
  
## Syntax  
  
```  
 virtual BOOL SetACCData(  
    CWnd* pParent,   
    CAccessibilityData& data  
);  
```  
  
#### Parameters  
 [in] `pParent`  
 The parent window of the ribbon gallery window.  
  
 [out] `data`  
 A `CAccessibilityData` object that receives the accessibility data from the ribbon gallery.  
  
## Return Value  
  
## Remarks  
 `TRUE` if the method is successful; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxribbonpalettegallery.h  
  
## See Also  
 [CMFCRibbonGallery Class](../vs140/cmfcribbongallery-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)