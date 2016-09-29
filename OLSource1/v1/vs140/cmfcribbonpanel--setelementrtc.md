---
title: "CMFCRibbonPanel::SetElementRTC"
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
  - "CMFCRibbonPanel::SetElementRTC"
  - "SetElementRTC"
  - "CMFCRibbonPanel.SetElementRTC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetElementRTC method"
ms.assetid: f37087f2-7b4c-430a-a0e4-6bead012b2f9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::SetElementRTC
Adds the ribbon element that is specified by the provided runtime class information to the ribbon panel.  
  
## Syntax  
  
```  
CMFCRibbonBaseElement* SetElementRTC(  
    int nIndex,  
    CRuntimeClass* pRTC   
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 Specifies the zero-based index of the ribbon element to add.  
  
 [in] [out] `pRTC`  
 A pointer to the runtime class information for the ribbon element that is added to the ribbon panel.  
  
## Return Value  
 The ribbon element that was created by using the specified runtime class information.  
  
## Remarks  
 If you want to add a custom element (for example, a color button) to the ribbon panel, you must specify the custom element's runtime class information. The ribbon stores this information, creates the custom element, and replaces an existing element that is located (identified by) the specified command ID. The ribbon then returns a pointer to the newly created element.  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)