---
title: "CMFCRibbonBar::SetApplicationButton"
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
  - "SetApplicationButton"
  - "CMFCRibbonBar::SetApplicationButton"
  - "CMFCRibbonBar.SetApplicationButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetApplicationButton method"
ms.assetid: 8568e48a-a878-4c7a-89a4-b7ab795da7f0
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::SetApplicationButton
Assigns an application ribbon button to the ribbon bar.  
  
## Syntax  
  
```  
void SetApplicationButton(  
   CMFCRibbonApplicationButton* pButton,  
   CSize sizeButton   
);  
```  
  
#### Parameters  
 [in] `pButton`  
 A pointer to the application ribbon button.  
  
 [in] `sizeButton`  
 The size of the application ribbon button.  
  
## Remarks  
 The application ribbon button is a large rounded button located at the upper-left corner of Ribbon control.  
  
## Example  
 The following example demonstrates how to use the `SetApplicationButton` method in the `CMFCRibbonBar` class.  
  
 [!code[NVC_MFC_RibbonApp#3](../vs140/codesnippet/CPP/cmfcribbonbar--setapplicationbutton_1.cpp)]  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)