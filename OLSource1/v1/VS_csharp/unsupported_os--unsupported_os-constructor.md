---
title: "unsupported_os::unsupported_os Constructor"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "concrt/concurrency::unsupported_os::unsupported_os"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unsupported_os, constructor"
ms.assetid: 52daa15a-a90c-41b2-8ef4-9b1c6da962db
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unsupported_os::unsupported_os Constructor
Constructs an `unsupported_os` object.  
  
## Syntax  
  
```  
explicit _CRTIMP unsupported_os(  
   _In_z_ const char * _Message  
) throw();  
  
unsupported_os() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [unsupported_os Class](../VS_csharp/unsupported_os-class.md)