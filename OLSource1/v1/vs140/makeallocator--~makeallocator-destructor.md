---
title: "MakeAllocator::~MakeAllocator Destructor"
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
  - "implements/Microsoft::WRL::Details::MakeAllocator::~MakeAllocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~MakeAllocator, destructor"
ms.assetid: f1299c5f-cc6b-4d4e-85d4-aee1be0e2b0a
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MakeAllocator::~MakeAllocator Destructor
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
~MakeAllocator();  
```  
  
## Remarks  
 Deinitializes the current instance of the MakeAllocator class.  
  
 This destructor also deletes the underlying allocated memory if necessary.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [MakeAllocator Class](../vs140/makeallocator-class.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)