---
title: "CMFCVisualManagerOffice2003::OnDrawComboBorder"
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
  - "CMFCVisualManagerOffice2003.OnDrawComboBorder"
  - "OnDrawComboBorder"
  - "CMFCVisualManagerOffice2003::OnDrawComboBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawComboBorder method"
ms.assetid: b6d7e57b-6653-4c33-bd62-f188bb36c6dd
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawComboBorder
The framework calls this method when it draws the border around an instance of a [CMFCToolBarComboBoxButton](../vs140/cmfctoolbarcomboboxbutton-class.md).  
  
## Syntax  
  
```  
virtual void OnDrawComboBorder(  
   CDC* pDC,  
   CRect rect,  
   BOOL bDisabled,  
   BOOL bIsDropped,  
   BOOL bIsHighlighted,  
   CMFCToolBarComboBoxButton* pButton  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context of a combo box button.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the combo box button.  
  
 [in] `bDisabled`  
 A Boolean parameter that indicates whether the combo box button is unavailable.  
  
 [in] `bIsDropped`  
 A Boolean parameter that indicates whether the combo box is dropped down.  
  
 [in] `bIsHighlighted`  
 A Boolean parameter that indicates whether the combo box button is highlighted.  
  
 [in] `pButton`  
 A pointer to a `CMFCToolBarComboBoxButton` object. The framework draws this combo box button.  
  
## Remarks  
 Override this method in your derived visual manager to customize the appearance of the border of the combo box.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)