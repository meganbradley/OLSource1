---
title: "CWinAppEx::GetRegistryBase"
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
  - GetRegistryBase
  - CWinAppEx.GetRegistryBase
  - CWinAppEx::GetRegistryBase
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetRegistryBase method
ms.assetid: a6838b0a-73e6-4ed5-b639-89ce2429a51f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinAppEx::GetRegistryBase
Retrieves the default registry path for the application.  
  
## Syntax  
  
```  
LPCTSTR GetRegistryBase();  
```  
  
## Return Value  
 A string that contains the path of the default registry location.  
  
## Remarks  
 All methods of the [CWinAppEx Class](../vs140/cwinappex-class.md) that access the registry start in a default location. Use this method to retrieve a path of the default registry location. Use [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) to change the default registry location.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md)