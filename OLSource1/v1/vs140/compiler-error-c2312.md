---
title: "Compiler Error C2312"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C2312"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2312"
ms.assetid: c8bcfd06-12c1-4323-bb53-ba392d36daa4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2312
'exception1' : is caught by 'exception2' on line number  
  
 Two handlers catch the same exception type.  
  
 The following sample generates C2312:  
  
```  
// C2312.cpp  
// compile with: /EHsc  
#include <eh.h>  
int main() {  
    try {  
        throw "ooops!";  
    }  
    catch( signed int ) {}  
    catch( int ) {}   // C2312  
}  
```