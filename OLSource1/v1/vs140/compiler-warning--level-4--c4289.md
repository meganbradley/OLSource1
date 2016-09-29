---
title: "Compiler Warning (level 4) C4289"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4289"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4289"
ms.assetid: 0dbd2863-4cde-4e16-894b-104a2d5fa724
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4289
nonstandard extension used : 'var' : loop control variable declared in the for-loop is used outside the for-loop scope  
  
 When compiling with [/Ze](../vs140/-za---ze--disable-language-extensions-.md) and **/Zc:forScope-**, a variable declared in a [for](../vs140/for-statement--c---.md) loop was used after the **for**-loop scope.  
  
 See [/Zc:forScope](../vs140/-zc-forscope--force-conformance-in-for-loop-scope-.md) for information about how to specify standard behavior in **for** loops with **/Ze**.  
  
 This warning is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.  
  
 The following sample generates C4289:  
  
```  
// C4289.cpp  
// compile with: /W4 /Zc:forScope-  
#pragma warning(default:4289)  
int main() {  
   for (int i = 0 ; ; )   // C4289  
      break;  
   i++;  
}  
```