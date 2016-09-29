---
title: "CCmdTarget::GetTypeLibCache"
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
  - "CCmdTarget.GetTypeLibCache"
  - "CCmdTarget::GetTypeLibCache"
  - "GetTypeLibCache"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdTarget class, attributes"
  - "GetTypeLibCache method"
ms.assetid: 2a7525eb-5b5d-4cad-8f62-fca2d6383b6e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::GetTypeLibCache
Gets the type library cache.  
  
## Syntax  
  
```  
  
virtual CTypeLibCache* GetTypeLibCache( );  
```  
  
## Return Value  
 A pointer to a **CTypeLibCache** object.  
  
## Remarks  
 Derived classes should override this member function (if not overridden, **GetTypeLibCache** returns NULL). Use the [IMPLEMENT_OLETYPELIB](../vs140/implement_oletypelib.md) macro, which also implements `GetTypeInfoCount` and `GetTypeLib`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget::GetTypeInfoCount](../vs140/ccmdtarget--gettypeinfocount.md)   
 [CCmdTarget::GetTypeLib](../vs140/ccmdtarget--gettypelib.md)