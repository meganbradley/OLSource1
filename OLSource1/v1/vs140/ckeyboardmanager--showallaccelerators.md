---
title: "CKeyboardManager::ShowAllAccelerators"
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
  - "CKeyboardManager.ShowAllAccelerators"
  - "CKeyboardManager::ShowAllAccelerators"
  - "ShowAllAccelerators"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowAllAccelerators method"
ms.assetid: 67835c6d-546f-483f-8ead-7537ce7a8bf1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyboardManager::ShowAllAccelerators
Shows all the shortcut keys associated with menu commands.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, all the shortcut keys will be displayed. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, only the first shortcut key will be displayed.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A string to insert between shortcut keys. This delimiter has no effect if only one shortcut key is displayed.  
  
## Remarks  
 By default, if a command has more than one shortcut key associated with it, only the first shortcut key will be shown. This function enables you to list all the shortcut keys associated with all commands.  
  
 The shortcut keys will be listed next to the command in the menu bar. If all the shortcut keys are displayed, the string provided by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will separate individual shortcut keys.  
  
## Requirements  
 **Header:** afxkeyboardmanager.h  
  
## See Also  
 [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)