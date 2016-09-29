---
title: "Compiler Warning C4694"
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
  - "C4694"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4694"
ms.assetid: 5ca122bb-34f3-43ee-a21f-95802cd515f7
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4694
'class_1': a sealed abstract class cannot have a base-class 'base_class'  
  
 An abstract and sealed class cannot inherit from a reference type; a sealed and abstract class can neither implement the base class functions nor allow itself to be used as a base class.  
  
 For more information, see [abstract (C++)](../vs140/abstract---c---component-extensions-.md), [sealed](../vs140/sealed---c---component-extensions-.md), and [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md).  
  
## Example  
 The following sample generates C4694.  
  
```  
// C4694.cpp  
// compile with: /c /clr  
ref struct A {};  
ref struct B sealed abstract : A {};   // C4694  
```