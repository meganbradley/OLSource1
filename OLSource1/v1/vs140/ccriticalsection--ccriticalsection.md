---
title: "CCriticalSection::CCriticalSection"
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
  - "CCriticalSection.CCriticalSection"
  - "ATL.CCriticalSection.CCriticalSection"
  - "CCriticalSection::CCriticalSection"
  - "ATL::CCriticalSection::CCriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCriticalSection class, constructor"
ms.assetid: 6a651c16-0a97-4fdf-bf29-e96def3e2425
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCriticalSection::CCriticalSection
Constructs a `CCriticalSection` object.  
  
## Syntax  
  
```  
  
CCriticalSection( );  
```  
  
## Remarks  
 To access or release a `CCriticalSection` object, create a [CSingleLock](../vs140/csinglelock-class.md) object and call its [Lock](../vs140/csinglelock--lock.md) and [Unlock](../vs140/csinglelock--unlock.md) member functions. If the `CCriticalSection` object is being used stand-alone, call its [Unlock](../vs140/ccriticalsection--unlock.md) member function to release it.  
  
 If the constructor fails to allocate the required system memory, a memory exception (of type [CMemoryException](../vs140/cmemoryexception-class.md)) is automatically thrown.  
  
## Example  
 See the example for [CCriticalSection::Lock](../vs140/ccriticalsection--lock.md).  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CCriticalSection Class](../vs140/ccriticalsection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)