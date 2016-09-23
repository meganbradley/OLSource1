---
title: "Compiler Warning (level 1) C4258"
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
  - C4258
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4258
ms.assetid: bbb75e6d-6693-4e62-8ed3-b006a0ec55e3
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4258
'variable' : definition from the for loop is ignored; the definition from the enclosing scope is used"  
  
 Under [/Ze](../vs140/-za---ze--disable-language-extensions-.md) and [/Zc:forScope](../vs140/-zc-forscope--force-conformance-in-for-loop-scope-.md), variables defined in a [for](../vs140/for-statement--c---.md) loop go out of scope after the **for** loop ends. This warning occurs if a variable with the same name as the loop variable, but defined in the enclosing loop, is used again in the scope containing the **for** loop. For example:  
  
```  
// C4258.cpp  
// compile with: /Zc:forScope /W1  
int main()  
{  
   int i;  
   {  
      for (int i =0; i < 1; i++)  
         ;  
      i = 20;   // C4258 i (in for loop) has gone out of scope  
   }  
}  
```