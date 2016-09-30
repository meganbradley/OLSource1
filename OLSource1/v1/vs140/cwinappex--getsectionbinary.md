---
title: "CWinAppEx::GetSectionBinary"
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
  - "CWinAppEx::GetSectionBinary"
  - "GetSectionBinary"
  - "CWinAppEx.GetSectionBinary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSectionBinary method"
ms.assetid: 832cb675-08d0-4a52-8e37-cbcb9d1f2b05
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetSectionBinary
Reads binary data from the registry.  
  
## Syntax  
  
```  
BOOL GetSectionBinary(  
   LPCTSTR lpszSubSection,  
   LPCTSTR lpszEntry,  
   LPBYTE* ppData,  
   UINT* pBytes   
);  
```  
  
#### Parameters  
 [in] `lpszSubSection`  
 A string that contains the relative path of a registry key.  
  
 [in] `lpszEntry`  
 A string that contains the value to read.  
  
 [out] `ppData`  
 A pointer to the buffer where the method stores the data.  
  
 [out] `pBytes`  
 A pointer to an unsigned integer. The method writes the size of `ppData` to this parameter.  
  
## Return Value  
 `True` if successful; otherwise `false`.  
  
## Remarks  
 This method reads binary data that is written to the registry using the methods [CWinAppEx::WriteBinary](../vs140/cwinappex--writebinary.md) and [CWinAppEx::WriteSectionBinary](../vs140/cwinappex--writesectionbinary.md).  
  
 The `lpszSubSection` parameter is not an absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::WriteBinary](../vs140/cwinappex--writebinary.md)   
 [CWinAppEx::WriteSectionBinary](../vs140/cwinappex--writesectionbinary.md)   
 [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md)