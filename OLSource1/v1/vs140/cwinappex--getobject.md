---
title: "CWinAppEx::GetObject"
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
  - GetObject
  - CWinAppEx.GetObject
  - CWinAppEx::GetObject
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetObject method
ms.assetid: d31358f4-a665-47f5-914a-26f389314720
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinAppEx::GetObject
Reads [CObject](../vs140/cobject-class.md)-dervied data from the registry.  
  
## Syntax  
  
```  
BOOL GetObject(  
   LPCTSTR lpszEntry,  
   CObject& obj   
);  
```  
  
#### Parameters  
 [in] `lpszEntry`  
 A string that contains the relative path of a registry entry.  
  
 [out] `obj`  
 A reference to a `CObject`. The method uses this reference to store the registry data.  
  
## Return Value  
 Nonzero if the method was successful; otherwise 0.  
  
## Remarks  
 This method reads data from the registry that is derived from `CObject`. To write `CObject` data to the registry, use either [CWinAppEx::WriteObject](../vs140/cwinappex--writeobject.md) or [CWinAppEx::WriteSectionObject](../vs140/cwinappex--writesectionobject.md).  
  
 The `lpszEntry` parameter is the name of a registry entry that is located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::WriteObject](../vs140/cwinappex--writeobject.md)   
 [CWinAppEx::WriteSectionObject](../vs140/cwinappex--writesectionobject.md)