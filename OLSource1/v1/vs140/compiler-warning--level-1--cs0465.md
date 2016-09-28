---
title: "Compiler Warning (level 1) CS0465"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0465"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0465"
ms.assetid: 3d36faae-147f-4173-b164-af953fd86eea
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS0465
Introducing a 'Finalize' method can interfere with destructor invocation. Did you intend to declare a destructor?  
  
 This warning occurs when you create a class with a method whose signature is `public virtual void Finalize`.  
  
 If such a class is used as a base class and if the deriving class defines a destructor, the destructor will override the base class `Finalize` method, not <xref:System.Object.Finalize*>.  
  
## Example  
 The following sample generates CS0465.  
  
```  
// CS0465.cs  
// compile with: /target:library  
class A  
{  
   public virtual void Finalize() {}   // CS0465  
}  
  
// OK  
class B  
{  
   ~B() {}  
}  
```