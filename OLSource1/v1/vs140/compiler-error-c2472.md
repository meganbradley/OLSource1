---
title: "Compiler Error C2472"
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
  - "C2472"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2472"
ms.assetid: 3b36bcdc-2ba5-4357-ab88-7545ba0551cd
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2472
'function' cannot be generated in managed code: 'message'; compile with /clr to generate a mixed image  
  
 This error will occur when types not supported by managed code are used within a pure common language runtime (CLR) environment. Compile with **/clr** to resolve the error.  
  
## Example  
 The following sample generates C2472.  
  
```  
// C2472.cpp  
// compile with: /clr:pure  
// C2472 expected  
  
#include <cstdlib>  
  
int main()  
{  
   int * __ptr32 p32;  
   int * __ptr64 p64;  
  
   p32 = (int * __ptr32)malloc(4);  
   p64 = p32;  
}  
```  
  
## See Also  
 [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md)