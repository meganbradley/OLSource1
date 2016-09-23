---
title: "Compiler Warning C4687"
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
  - C4687
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4687
ms.assetid: 2f28e0b1-7358-4c88-bd70-aad8f0aa004c
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning C4687
'class': a sealed abstract class cannot implement an interface 'interface'  
  
 A sealed, abstract type is typically only useful to hold static member functions.  
  
 For more information, see [abstract (C++)](../vs140/abstract---c---component-extensions-.md)and [sealed](../vs140/sealed---c---component-extensions-.md).  
  
 C4687 is issued as an error by default. You can suppress C4687 with the [warning](../vs140/warning.md) pragma. If you are certain that you want to implement an interface in a sealed, abstract type, you can suppress C4687.  
  
## Example  
 The following sample generates C4687.  
  
```  
// C4687.cpp  
// compile with: /clr /c  
interface class A {};  
  
ref struct B sealed abstract : A {};   // C4687  
ref struct C sealed : A {};   // OK  
ref struct D abstract : A {};   // OK  
```