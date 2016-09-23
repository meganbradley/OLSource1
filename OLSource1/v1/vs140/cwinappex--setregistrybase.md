---
title: "CWinAppEx::SetRegistryBase"
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
  - SetRegistryBase
  - CWinAppEx::SetRegistryBase
  - CWinAppEx.SetRegistryBase
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetRegistryBase method
ms.assetid: ec7a420a-59d7-4f59-a4b3-0c36318a138a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinAppEx::SetRegistryBase
Sets the default registry path for the application.  
  
## Syntax  
  
```  
LPCTSTR SetRegistryBase(  
   LPCTSTR lpszSectionName = NULL  
);  
```  
  
#### Parameters  
 [in] `lpszSectionName`  
 A string that contains the path of a registry key.  
  
## Return Value  
 A string that contains the path of the default registry location.  
  
## Remarks  
 All methods of the [CWinAppEx Class](../vs140/cwinappex-class.md) that access the registry start in a default location. Use this method to change that default registry location. Use [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) to retrieve the default registry location.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md)