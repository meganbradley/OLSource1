---
title: "Compiler Error C3382"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C3382
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3382
ms.assetid: a7603abd-ac4e-4ae6-a02b-3bdc6d1908a6
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3382
'sizeof' is not supported with /clr:safe  
  
 The output file of a **/clr:safe** compilation is a file that is verifiably type safe, and sizeof is not supported because the return value of the sizeof operator is size_t, whose size varies depending on the operating system.  
  
 For more information, see,  
  
-   [sizeof Operator](../vs140/sizeof-operator.md)  
  
-   [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md)  
  
-   [Common 64-bit Migration Issues](../vs140/common-visual-c---64-bit-migration-issues.md)  
  
## Example  
 The following sample generates C3382.  
  
```  
// C3382.cpp  
// compile with: /clr:safe  
int main() {  
   sizeof( char );   // C3382  
}  
```