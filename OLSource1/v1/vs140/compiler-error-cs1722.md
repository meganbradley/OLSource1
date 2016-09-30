---
title: "Compiler Error CS1722"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1722"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1722"
ms.assetid: cf698a80-e4c9-46e2-96a0-8b8b5a08fc37
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1722
Base class 'class' must come before any interfaces  
  
 When specifying a class to inherit from and interfaces to implement, the class name must be specified first.  
  
## Example  
 The following sample generates CS1722.  
  
```  
// CS1722.cs  
// compile with: /target:library  
public class A {}  
interface I {}  
  
public class MyClass : I, A {}   // CS1722  
public class MyClass2 : A, I {}   // OK  
```