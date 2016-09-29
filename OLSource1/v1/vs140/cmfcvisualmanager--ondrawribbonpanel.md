---
title: "CMFCVisualManager::OnDrawRibbonPanel"
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
  - "CMFCVisualManager.OnDrawRibbonPanel"
  - "OnDrawRibbonPanel"
  - "CMFCVisualManager::OnDrawRibbonPanel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonPanel method"
ms.assetid: 6801a884-0c9c-4829-8424-d25c61336c4d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonPanel
The framework calls this method when it draws a [CMFCRibbonPanel](../vs140/cmfcribbonpanel-class.md) object.  
  
## Syntax  
  
```  
virtual COLORREF OnDrawRibbonPanel(  
   CDC* pDC,  
   CMFCRibbonPanel* pPanel,  
   CRect rectPanel,  
   CRect rectCaption  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pPanel`  
 A pointer to a `CMFCRibbonPanel` object. The framework draws this ribbon panel.  
  
 [in] `rectPanel`  
 A rectangle that specifies the boundaries of the panel.  
  
 [in] `rectCaption`  
 A rectangle that specifies the boundaries of the caption for the panel.  
  
## Return Value  
 The color of text on the ribbon panel.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of a ribbon panel.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)