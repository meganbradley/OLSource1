---
title: "CMFCRibbonPanel::CMFCRibbonPanel"
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
  - "CMFCRibbonPanel"
  - "CMFCRibbonPanel.CMFCRibbonPanel"
  - "CMFCRibbonPanel::CMFCRibbonPanel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonPanel class, constructor"
ms.assetid: 032c39ae-e7d3-4522-b7a2-a977858c5761
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::CMFCRibbonPanel
Constructs and initializes a [CMFCRibbonPanel](../vs140/cmfcribbonpanel-class.md) object.  
  
## Syntax  
  
```  
CMFCRibbonPanel(  
    LPCTSTR lpszName = NULL,  
    HICON hIcon = NULL  
);  
CMFCRibbonPanel(  
    CMFCRibbonGallery* pPaletteButton  
);  
```  
  
#### Parameters  
 [in] `lpszName`  
 The name of the ribbon panel.  
  
 [in] `hIcon`  
 Handle to the icon of the default button for the ribbon panel.  
  
 [in] `pPaletteButton`  
 Pointer to a ribbon gallery for the ribbon panel.  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)