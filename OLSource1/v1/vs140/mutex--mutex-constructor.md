---
title: "Mutex::Mutex Constructor"
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
  - corewrappers/Microsoft::WRL::Wrappers::Mutex::Mutex
dev_langs: 
  - C++
helpviewer_keywords: 
  - Mutex, constructor
ms.assetid: 504afcdc-775a-4c98-a06f-4fb4663eba3f
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Mutex::Mutex Constructor
Initializes a new instance of the Mutex class.  
  
## Syntax  
  
```  
explicit Mutex(  
   HANDLE h  
);  
  
Mutex(  
   _Inout_ Mutex&& h  
);  
```  
  
#### Parameters  
 `h`  
 A handle, or an rvalue-reference to a handle, to a Mutex object.  
  
## Remarks  
 The first constructor initializes a Mutex object from the specified handle. The second constructor initializes a Mutex object from the specified handle, and then moves ownership of the mutex to the current Mutex object.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Mutex Class](../vs140/mutex-class.md)