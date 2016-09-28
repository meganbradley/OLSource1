---
title: "raw_dispinterfaces"
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
  - "raw_dispinterfaces"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "raw_dispinterfaces attribute"
ms.assetid: f762864d-29bf-445b-825a-ba7b29a95409
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# raw_dispinterfaces
**C++ Specific**  
  
 Tells the compiler to generate low-level wrapper functions for dispinterface methods and properties that call **IDispatch::Invoke** and return the `HRESULT` error code.  
  
## Syntax  
  
```  
raw_dispinterfaces  
```  
  
## Remarks  
 If this attribute is not specified, only high-level wrappers are generated, which throw C++ exceptions in case of failure.  
  
 **END C++ Specific**  
  
## See Also  
 [#import Attributes](../vs140/sharpimport-attributes--c---.md)   
 [The #import Directive](../vs140/sharpimport-directive--c---.md)