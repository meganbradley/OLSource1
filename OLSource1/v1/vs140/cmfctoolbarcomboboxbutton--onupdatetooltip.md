---
title: "CMFCToolBarComboBoxButton::OnUpdateToolTip"
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
  - OnUpdateToolTip
  - CMFCToolBarComboBoxButton.OnUpdateToolTip
  - CMFCToolBarComboBoxButton::OnUpdateToolTip
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnUpdateToolTip method
ms.assetid: de4b639a-8bfc-4dd2-aa0c-5a6e2e5153c2
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarComboBoxButton::OnUpdateToolTip
Called by the framework when the user changes the tool tip for the combo box button.  
  
## Syntax  
  
```  
virtual BOOL OnUpdateToolTip(  
   CWnd* pWndParent,  
   int iButtonIndex,  
   CToolTipCtrl& wndToolTip,  
   CString& str  
);  
```  
  
#### Parameters  
 [in] `pWndParent`  
 Pointer to the parent window for the combo box button.  
  
 [in] `iButtonIndex`  
 ID of the combo box button.  
  
 [in] `wndToolTip`  
 The tool tip to associate with the combo box button.  
  
 [in] `str`  
 The tool tip text.  
  
## Return Value  
 `TRUE` if the method handles the event; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)