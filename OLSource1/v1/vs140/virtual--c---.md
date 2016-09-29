---
title: "virtual (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "virtual_cpp"
  - "virtual"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "virtual base classes, declaring"
  - "base classes, virtual"
  - "virtual functions, declaring"
  - "virtual keyword [C++]"
ms.assetid: c2eb987d-6cf3-43b6-aa0c-29a6f561b1ae
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# virtual (C++)
The `virtual` keyword declares a virtual function or a virtual base class.  
  
## Syntax  
  
```  
virtual [type-specifiers] member-function-declarator  
virtual [access-specifier] base-class-name  
```  
  
#### Parameters  
 `type-specifiers`  
 Specifies the return type of the virtual member function.  
  
 `member-function-declarator`  
 Declares a member function.  
  
 `access-specifier`  
 Defines the level of access to the base class, `public`, `protected` or `private`. Can appear before or after the `virtual` keyword.  
  
 `base-class-name`  
 Identifies a previously declared class type.  
  
## Remarks  
 See [Virtual Functions](../vs140/virtual-functions.md) and [Virtual Base Classes](../vs140/virtual-base-classes.md) for more information.  
  
 Also see the following keywords: [class](../vs140/class--c---.md), [private](../vs140/private--c---.md), [public](../vs140/public--c---.md), and [protected](../vs140/protected--c---.md).  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)