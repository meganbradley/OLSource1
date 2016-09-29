---
title: "CMFCRibbonButton::SetACCData"
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
  - "CMFCRibbonButton.SetACCData"
  - "CMFCRibbonButton::SetACCData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetACCData method"
ms.assetid: 62c057e9-bf5d-42cf-86ae-dfe8db1a1210
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButton::SetACCData
Sets the accessibility data for the ribbon button.  
  
## Syntax  
  
```  
 virtual BOOL SetACCData(  
   CWnd* pParent,  
   CAccessibilityData& data  
);  
  
```  
  
#### Parameters  
 `pParent`  
 The parent window for the ribbon element.  
  
 `data`  
 The accessibility data for the ribbon element.  
  
## Return Value  
 Returns `TRUE` if successful; otherwise FALSE.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
## See Also  
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)