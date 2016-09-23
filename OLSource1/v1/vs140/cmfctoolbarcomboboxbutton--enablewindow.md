---
title: "CMFCToolBarComboBoxButton::EnableWindow"
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
  - CMFCToolBarComboBoxButton.EnableWindow
  - CMFCToolBarComboBoxButton::EnableWindow
  - EnableWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnableWindow method
ms.assetid: 17bac521-471a-4c35-8b7c-27c1272d4006
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarComboBoxButton::EnableWindow
Enables or disables the edit and combo boxes.  
  
## Syntax  
  
```  
virtual void EnableWindow(  
   BOOL bEnable = TRUE  
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable the edit and combo boxes; `FALSE` to disable the edit and combo boxes.  
  
## Remarks  
 When disabled, the controls cannot become active and cannot accept user input.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)