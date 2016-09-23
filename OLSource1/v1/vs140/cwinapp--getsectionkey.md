---
title: "CWinApp::GetSectionKey"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - afxwin/CWinApp::GetSectionKey
  - GetSectionKey
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSectionKey
ms.assetid: 591f75b6-6393-41ad-b891-9791e9ee31ae
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::GetSectionKey
Returns the key for HKEY_CURRENT_USER\\"Software"\RegistryKey\AppName\lpszSection.  
  
## Syntax  
  
```  
HKEY GetSectionKey(  
   LPCTSTR lpszSection,  
   CAtlTransactionManager* pTM = NULL  
);  
```  
  
#### Parameters  
 `lpszSection`  
 The name of the key to be obtained.  
  
 `pTM`  
 Pointer to a `CAtlTransactionManager` object.  
  
## Return Value  
 Section key if the function succeeds; otherwise `NULL`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)