---
title: "do Bindings in Classes (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "do bindings [F#], classes"
ms.assetid: de12e2fb-d8c6-4e8d-a35c-efe20532a421
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# do Bindings in Classes (F#)
A `do` binding in a class definition performs actions when the object is constructed or, for a static `do` binding, when the type is first used.  
  
## Syntax  
  
```  
[static] do expression  
```  
  
## Remarks  
 A `do` binding appears together with or after `let` bindings but before member definitions in a class definition. Although the `do` keyword is optional for `do` bindings at the module level, it is not optional for `do` bindings in a class definition.  
  
 For the construction of every object of any given type, non-static `do` bindings and non-static `let` bindings are executed in the order in which they appear in the class definition. Multiple `do` bindings can occur in one type. The non-static `let` bindings and the non-static `do` bindings become the body of the primary constructor. The code in the non-static `do` bindings section can reference the primary constructor parameters and any values or functions that are defined in the `let` bindings section.  
  
 Non-static `do` bindings can access members of the class as long as the class has a self identifier that is defined by an `as` keyword in the class heading, and as long as all uses of those members are qualified with the self identifier for the class.  
  
 Because `let` bindings initialize the private fields of a class, which is often necessary to guarantee that members behave as expected, `do` bindings are usually put after `let` bindings so that code in the `do` binding can execute with a fully initialized object. If your code attempts to use a member before the initialization is complete, an InvalidOperationException is raised.  
  
 Static `do` bindings can reference static members or fields of the enclosing class but not instance members or fields. Static `do` bindings become part of the static initializer for the class, which is guaranteed to execute before the class is first used.  
  
 Attributes are ignored for `do` bindings in types. If an attribute is required for code that executes in a `do` binding, it must be applied to the primary constructor.  
  
 In the following code, a class has a static `do` binding and a non-static `do` binding. The object has a constructor that has two parameters, `a` and `b`, and two private fields are defined in the `let` bindings for the class. Two properties are also defined. All of these are in scope in the non-static `do` bindings section, as is illustrated by the line that prints all those values.  
  
 [!code[FsLangRef1#3101](../VS_csharp/codesnippet/FSharp/do-bindings-in-classes--fsharp-_1.fs)]  
  
 The output is as follows.  
  
```  
Initializing MyType.  
Initializing object 1 2 2 4 8 16  
```  
  
## See Also  
 [Members (F#)](../VS_csharp/members--fsharp-.md)   
 [Classes (F#)](../VS_csharp/classes--fsharp-.md)   
 [Constructors (F#)](../VS_csharp/constructors--fsharp-.md)   
 [Let Bindings in Classes (F#)](../VS_csharp/let-bindings-in-classes--fsharp-.md)   
 [do Bindings (F#)](../VS_csharp/do-bindings--fsharp-.md)