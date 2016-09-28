---
title: "CCmdTarget::GetTypeInfoCount"
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
  - "CCmdTarget.GetTypeInfoCount"
  - "GetTypeInfoCount"
  - "CCmdTarget::GetTypeInfoCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdTarget class, attributes"
  - "GetTypeInfoCount method"
ms.assetid: fe71e6d6-4773-43cb-b818-e642d4bbe8fb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::GetTypeInfoCount
Retrieves the number of type information interfaces that an object provides.  
  
## Syntax  
  
```  
  
virtual UINT GetTypeInfoCount( );  
```  
  
## Return Value  
 The number of type information interfaces.  
  
## Remarks  
 This member function basically implements [IDispatch::GetTypeInfoCount](assetId:///da876d53-cb8a-465c-a43e-c0eb272e2a12).  
  
 Derived classes should override this function to return the number of type information interfaces provided (either 0 or 1). If not overridden, **GetTypeInfoCount** returns 0. To override, use the [IMPLEMENT_OLETYPELIB](../vs140/implement_oletypelib.md) macro, which also implements `GetTypeLib` and `GetTypeLibCache`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget::GetTypeLib](../vs140/ccmdtarget--gettypelib.md)   
 [CCmdTarget::GetTypeLibCache](../vs140/ccmdtarget--gettypelibcache.md)