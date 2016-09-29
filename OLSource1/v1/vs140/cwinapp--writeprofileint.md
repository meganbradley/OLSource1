---
title: "CWinApp::WriteProfileInt"
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
  - "WriteProfileInt"
  - "CWinApp.WriteProfileInt"
  - "CWinApp::WriteProfileInt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "profile integers"
  - "registry, writing to"
  - "WriteProfileInt method"
ms.assetid: dc547ec6-242e-47b4-87de-318d1da9bf46
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::WriteProfileInt
Call this member function to write the specified value into the specified section of the application's registry or .INI file.  
  
## Syntax  
  
```  
  
      BOOL WriteProfileInt(  
   LPCTSTR lpszSection,  
   LPCTSTR lpszEntry,  
   int nValue   
);  
```  
  
#### Parameters  
 `lpszSection`  
 Points to a null-terminated string that specifies the section containing the entry. If the section does not exist, it is created. The name of the section is case independent; the string may be any combination of uppercase and lowercase letters.  
  
 `lpszEntry`  
 Points to a null-terminated string that contains the entry into which the value is to be written. If the entry does not exist in the specified section, it is created.  
  
 `nValue`  
 Contains the value to be written.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 This example uses `CWinApp* pApp = AfxGetApp();` to get at the CWinApp class illustrating a way that `WriteProfileString`, `WriteProfileInt`, `GetProfileString`, and `GetProfileInt` can be used from any function in an MFC application.  
  
 [!code[NVC_MFCWindowing#43](../vs140/codesnippet/CPP/cwinapp--writeprofileint_1.cpp)]  
  
 For another example, see the example for [CWinApp::GetProfileInt](../vs140/cwinapp--getprofileint.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::GetProfileInt](../vs140/cwinapp--getprofileint.md)   
 [CWinApp::WriteProfileString](../vs140/cwinapp--writeprofilestring.md)   
 [CWinApp::SetRegistryKey](../vs140/cwinapp--setregistrykey.md)