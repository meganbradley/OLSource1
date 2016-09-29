---
title: "COleControlContainer::IsDlgButtonChecked"
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
  - "COleControlContainer::IsDlgButtonChecked"
  - "COleControlContainer.IsDlgButtonChecked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, overridables"
  - "IsDlgButtonChecked method"
ms.assetid: 683aae76-bfe1-4ee9-8164-523ac6697bb9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::IsDlgButtonChecked
Determines the state of the specified button.  
  
## Syntax  
  
```  
  
      virtual UINT IsDlgButtonChecked(  
   int nIDButton   
) const;  
```  
  
#### Parameters  
 `nIDButton`  
 The identifier of the button control.  
  
## Return Value  
 The return value, from a button created with the **BS_AUTOCHECKBOX**, **BS_AUTORADIOBUTTON**, **BS_AUTO3STATE**, **BS_CHECKBOX**, **BS_RADIOBUTTON**, or **BS_3STATE** style. Can be one of the following:  
  
-   **BST_CHECKED** Button is checked.  
  
-   **BST_INDETERMINATE** Button is grayed, indicating an indeterminate state (applies only if the button has the **BS_3STATE** or **BS_AUTO3STATE** style).  
  
-   **BST_UNCHECKED** Button is cleared.  
  
## Remarks  
 If the button is a three-state control, the member function determines whether it is dimmed, checked, or neither.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)