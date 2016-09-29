---
title: "CWinAppEx::GetSectionInt"
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
  - "GetSectionInt"
  - "CWinAppEx::GetSectionInt"
  - "CWinAppEx.GetSectionInt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSectionInt method"
ms.assetid: e9709ba1-3660-4bab-8317-4c8c613e5ddf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetSectionInt
Reads integer data from the registry.  
  
## Syntax  
  
```  
int GetSectionInt(  
   LPCTSTR lpszSubSection,  
   LPCTSTR lpszEntry,  
   int nDefault = 0  
);  
```  
  
#### Parameters  
 [in] `lpszSubSection`  
 A string that contains the relative path of a registry key.  
  
 [in] `lpszEntry`  
 A string that contains the value to read.  
  
 [in] `nDefault`  
 The default value to return if the specified value does not exist.  
  
## Return Value  
 The integer data that is stored in the specified registry value; `nDefault` if the data does not exist.  
  
## Remarks  
 Use the methods [CWinAppEx::WriteInt](../vs140/cwinappex--writeint.md) and [CWinAppEx::WriteSectionInt](../vs140/cwinappex--writesectionint.md) to write integer data to the registry.  
  
 The `lpszSubSection` parameter is not an absolute path of a registry entry. It is a relative path that is added to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::WriteSectionInt](../vs140/cwinappex--writesectionint.md)   
 [CWinAppEx::WriteInt](../vs140/cwinappex--writeint.md)