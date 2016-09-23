---
title: "Compiler Warning (level 4) C4668"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C4668
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4668
ms.assetid: c6585460-bc4a-4a15-9242-4cbfce53c961
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 4) C4668
'symbol' is not defined as a preprocessor macro, replacing with '0' for 'directives'  
  
 A symbol that was not defined was used with a preprocessor directive. The symbol will evaluate to false. To define a symbol, you can use either the [#define directive](../vs140/sharpdefine-directive--c-c---.md) or [/D](../vs140/-d--preprocessor-definitions-.md) compiler option.  
  
 This warning is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.  
  
## Example  
 The following sample generates C4668:  
  
```  
// C4668.cpp  
// compile with: /W4  
#include <stdio.h>  
  
#pragma warning (default : 4668)   // turn warning on  
  
int main()   
{  
    #if q   // C4668, q is not defined  
        printf_s("defined");  
    #else  
        printf_s("undefined");  
    #endif  
}  
```