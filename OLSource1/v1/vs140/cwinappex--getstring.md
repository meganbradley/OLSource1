---
title: "CWinAppEx::GetString"
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
  - "CWinAppEx.GetString"
  - "CWinAppEx::GetString"
  - "GetString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetString method"
ms.assetid: dda5e63f-4da7-4e3f-bc03-b2763d7100a0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetString
Reads string data from a specified registry key.  
  
## Syntax  
  
```  
CString GetString(  
   LPCTSTR lpszEntry,  
   LPCTSTR lpzDefault= _T("")   
);  
```  
  
#### Parameters  
 [in] `lpszEntry`  
 A string that contains the name of a registry key  
  
 [in] `lpzDefault`  
 The default value that the method returns if the specified registry entry does not exist.  
  
## Return Value  
 The string data stored in the registry if successful; `lpszDefault` otherwise.  
  
## Remarks  
 This method reads string data written to the registry. To write data to the registry, use the methods [CWinAppEx::WriteString](../vs140/cwinappex--writestring.md) or [CWinAppEx::WriteSectionString](../vs140/cwinappex--writesectionstring.md).  
  
 The `lpszEntry` parameter is the name of a registry entry located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::WriteString](../vs140/cwinappex--writestring.md)   
 [CWinAppEx::WriteSectionString](../vs140/cwinappex--writesectionstring.md)