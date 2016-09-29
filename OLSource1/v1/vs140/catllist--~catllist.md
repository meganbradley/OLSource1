---
title: "CAtlList::~CAtlList"
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
  - "CAtlList::~CAtlList"
  - "~CAtlList"
  - "CAtlList.~CAtlList"
  - "ATL.CAtlList.~CAtlList"
  - "ATL::CAtlList::~CAtlList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlList class, destructor"
  - "~CAtlList destructor"
ms.assetid: 04be79d7-1040-4707-a4b2-a1013ba92a5d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::~CAtlList
The destructor.  
  
## Syntax  
  
```  
  
~CAtlList( ) throw( );  
  
```  
  
## Remarks  
 Frees all allocated resources, including a call to [CAtlList::RemoveAll](../vs140/catllist--removeall.md) to remove all elements from the list.  
  
 In debug builds, an assertion failure will occur if the list still contains some elements after the call to `RemoveAll`.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::CAtlList](../vs140/catllist--catllist.md)