---
title: "__noop"
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
  - "__noop_cpp"
  - "__noop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__noop keyword [C++]"
ms.assetid: 81ac6e97-7bf8-496b-b3c4-fd02837573e5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __noop
**Microsoft Specific**  
  
 The `__noop` intrinsic specifies that a function should be ignored and the argument list be parsed but no code be generated for the arguments. It is intended for use in global debug functions that take a variable number of arguments.  
  
 The compiler converts the `__noop` intrinsic to 0 at compile time.  
  
## Example  
 The following code shows how you could use `__noop`.  
  
```  
// compiler_intrinsics__noop.cpp  
// compile with or without /DDEBUG  
#include <stdio.h>  
  
#if DEBUG  
   #define PRINT   printf_s  
#else  
   #define PRINT   __noop  
#endif  
  
int main() {  
   PRINT("\nhello\n");  
}  
```  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Keywords](../vs140/keywords--c---.md)