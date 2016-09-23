---
title: "CMFCVisualManagerOffice2003::OnDrawComboDropButton"
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
  - CMFCVisualManagerOffice2003::OnDrawComboDropButton
  - CMFCVisualManagerOffice2003.OnDrawComboDropButton
  - OnDrawComboDropButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawComboDropButton method
ms.assetid: 4ec3fb17-9afd-4647-bb3e-3113552dcb99
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManagerOffice2003::OnDrawComboDropButton
The framework calls this method when it draws the drop button of a [CMFCToolBarComboBoxButton](../vs140/cmfctoolbarcomboboxbutton-class.md).  
  
## Syntax  
  
```  
virtual void OnDrawComboDropButton(  
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
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the drop button.  
  
 [in] `bDisabled`  
 A Boolean parameter that indicates whether the drop button is unavailable.  
  
 [in] `bIsDropped`  
 A Boolean parameter that indicates whether the combo box is dropped down.  
  
 [in] `bIsHighlighted`  
 A Boolean parameter that indicates whether the drop button is highlighted.  
  
 [in] `pButton`  
 A pointer to a `CMFCToolBarComboBoxButton` object. The framework draws the drop button for this combo box button  
  
## Remarks  
 Override this method in your derived visual manager to customize the appearance of the drop button of a combo box button.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)