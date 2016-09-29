---
title: "CWinApp::WriteProfileBinary"
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
  - "WriteProfileBinary"
  - "CWinApp::WriteProfileBinary"
  - "CWinApp.WriteProfileBinary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "WriteProfileBinary method"
  - "registry, writing to"
  - "profile binary data"
ms.assetid: 2a081643-9f1e-4a3c-9e84-3eca40be3139
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::WriteProfileBinary
Call this member function to write binary data into the specified section of the application's registry or .INI file.  
  
## Syntax  
  
```  
  
      BOOL WriteProfileBinary(  
   LPCTSTR lpszSection,  
   LPCTSTR lpszEntry,  
   LPBYTE pData,  
   UINT nBytes   
);  
```  
  
#### Parameters  
 `lpszSection`  
 Points to a null-terminated string that specifies the section containing the entry. If the section does not exist, it is created. The name of the section is case independent; the string may be any combination of uppercase and lowercase letters.  
  
 `lpszEntry`  
 Points to a null-terminated string that contains the entry into which the value is to be written. If the entry does not exist in the specified section, it is created.  
  
 `pData`  
 Points to the data to be written.  
  
 `nBytes`  
 Contains the number of bytes to be written.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 This example uses `CWinApp* pApp = AfxGetApp();` to get at the CWinApp class illustrating a way that `WriteProfileBinary` and `GetProfileBinary` can be used from any function in an MFC application.  
  
 [!code[NVC_MFCWindowing#54](../vs140/codesnippet/CPP/cwinapp--writeprofilebinary_1.cpp)]  
  
 For another example, see the example for [CWinApp::GetProfileBinary](../vs140/cwinapp--getprofilebinary.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::WriteProfileInt](../vs140/cwinapp--writeprofileint.md)   
 [CWinApp::WriteProfileString](../vs140/cwinapp--writeprofilestring.md)   
 [CWinApp::SetRegistryKey](../vs140/cwinapp--setregistrykey.md)