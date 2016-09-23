---
title: "Compiler Warning (level 3) C4980"
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
  - C4980
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4980
ms.assetid: 2b7a0241-4791-4e29-a4bb-4e6baaeba0d2
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 3) C4980
'keyword' : use of this keyword requires /clr:oldSyntax command line option  
  
 A keyword from a previous version was used. Update your code to use newer syntax, or use [/clr:oldSyntax](../vs140/-clr--common-language-runtime-compilation-.md). For more information about the newer syntax, see [Language Features for Targeting the CLR](../vs140/component-extensions-for-runtime-platforms.md).  
  
 C4980 is a warning that is always issued as an error.  Use **/wd** to turn the warning off.  See [/w, /Wn, /WX, /Wall, /wln, /wdn, /wen, /won (Warning Level)](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md) for more information.  
  
 The following sample generates C4980:  
  
```  
// C4980.cpp  
// compile with: /clr  
int main() {  
   int x1 = 0;  
   int^ px = __box(x1);   // C4980  
   int^ px2 = x1;   // OK  
}  
```