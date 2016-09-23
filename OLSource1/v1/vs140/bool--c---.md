---
title: "bool (C++)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
f1_keywords: 
  - bool_cpp
  - bool
  - __BOOL_DEFINED
dev_langs: 
  - C++
helpviewer_keywords: 
  - bool keyword [C++]
  - __BOOL_DEFINED macro
ms.assetid: 9abed3f2-d21c-4eb4-97c5-716342e613d8
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# bool (C++)
This keyword is a built-in type. A variable of this type can have values [true](../vs140/true--c---.md) and [false](../vs140/false--c---.md). Conditional expressions have the type `bool` and so have values of type `bool`. For example, `i!=0` now has **true** or **false** depending on the value of `i`.  
  
 The values **true** and **false** have the following relationship:  
  
```  
!false == true  
!true == false  
```  
  
 In the following statement:  
  
```  
if (condexpr1) statement1;   
```  
  
 If `condexpr1` is **true**, `statement1` is always executed; if `condexpr1` is **false**, `statement1` is never executed.  
  
 When a postfix or prefix `++` operator is applied to a variable of type `bool`, the variable is set to **true**. The postfix or prefix `--` operator cannot be applied to a variable of this type.  
  
 The `bool` type participates in integral promotions. An r-value of type `bool` can be converted to an r-value of type `int`, with **false** becoming zero and **true** becoming one. As a distinct type, `bool` participates in overload resolution.  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [Fundamental Types](../vs140/fundamental-types---c---.md)