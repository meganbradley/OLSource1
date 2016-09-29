---
title: "CWinAppEx::GetSectionString"
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
  - "GetSectionString"
  - "CWinAppEx.GetSectionString"
  - "CWinAppEx::GetSectionString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSectionString method"
ms.assetid: 7be6da81-f7e1-42d3-9688-a30deccbbcf3
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetSectionString
Reads string data from the registry.  
  
## Syntax  
  
```  
CString GetSectionString(  
   LPCTSTR lpszSubSection,  
   LPCTSTR lpszEntry,  
   LPCTSTR lpszDefault = _T("")  
);  
```  
  
#### Parameters  
 [in] `lpszSubSection`  
 A string that contains the relative path of a registry key.  
  
 [in] `lpszEntry`  
 A string that contains the value to read.  
  
 [in] `lpszDefault`  
 The default value to return if the specified value does not exist.  
  
## Return Value  
 The string data stored in the specified registry value if the data exists; otherwise `lpszDefault`.  
  
## Remarks  
 This method reads string data written to the registry. Use [CWinAppEx::WriteString](../vs140/cwinappex--writestring.md) and [CWinAppEx::WriteSectionString](../vs140/cwinappex--writesectionstring.md) to write string data to the registry.  
  
 The `lpszSubSection` parameter is not an absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)