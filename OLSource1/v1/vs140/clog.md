---
title: "clog"
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
  - "std.clog"
  - "iostream/std::clog"
  - "clog"
  - "std::clog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "console, text"
  - "text output"
  - "console, writing to"
  - "text, formatting"
  - "printing [C++], printing to console"
  - "console, writing formatted text to"
  - "clog function"
ms.assetid: e7463828-3098-419c-bba1-969448774c34
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# clog
Specifies the `clog` global stream.  
  
## Syntax  
  
```  
extern ostream clog;  
```  
  
## Return Value  
 An [ostream](../vs140/ostream.md) object.  
  
## Remarks  
 The object controls buffered insertions to the standard error output as a byte stream.  
  
## Example  
 See [cerr](../vs140/cerr.md) for an example of using `clog`.  
  
## Requirements  
 **Header:** \<iostream>  
  
 **Namespace:** std  
  
## See Also  
 [ostream](../vs140/ostream.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)