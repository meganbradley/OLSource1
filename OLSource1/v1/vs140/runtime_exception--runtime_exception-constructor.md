---
title: "runtime_exception::runtime_exception Constructor"
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
  - "amprt/Concurrency::runtime_exception::runtime_exception"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "runtime_exception, constructor"
ms.assetid: 192dce0f-36e4-40e8-8f1b-42910b89bb6b
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# runtime_exception::runtime_exception Constructor
Initializes a new instance of the [runtime_exception](../vs140/runtime_exception-class.md) class.  
  
## Syntax  
  
```  
runtime_exception(  
   const char * _Message,  
   HRESULT _Hresult  
) throw();  
  
explicit runtime_exception(  
   HRESULT _Hresult  
) throw();  
  
runtime_exception(  
   const runtime_exception &_Other  
) throw();  
```  
  
#### Parameters  
 `_Message`  
 A description of the error that caused the exception.  
  
 `_Hresult`  
 The HRESULT of error that caused the exception.  
  
 `_Other`  
 The `runtime_exception` object to copy.  
  
## Return Value  
 The `runtime_exception` object.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [runtime_exception Class](../vs140/runtime_exception-class.md)