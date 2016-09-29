---
title: "Semaphore::Semaphore Constructor"
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
  - "corewrappers/Microsoft::WRL::Wrappers::Semaphore::Semaphore"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Semaphore, constructor"
ms.assetid: 91c22ae7-181e-460d-ad40-70c3a53b26fd
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Semaphore::Semaphore Constructor
Initializes a new instance of the Semaphore class.  
  
## Syntax  
  
```  
explicit Semaphore(  
   HANDLE h  
);  
  
WRL_NOTHROW Semaphore(  
   _Inout_ Semaphore&& h  
);  
```  
  
#### Parameters  
 `h`  
 A handle or an rvalue-reference to a Semaphore object.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Semaphore Class](../vs140/semaphore-class.md)