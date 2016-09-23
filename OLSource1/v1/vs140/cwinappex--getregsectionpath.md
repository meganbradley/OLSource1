---
title: "CWinAppEx::GetRegSectionPath"
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
  - GetRegSectionPath
  - CWinAppEx.GetRegSectionPath
  - CWinAppEx::GetRegSectionPath
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetRegSectionPath method
ms.assetid: c7ca78b8-a308-4791-8c5b-a809d74aac7b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinAppEx::GetRegSectionPath
Creates and returns the absolute path of a registry key.  
  
## Syntax  
  
```  
CString GetRegSectionPath(  
   LPCTSTR szSectionAdd = _T("")  
);  
```  
  
#### Parameters  
 [in] `szSectionAdd`  
 A string that contains the relative path of a registry key.  
  
## Return Value  
 A `CString` that contains the absolute path of a registry key.  
  
## Remarks  
 This method defines the registry key's absolute path by appending the relative path in `szSectionAdd` to the default registry location for your application. To get the default registry key, use the method [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md).  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md)