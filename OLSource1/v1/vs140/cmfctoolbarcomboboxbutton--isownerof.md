---
title: "CMFCToolBarComboBoxButton::IsOwnerOf"
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
  - "IsOwnerOf"
  - "CMFCToolBarComboBoxButton::IsOwnerOf"
  - "CMFCToolBarComboBoxButton.IsOwnerOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsOwnerOf method"
ms.assetid: 29f7bf41-976d-4f53-ac68-2398f1cbb9c8
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::IsOwnerOf
Indicates whether the specified handle is associated with the combo box button, or one of its children.  
  
## Syntax  
  
```  
virtual BOOL IsOwnerOf(  
   HWND hwnd  
);  
```  
  
#### Parameters  
 [in] `hwnd`  
 A window handle.  
  
## Return Value  
 `TRUE` if the handle is assocated with the combo box button, or one of its children; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)