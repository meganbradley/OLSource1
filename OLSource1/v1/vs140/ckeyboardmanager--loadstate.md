---
title: "CKeyboardManager::LoadState"
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
  - "CKeyboardManager.LoadState"
  - "CKeyboardManager::LoadState"
  - "LoadState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadState method"
ms.assetid: 705d02bc-19fd-4451-84a8-845ddeead02a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyboardManager::LoadState
Loads the shortcut key tables from the Windows registry.  
  
## Syntax  
  
```  
BOOL LoadState(  
   LPCTSTR lpszProfileName = NULL,  
   CFrameWnd* pDefaultFrame = NULL  
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 The registry path where `CKeyboardManager` data is saved.  
  
 [in] `pDefaultFrame`  
 A pointer to a frame window to use as the default window.  
  
## Return Value  
 Nonzero if the state was loaded successfully or 0 otherwise.  
  
## Remarks  
 If the `lpszProfileName` parameter is `NULL`, this method checks the default registry location for `CKeyboardManager` data. The default registry location is specified by the [CWinAppEx Class](../vs140/cwinappex-class.md). The data must be previously written with the method [CKeyboardManager::SaveState](../vs140/ckeyboardmanager--savestate.md).  
  
 If you do not specify a default window, the main frame window of your application will be used.  
  
## Requirements  
 **Header:** afxkeyboardmanager.h  
  
## See Also  
 [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [CKeyboardManager::SaveState](../vs140/ckeyboardmanager--savestate.md)