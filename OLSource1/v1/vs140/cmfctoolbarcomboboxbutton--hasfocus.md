---
title: "CMFCToolBarComboBoxButton::HasFocus"
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
  - HasFocus
  - CMFCToolBarComboBoxButton::HasFocus
  - CMFCToolBarComboBoxButton.HasFocus
dev_langs: 
  - C++
helpviewer_keywords: 
  - HasFocus method
ms.assetid: 585e182c-f08e-42ea-a2ea-bfe9434caae3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarComboBoxButton::HasFocus
Indicates whether the combo box currently has the focus.  
  
## Syntax  
  
```  
virtual BOOL HasFocus() const;  
```  
  
## Return Value  
 `TRUE` if the combo box currently has the focus; otherwise, `FALSE`.  
  
## Remarks  
 This method also returns `TRUE` if any child window of the combo box currently has the focus.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)