---
title: "CWinAppEx::WriteString"
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
  - "WriteString"
  - "CWinAppEx.WriteString"
  - "CWinAppEx::WriteString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteString method"
ms.assetid: 85d753a2-1fea-4bf2-ac45-916bff3dadfc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::WriteString
Writes string data to the registry.  
  
## Syntax  
  
```  
BOOL WriteString(  
   LPCTSTR lpszEntry,  
   LPCTSTR lpszValue   
);  
```  
  
#### Parameters  
 [in] `lpszEntry`  
 A string that contains the name of a registry key.  
  
 [in] `lpszValue`  
 The data to store.  
  
## Return Value  
 `TRUE` if this method is successful; otherwise `FALSE`.  
  
## Remarks  
 The `lpszEntry` parameter is the name of a registry entry located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
 If the key specified by `lspzEntry` does not exist, this method will create it.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)