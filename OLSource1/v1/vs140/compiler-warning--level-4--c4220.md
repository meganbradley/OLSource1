---
title: "Compiler Warning (level 4) C4220"
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
  - C4220
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4220
ms.assetid: aba18868-825f-4763-9af6-3296406a80e4
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 4) C4220
varargs matches remaining parameters  
  
 Under the default Microsoft extensions (/Ze), a pointer to a function matches a pointer to a function with similar, but variable, arguments.  
  
## Example  
  
```  
// C4220.c  
// compile with: /W4  
  
int ( *pFunc1) ( int a, ... );  
int ( *pFunc2) ( int a, int b);  
  
int main()  
{  
   if ( pFunc1 != pFunc2 ) {};  // C4220  
}  
```  
  
 Such pointers do not match under ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)).