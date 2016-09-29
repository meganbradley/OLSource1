---
title: "CWinAppEx::WriteSectionBinary"
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
  - "CWinAppEx.WriteSectionBinary"
  - "CWinAppEx::WriteSectionBinary"
  - "WriteSectionBinary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteSectionBinary method"
ms.assetid: c5dc07df-c273-4f22-a36e-e4a1bbbad654
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::WriteSectionBinary
Writes binary data to a value in the registry.  
  
## Syntax  
  
```  
BOOL WriteSectionBinary(  
   LPCTSTR lpszSubSection,  
   LPCTSTR lpszEntry,  
   LPBYTE pData,  
   UINT nBytes   
);  
```  
  
#### Parameters  
 [in] `lpszSubSection`  
 A string that contains the name of a registry key  
  
 [in] `lpszEntry`  
 A string that contains the value to set.  
  
 [in] `pData`  
 The data to write to the registry.  
  
 [in] `nBytes`  
 The size of `pData` in bytes.  
  
## Return Value  
 `TRUE` if this method is successful; otherwise `FALSE`.  
  
## Remarks  
 The `lpszSubSection` parameter is not the absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
 If the key specified by `lpszEntry` does not exist, this method will create it.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)