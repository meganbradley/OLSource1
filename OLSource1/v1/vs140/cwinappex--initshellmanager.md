---
title: "CWinAppEx::InitShellManager"
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
  - CWinAppEx.InitShellManager
  - CWinAppEx::InitShellManager
  - InitShellManager
dev_langs: 
  - C++
helpviewer_keywords: 
  - InitShellManager method
ms.assetid: 74e0ffec-3c8b-4df8-aca7-98f39d72b575
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinAppEx::InitShellManager
Initializes the [CShellManager](../vs140/cshellmanager-class.md) object.  
  
## Syntax  
  
```  
BOOL InitShellManager();  
```  
  
## Return Value  
 Nonzero if the method creates the `CShellManager` object; 0 if the `CShellManager` object already exists.  
  
## Remarks  
 If you call [CWinAppEx::GetShellManager](../vs140/cwinappex--getshellmanager.md), the default implementation of that method calls `InitShellManager`.  
  
 If your application already has a shell manager and you call `InitShellManager`, your application raises an [ASSERT](../vs140/assert--mfc-.md) failure. Therefore, do not call `InitShellManager` if you create a `CShellManager` object directly. If you are not using a custom `CShellManager`, use `GetShellManager` to create a `CShellManager` object.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::GetShellManager](../vs140/cwinappex--getshellmanager.md)   
 [CShellManager Class](../vs140/cshellmanager-class.md)