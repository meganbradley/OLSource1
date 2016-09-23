---
title: "CMFCToolBarComboBoxButton::OnClick"
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
  - OnClick
  - CMFCToolBarComboBoxButton.OnClick
  - CMFCToolBarComboBoxButton::OnClick
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnClick method
ms.assetid: 24681043-f5dc-423f-9b82-f7a20b7586ce
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarComboBoxButton::OnClick
Called by the framework when the user clicks the combo box button.  
  
## Syntax  
  
```  
virtual BOOL OnClick(  
   CWnd* pWnd,  
   BOOL bDelay = TRUE  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 Pointer to the parent window of the combo box button.  
  
 [in] `bDelay`  
 Reserved for use in a derived class.  
  
## Return Value  
 `TRUE` if the method handles the event; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)