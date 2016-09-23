---
title: "CMFCRibbonPanel::ShowPopup"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCRibbonPanel.ShowPopup
  - ShowPopup
  - CMFCRibbonPanel::ShowPopup
dev_langs: 
  - C++
helpviewer_keywords: 
  - ShowPopup method
ms.assetid: 27365b42-4f11-47a3-b7a4-d8a0c97a8e1f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonPanel::ShowPopup
Creates and displays a pop-up menu for the ribbon panel.  
  
## Syntax  
  
```  
CMFCRibbonPanelMenu* ShowPopup(  
   CMFCRibbonDefaultPanelButton* pButton = NULL  
);  
```  
  
#### Parameters  
 [in] `pButton`  
 Pointer to the default button for the ribbon panel.  
  
## Return Value  
 Pointer to the pop-up menu for the ribbon panel if the method was successful; otherwise `NULL`.  
  
## Remarks  
 The pop-up menu for the ribbon panel is only available when the display of the ribbon panel is collapsed.  
  
## Requirements  
 **Header:** afxribbonpanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)