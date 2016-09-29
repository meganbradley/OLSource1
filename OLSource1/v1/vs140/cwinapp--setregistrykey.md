---
title: "CWinApp::SetRegistryKey"
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
  - "CWinApp::SetRegistryKey"
  - "SetRegistryKey"
  - "CWinApp.SetRegistryKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRegistryKey method"
  - "CWinApp class, initialization"
  - "registry, writing to"
ms.assetid: a4df20ef-2e90-4040-a06d-0cfb27e34d70
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::SetRegistryKey
Causes application settings to be stored in the registry instead of INI files.  
  
## Syntax  
  
```  
  
      void SetRegistryKey(  
   LPCTSTR lpszRegistryKey   
);  
void SetRegistryKey(  
   UINT nIDRegistryKey   
);  
```  
  
#### Parameters  
 *lpszRegistryKey*  
 Pointer to a string containing the name of the key.  
  
 *nIDRegistryKey*  
 ID of a string resource containing the name of the registry key.  
  
## Remarks  
 This function sets *m_pszRegistryKey*, which is then used by the `GetProfileInt`, `GetProfileString`, `WriteProfileInt`, and `WriteProfileString` member functions of `CWinApp`. If this function has been called, the list of most recently-used (MRU) files is also stored in the registry. The registry key is usually the name of a company. It is stored in a key of the following form: HKEY_CURRENT_USER\Software\\\<company name>\\\<application name>\\\<section name>\\\<value name>.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)   
 [CWinApp::GetProfileInt](../vs140/cwinapp--getprofileint.md)   
 [CWinApp::GetProfileString](../vs140/cwinapp--getprofilestring.md)   
 [CWinApp::WriteProfileInt](../vs140/cwinapp--writeprofileint.md)   
 [CWinApp::WriteProfileString](../vs140/cwinapp--writeprofilestring.md)