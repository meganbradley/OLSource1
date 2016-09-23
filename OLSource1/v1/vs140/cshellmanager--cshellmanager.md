---
title: "CShellManager::CShellManager"
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
  - CShellManager.CShellManager
  - CShellManager::CShellManager
  - CShellManager
dev_langs: 
  - C++
helpviewer_keywords: 
  - CShellManager class, constructor
ms.assetid: d111d79a-fee9-4532-a190-790620ef6b18
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CShellManager::CShellManager
Constructs a `CShellManager` object.  
  
## Syntax  
  
```  
CShellManager();  
```  
  
## Remarks  
 In most cases, you do not have to create a `CShellManager` directly. By default, the framework creates one for you. To get a pointer to the `CShellManager`, call [CWinAppEx::GetShellManager](../vs140/cwinappex--getshellmanager.md). If you do create a `CShellManager` manually, you must initialize it with the method [CWinAppEx::InitShellManager](../vs140/cwinappex--initshellmanager.md).  
  
## Requirements  
 **Header:** afxshellmanager.h  
  
## See Also  
 [CShellManager Class](../vs140/cshellmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::GetShellManager](../vs140/cwinappex--getshellmanager.md)   
 [CWinAppEx::InitShellManager](../vs140/cwinappex--initshellmanager.md)