---
title: "CMFCRibbonComboBox::CMFCRibbonComboBox"
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
  - "CMFCRibbonComboBox.CMFCRibbonComboBox"
  - "CMFCRibbonComboBox"
  - "CMFCRibbonComboBox::CMFCRibbonComboBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonComboBox class, constructor"
ms.assetid: 4a905b1e-06bd-4292-b535-0b31baf94a20
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonComboBox::CMFCRibbonComboBox
Constructs a `CMFCRibbonComboBox` object.  
  
## Syntax  
  
```  
public:  
CMFCRibbonComboBox(  
   UINT nID,  
   BOOL bHasEditBox=TRUE,  
   Int nWidth=-1,  
   LPCTSTR lpszLabel=NULL,  
   Int nImage=-1  
);  
protected:  
CMFCRibbonComboBox();  
```  
  
#### Parameters  
 [in] `nID`  
 The ID of the combo box.  
  
 [in] `bHasEditBox`  
 `TRUE` if you want an edit box within the control; `FALSE` otherwise.  
  
 [in] `nWidth`  
 Width of the combo box in pixels; or -1 for the default width.  
  
 [in] `lpszLabel`  
 The display label of the combo box.  
  
 [in] `nImage`  
 The small image index of the combo box.  
  
## Remarks  
 The default width is 108 pixels.  
  
## Requirements  
 **Header:** afxribboncombobox.h  
  
## See Also  
 [CMFCRibbonComboBox Class](../vs140/cmfcribboncombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)