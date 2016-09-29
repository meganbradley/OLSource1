---
title: "bad_target::bad_target Constructor"
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
  - "concrt/concurrency::bad_target::bad_target"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bad_target, constructor"
ms.assetid: 12b4df2a-3837-44c0-b6e2-bf988ce73a17
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bad_target::bad_target Constructor
Constructs a `bad_target` object.  
  
## Syntax  
  
```  
explicit _CRTIMP bad_target(  
   _In_z_ const char * _Message  
) throw();  
  
bad_target() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [bad_target Class](../vs140/bad_target-class.md)