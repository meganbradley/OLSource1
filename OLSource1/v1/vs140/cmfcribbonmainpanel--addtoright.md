---
title: "CMFCRibbonMainPanel::AddToRight"
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
  - "CMFCRibbonMainPanel::AddToRight"
  - "AddToRight"
  - "CMFCRibbonMainPanel.AddToRight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToRight method"
ms.assetid: 0392e771-16e4-4af4-900b-961a37e220fa
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonMainPanel::AddToRight
Adds a ribbon element to the right pane of the application button panel.  
  
## Syntax  
  
```  
void AddToRight(  
    CMFCRibbonBaseElement* pElem,  
    int nWidth = 300   
);  
```  
  
#### Parameters  
 `pElem`  
 A pointer to a ribbon element to be added to the right side of the main panel.  
  
 `nWidth`  
 Specifies the width, in pixels, of the right panel.  
  
## Remarks  
 Use this function to add a ribbon element to the right panel. The right panel typically displays the recent files list, but you can add any other ribbon element here.  
  
## Requirements  
 **Header:** afxRibbonMainPanel.h  
  
## See Also  
 [CMFCRibbonMainPanel Class](../vs140/cmfcribbonmainpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)