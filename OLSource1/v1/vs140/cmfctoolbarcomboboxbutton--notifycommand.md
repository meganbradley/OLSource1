---
title: "CMFCToolBarComboBoxButton::NotifyCommand"
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
  - "CMFCToolBarComboBoxButton.NotifyCommand"
  - "NotifyCommand"
  - "CMFCToolBarComboBoxButton::NotifyCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NotifyCommand method"
ms.assetid: d686e8c1-c99c-4850-83ac-97d3bc8df992
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::NotifyCommand
Indicates whether the combo box button processes the [WM_COMMAND](win32_WM_COMMAND) message.  
  
## Syntax  
  
```  
virtual BOOL NotifyCommand(  
   int iNotifyCode  
);  
```  
  
#### Parameters  
 [in] `iNotifyCode`  
 The notification message that is associated with the command.  
  
## Return Value  
 Whether the combo box button processes the [WM_COMMAND](win32_WM_COMMAND) message.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)