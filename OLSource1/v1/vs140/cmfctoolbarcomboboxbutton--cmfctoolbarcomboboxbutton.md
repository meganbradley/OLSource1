---
title: "CMFCToolBarComboBoxButton::CMFCToolBarComboBoxButton"
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
  - "CMFCToolBarComboBoxButton::CMFCToolBarComboBoxButton"
  - "CMFCToolBarComboBoxButton.CMFCToolBarComboBoxButton"
  - "CMFCToolBarComboBoxButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarComboBoxButton class, constructor"
ms.assetid: 3c296d8f-8fe3-48a2-8fa3-4b032805fac3
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::CMFCToolBarComboBoxButton
Constructs a [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md) object.  
  
## Syntax  
  
```  
CMFCToolBarComboBoxButton(  
   UINT uiID,  
   int iImage,  
   DWORD dwStyle=CBS_DROPDOWNLIST,  
   int iWidth=0   
);  
```  
  
#### Parameters  
 [in] `uiID`  
 The command ID of the new button.  
  
 [in] `iImage`  
 The image index of the image associated with the new button.  
  
 [in] `dwStyle`  
 The style of the new button.  
  
 [in] `iWidth`  
 The width, in pixels, of the new button.  
  
## Remarks  
 The default width is 150 pixels.  
  
 For a list of toolbar button styles see [ToolBar Control Styles](../vs140/toolbar-control-styles.md)  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)