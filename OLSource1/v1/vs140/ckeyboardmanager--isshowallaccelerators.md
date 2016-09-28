---
title: "CKeyboardManager::IsShowAllAccelerators"
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
  - "IsShowAllAccelerators"
  - "CKeyboardManager.IsShowAllAccelerators"
  - "CKeyboardManager::IsShowAllAccelerators"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsShowAllAccelerators method"
ms.assetid: 39530005-0ded-42c8-a580-6d4560296c4c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyboardManager::IsShowAllAccelerators
Indicates whether menus show all the shortcut keys associated with menu commands or only the default shortcut keys.  
  
## Syntax  
  
```  
static BOOL IsShowAllAccelerators();  
```  
  
## Return Value  
 Nonzero if the application lists all the shortcut keys for menu commands; 0 if the application displays only default shortcut keys.  
  
## Remarks  
 The application lists the shortcut keys for menu commands in the menu bar. Use the function [CKeyboardManager::ShowAllAccelerators](../vs140/ckeyboardmanager--showallaccelerators.md) to control whether the application lists all the shortcut keys or just the default shortcut keys.  
  
## Requirements  
 **Header:** afxkeyboardmanager.h  
  
## See Also  
 [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CKeyboardManager::ShowAllAccelerators](../vs140/ckeyboardmanager--showallaccelerators.md)