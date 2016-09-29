---
title: "CWinAppEx::GetKeyboardManager"
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
  - "CWinAppEx::GetKeyboardManager"
  - "CWinAppEx.GetKeyboardManager"
  - "GetKeyboardManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetKeyboardManager method"
ms.assetid: cb76f49c-232d-4220-9a1f-55707d5bf2a7
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetKeyboardManager
Returns a pointer to the global [CKeyboardManager](../vs140/ckeyboardmanager-class.md) object.  
  
## Syntax  
  
```  
CKeyboardManager* GetKeyboardManager();  
```  
  
## Return Value  
 A pointer to the global `CKeyboardManager` object.  
  
## Remarks  
 If the keyboard manager is not initialized, this function calls [CWinAppEx::InitKeyboardManager](../vs140/cwinappex--initkeyboardmanager.md) before it returns a pointer.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md)   
 [CWinAppEx::InitKeyboardManager](../vs140/cwinappex--initkeyboardmanager.md)