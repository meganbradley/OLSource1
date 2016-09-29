---
title: "CWinAppEx::InitMouseManager"
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
  - "InitMouseManager"
  - "CWinAppEx::InitMouseManager"
  - "CWinAppEx.InitMouseManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitMouseManager method"
ms.assetid: 26c58cbe-c29e-45f0-827e-27332c599edc
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::InitMouseManager
Initializes the [CMouseManager](../vs140/cmousemanager-class.md) object.  
  
## Syntax  
  
```  
BOOL InitMouseManager();  
```  
  
## Return Value  
 Nonzero if the method creates the `CMouseManager` object; 0 if the `CMouseManager` object already exists.  
  
## Remarks  
 If you call [CWinAppEx::GetMouseManager](../vs140/cwinappex--getmousemanager.md), the default implementation of that method calls `InitMouseManager`.  
  
 If your application already has a mouse manager and you call `InitMouseManager`, your application will have an [ASSERT](../vs140/assert--mfc-.md) failure. Therefore you should not call `InitMouseManager` if you create a `CMouseManager` object directly. If you are not using a custom `CMouseManager`, you should use `GetMouseManager` to create a `CMouseManager` object.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::GetMouseManager](../vs140/cwinappex--getmousemanager.md)   
 [CMouseManager Class](../vs140/cmousemanager-class.md)