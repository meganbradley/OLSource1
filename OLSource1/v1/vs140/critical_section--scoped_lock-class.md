---
title: "critical_section::scoped_lock Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - concrt/concurrency::critical_section::scoped_lock
dev_langs: 
  - C++
helpviewer_keywords: 
  - scoped_lock class
ms.assetid: 9564437e-8df7-4eb7-b60c-842c27ac4bb6
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# critical_section::scoped_lock Class
An exception safe RAII wrapper for a `critical_section` object.  
  
## Syntax  
  
```  
class scoped_lock;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[critical_section::scoped_lock::scoped_lock Constructor](../vs140/critical_section--scoped_lock--scoped_lock-constructor.md)|Constructs a `scoped_lock` object and acquires the `critical_section` object passed in the `_Critical_section` parameter. If the critical section is held by another thread, this call will block.|  
|[critical_section::scoped_lock::~scoped_lock Destructor](../vs140/critical_section--scoped_lock--~scoped_lock-destructor.md)|Destroys a `scoped_lock` object and releases the critical section supplied in its constructor.|  
  
## Inheritance Hierarchy  
 `scoped_lock`  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [critical_section Class](../vs140/critical_section-class.md)