---
title: "Referencing Templates"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 593ca6aa-6e17-41f6-8ec3-d7e11c31bf1d
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Referencing Templates
This topic shows how to use a template that has been previously declared.  
  
## Syntax  
  
```  
  
template-name < template-arg-list >  
```  
  
## Remarks  
 The *template-arg-list* should be a comma-separated list of:  
  
```  
  
expression  
type-name  
  
```  
  
 All *expression* arguments must be constant expressions. The compiler creates a new instance (called an instantiation) of the templated class or function if there is no exact match to a previously generated template. For example, to reference the `MyStack` class defined in [Member Function Templates](../vs140/member-function-templates.md):  
  
```  
MyStack< unsigned long, 5 > stack1;       
// Creates a stack of unsigned longs.  
MyStack< DWORD, 5 >stack2;  
// Uses code created above.  
MyStack< char, 6 > stack3;  
// Generates new code.  
MyStack< MyClass, 6 > stack4;  
// Generates stack of MyClass objects.  
```  
  
 Each generated function template creates its own static variables and members.  
  
 All template arguments must be accessible at the point where they are used.  
  
 The exception to the above syntax rule is in identifying a member template specialization in an expression after the `::`, **.** or **->** operators. After these operators, the keyword `template` can be specified. Visual C++ departs from the standard in that the `template` keyword is always optional in this context, whereas the standard requires it in some circumstances. The template keyword cannot be used in the specialization unless following these operators.  
  
 [ **::** &#124; **->** &#124; **.** ] **template***template*-*name***<***template*-`arg`-`list`**>**  
  
 For example, the following specifies a call to the `int` specialization of the member function template `f<T>(int)` which is a member of the class `X` and passes it the parameter `10`.  
  
```  
X::template f<int>(10);  
```  
  
## See Also  
 [Templates](../vs140/templates--c---.md)