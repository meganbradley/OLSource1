---
title: "CWinAppEx::WriteInt"
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
  - WriteInt
  - CWinAppEx.WriteInt
  - CWinAppEx::WriteInt
dev_langs: 
  - C++
helpviewer_keywords: 
  - WriteInt method
ms.assetid: 78cd0571-9a66-4bfc-b22c-960b5ae2192d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinAppEx::WriteInt
Writes numeric data to the registry.  
  
## Syntax  
  
```  
BOOL WriteInt(  
   LPCTSTR lpszEntry,  
   int nValue   
);  
```  
  
#### Parameters  
 [in] `lpszEntry`  
 A string that contains the name of a registry key.  
  
 [in] `nValue`  
 The data to store.  
  
## Return Value  
 `TRUE` if this method is successful; otherwise `FALSE`.  
  
## Remarks  
 The `lpszEntry` parameter is the name of a registry entry located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
 If the key specified by `lpszEntry` does not exist, this method will create it.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)