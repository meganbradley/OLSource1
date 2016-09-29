---
title: "rename_namespace"
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
  - "rename_namespace"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "rename_namespace attribute"
ms.assetid: 45006d2b-36cd-4bec-98b9-3b8ec45299e3
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rename_namespace
**C++ Specific**  
  
 Renames the namespace that contains the contents of the type library.  
  
## Syntax  
  
```  
rename_namespace("NewName")  
```  
  
#### Parameters  
 `NewName`  
 The new name of the namespace.  
  
## Remarks  
 It takes a single argument, *NewName*, which specifies the new name for the namespace.  
  
 To remove the namespace, use the [no_namespace](../vs140/no_namespace.md) attribute instead.  
  
 **END C++ Specific**  
  
## See Also  
 [#import Attributes](../vs140/sharpimport-attributes--c---.md)   
 [The #import Directive](../vs140/sharpimport-directive--c---.md)