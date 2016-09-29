---
title: "inject_statement"
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
  - "inject_statement"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "inject_statement attribute"
ms.assetid: 07d6f0f4-d9fb-4e18-aa62-f235f142ff5e
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# inject_statement
**C++ Specific**  
  
 Inserts its argument as source text into the type-library header.  
  
## Syntax  
  
```  
inject_statement("source_text")  
```  
  
#### Parameters  
 `source_text`  
 Source text to be inserted into the type library header file.  
  
## Remarks  
 The text is placed at the beginning of the namespace declaration that wraps the type-library contents in the header file.  
  
 **END C++ Specific**  
  
## See Also  
 [#import Attributes](../vs140/sharpimport-attributes--c---.md)   
 [The #import Directive](../vs140/sharpimport-directive--c---.md)