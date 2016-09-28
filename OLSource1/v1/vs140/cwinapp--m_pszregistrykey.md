---
title: "CWinApp::m_pszRegistryKey"
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
  - "CWinApp::m_pszRegistryKey"
  - "CWinApp.m_pszRegistryKey"
  - "m_pszRegistryKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, data members"
  - "m_pszRegistryKey"
ms.assetid: 498ae5af-a88b-4f6c-99e9-628ff6af619d
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_pszRegistryKey
Used to determine where, in the registry or INI file, application profile settings are stored.  
  
## Syntax  
  
```  
  
LPCTSTR m_pszRegistryKey;  
```  
  
## Remarks  
 Normally, this data member is treated as read-only.  
  
-   The value is stored to a registry key. The name for the application profile setting is appended to the following registry key: HKEY_CURRENT_USER/Software/LocalAppWizard-Generated/.  
  
 If you assign a value to `m_pszRegistryKey`, it must be dynamically allocated on the heap. The `CWinApp` destructor calls **free**( ) with this pointer. You many want to use the `_tcsdup`( ) run-time library function to do the allocating. Also, free the memory associated with the current pointer before assigning a new value. For example:  
  
 [!code[NVC_MFCWindowing#61](../vs140/codesnippet/CPP/cwinapp--m_pszregistrykey_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::SetRegistryKey](../vs140/cwinapp--setregistrykey.md)