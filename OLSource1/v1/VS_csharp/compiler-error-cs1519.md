---
title: "Compiler Error CS1519"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1519"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1519"
ms.assetid: 186cef8e-c6c7-49aa-8b43-f6c2cb628414
caps.latest.revision: 10
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Compiler Error CS1519
Invalid token 'token' in class, struct, or interface member declaration  
  
 This error is generated whenever a token is encountered in a location where it does not belong. A *token* is a keyword; an identifier (the name of a class, struct, method, and so on); a string, character, or numeric literal value such as 108, "Hello", or 'A'; or an operator or punctuator such as `==` or `;`.  
  
 Any [class](../VS_csharp/class--csharp-reference-.md), struct, or interface member declaration that contains invalid modifiers before the type will generate this error. To fix the error, remove the invalid modifiers.  
  
 The following sample generates CS1519 in five places because tokens are placed in locations where they are not valid:  
  
```c#  
// CS1519.cs  
// Generates CS1519 because a class name cannot be a number:  
class Test 42   
{  
// Generates CS1519 because of 'j' following 'I'  
// with no comma between them:  
    int i j;   
// Generates CS1519 because of "checked" on void method:  
    checked void f4();     
  
// Generates CS1519 because of "num":  
    void f5(int a num){}        
  
// Generates CS1519 because of namespace inside class:  
    namespace;             
  
}  
```  
  
## See Also  
 [Classes](../VS_csharp/classes--csharp-programming-guide-.md)   
 [Structs](../VS_csharp/structs--csharp-programming-guide-.md)   
 [Interfaces](../VS_csharp/interfaces--csharp-programming-guide-.md)   
 [Methods](../VS_csharp/methods--csharp-programming-guide-.md)