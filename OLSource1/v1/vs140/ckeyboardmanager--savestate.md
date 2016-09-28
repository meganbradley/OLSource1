---
title: "CKeyboardManager::SaveState"
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
  - "CKeyboardManager::SaveState"
  - "CKeyboardManager.SaveState"
  - "SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: 564ad32f-59e6-4c43-9d66-110e051bfc15
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyboardManager::SaveState
Saves the shortcut key tables to the Windows registry.  
  
## Syntax  
  
```  
BOOL SaveState(  
   LPCTSTR lpszProfileName = NULL,  
   CFrameWnd* pDefaultFrame = NULL  
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 The registry path for saving the `CKeyboardManager` state.  
  
 [in] `pDefaultFrame`  
 A pointer to a frame window that becomes the default window.  
  
## Return Value  
 Nonzero if the keyboard manager state was saved successfully, or 0 otherwise.  
  
## Remarks  
 If the `lpszProfileName` parameter is `NULL`, this method will write the `CKeyboardManager` state to the default location specified by the [CWinAppEx Class](../vs140/cwinappex-class.md). If you specify a location, you can load the data later using the method [CKeyboardManager::LoadState](../vs140/ckeyboardmanager--loadstate.md).  
  
 If you do not specify a default window, the main frame window will be used as the default window.  
  
## Requirements  
 **Header:** afxkeyboardmanager.h  
  
## See Also  
 [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [CKeyboardManager::LoadState](../vs140/ckeyboardmanager--loadstate.md)