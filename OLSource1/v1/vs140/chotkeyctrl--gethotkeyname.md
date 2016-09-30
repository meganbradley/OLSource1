---
title: "CHotKeyCtrl::GetHotKeyName"
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
  - "CHotKeyCtrl::GetHotKeyName"
  - "CHotKeyCtrl.GetHotKeyName"
  - "GetHotKeyName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHotKeyName method"
ms.assetid: 2c71c77c-28f0-4c77-ae08-38c2ac663b71
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHotKeyCtrl::GetHotKeyName
Call this member function to get the localized name of the hot key.  
  
## Syntax  
  
```  
  
CString GetHotKeyName( ) const;  
  
```  
  
## Return Value  
 The localized name of the currently selected hot key. If there is no selected hot key, `GetHotKeyName` returns an empty string.  
  
## Remarks  
 The name that this member function returns comes from the keyboard driver. You can install a non-localized keyboard driver in a localized version of Windows, and vice versa.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHotKeyCtrl Class](../vs140/chotkeyctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHotKeyCtrl::GetKeyName](../vs140/chotkeyctrl--getkeyname.md)