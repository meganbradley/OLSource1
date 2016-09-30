---
title: "Compiler Warning (level 4) C4131"
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
  - "C4131"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4131"
ms.assetid: 7903b3e1-454f-4be2-aa9b-230992f96a2d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4131
'function' : uses old-style declarator  
  
 The specified function declaration is not in prototype form.  
  
 Old-style function declarations should be converted to prototype form.  
  
 The following example shows an old-style function declaration:  
  
```  
// C4131.c  
// compile with: /W4 /c  
void addrec( name, id ) // C4131 expected  
char *name;  
int id;  
{ }  
```  
  
 The following example shows a prototype form:  
  
```  
void addrec( char *name, int id )  
{ }  
```