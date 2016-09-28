---
title: "Compiler Error CS0709"
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
  - "CS0709"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0709"
ms.assetid: 91040f55-a060-4cc3-b830-f6b771af28d7
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0709
'derived class': cannot derive from static class 'base class'  
  
 A static class cannot be instantiated or derived from. That is, a static class cannot be a base class of any other class.  
  
## Example  
 The following sample generates CS0709.  
  
```  
// CS0709.cs  
// compile with: /target:library  
public static class Base {}  
public class Derived : Base {}   // CS0709  
```