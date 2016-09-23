---
title: "CWinAppEx::WriteBinary"
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
  - CWinAppEx::WriteBinary
  - WriteBinary
  - CWinAppEx.WriteBinary
dev_langs: 
  - C++
helpviewer_keywords: 
  - WriteBinary method
ms.assetid: ae423d17-7f03-489d-a4cb-f765d474e56a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinAppEx::WriteBinary
Writes binary data to the registry.  
  
## Syntax  
  
```  
BOOL WriteBinary(  
   LPCTSTR lpszEntry,  
   LPBYTE pData,  
   UINT nBytes   
);  
```  
  
#### Parameters  
 [in] `lpszEntry`  
 A string that contains the name of a registry key.  
  
 [in] `pData`  
 The data to store.  
  
 [in] `nBytes`  
 The size of `pData` in bytes.  
  
## Return Value  
 `TRUE` if this method is successful; otherwise `FALSE`.  
  
## Remarks  
 The `lpszEntry` parameter is the name of a registry entry that is located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
 If the key specified by `lpszEntry` does not exist, this method will create it.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)