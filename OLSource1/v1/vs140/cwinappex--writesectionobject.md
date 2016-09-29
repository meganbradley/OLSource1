---
title: "CWinAppEx::WriteSectionObject"
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
  - "WriteSectionObject"
  - "CWinAppEx.WriteSectionObject"
  - "CWinAppEx::WriteSectionObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteSectionObject method"
ms.assetid: 3a8b599e-414e-4e24-b3f3-2297d4a5600e
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::WriteSectionObject
Writes data derived from the [CObject Class](../vs140/cobject-class.md) to a specific registry value.  
  
## Syntax  
  
```  
BOOL WriteSectionObject(  
   LPCTSTR lpszSubSection,  
   LPCTSTR lpszEntry,  
   CObject& obj   
);  
```  
  
#### Parameters  
 [in] `lpszSubSection`  
 A string that contains the name of a registry key.  
  
 [in] `lpszEntry`  
 A string that contains the name of the value to set.  
  
 [in] `obj`  
 The data to store.  
  
## Return Value  
 `TRUE` if this method is successful; otherwise `FALSE`.  
  
## Remarks  
 The `lpszSubSection` parameter is not an absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md), respectively.  
  
 If the value specified by `lpszEntry` does not exist under the registry key specified by `lpszSubSection`, this method will create that value.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)