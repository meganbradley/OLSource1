---
title: "Commonly Overridden Member Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDialog class, members"
  - "OnInitDialog function"
  - "dialog classes, commonly overridden member functions"
  - "OnCancel function"
  - "overriding, dialog class members"
  - "OnOK function"
  - "MFC dialog boxes, overriding member functions"
ms.assetid: 78eb566c-e361-4c86-8db5-c7e2791b249a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Commonly Overridden Member Functions
The following table lists the most likely member functions to override in your `CDialog`-derived class.  
  
### Commonly Overridden Member Functions of Class CDialog  
  
|Member function|Message it responds to|Purpose of the override|  
|---------------------|----------------------------|-----------------------------|  
|`OnInitDialog`|**WM_INITDIALOG**|Initialize the dialog box's controls.|  
|`OnOK`|**BN_CLICKED** for button **IDOK**|Respond when the user clicks the OK button.|  
|`OnCancel`|**BN_CLICKED** for button **IDCANCEL**|Respond when the user clicks the Cancel button.|  
  
 `OnInitDialog`, `OnOK`, and `OnCancel` are virtual functions. To override them, you declare an overriding function in your derived dialog class using the [Properties window](../vs140/properties-window.md).  
  
 `OnInitDialog` is called just before the dialog box is displayed. You must call the default `OnInitDialog` handler from your override — usually as the first action in the handler. By default, `OnInitDialog` returns **TRUE** to indicate that the focus should be set to the first control in the dialog box.  
  
 `OnOK` is typically overridden for modeless but not modal dialog boxes. If you override this handler for a modal dialog box, call the base class version from your override — to ensure that `EndDialog` is called — or call `EndDialog` yourself.  
  
 `OnCancel` is usually overridden for modeless dialog boxes.  
  
 For more information about these member functions, see class [CDialog](../vs140/cdialog-class.md) in the *MFC Reference* and the discussion on [Life Cycle of a Dialog Box](../vs140/life-cycle-of-a-dialog-box.md).  
  
## See Also  
 [Dialog Boxes](../vs140/dialog-boxes.md)   
 [Commonly Added Member Functions](../vs140/commonly-added-member-functions.md)