---
title: "Interfaces (F#)"
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
  - "interfaces [F#]"
  - "interface keyword [F#]"
ms.assetid: 666f0b81-6bc6-44fb-a387-7c2e7a139369
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interfaces (F#)
*Interfaces* specify sets of related members that other classes implement.  
  
## Syntax  
  
```  
// Interface declaration:  
[ attributes ]  
type interface-name =  
   [ interface ]     [ inherit base-interface-name ...]  
     abstract member1 : [ argument-types1 -> ] return-type1  
     abstract member2 : [ argument-types2 -> ] return-type2  
     ...  
   [ end ]  
  
// Implementing, inside a class type definition:  
interface interface-name with  
   member self-identifier.member1 argument-list = method-body1  
   member self-identifier.member2 argument-list = method-body2  
  
// Implementing, by using an object expression:  
[ attributes ]  
let class-name (argument-list) =  
   { new interface-name with  
       member self-identifier.member1 argument-list = method-body1  
       member self-identifier.member2 argument-list = method-body2  
       [ base-interface-definitions ]  
   }  
   member-list  
```  
  
## Remarks  
 Interface declarations resemble class declarations except that no members are implemented. Instead, all the members are abstract, as indicated by the keyword `abstract`. You do not provide a method body for abstract methods. However, you can provide a default implementation by also including a separate definition of the member as a method together with the `default` keyword. Doing so is equivalent to creating a virtual method in a base class in other .NET languages. Such a virtual method can be overridden in classes that implement the interface.  
  
 There are two ways to implement interfaces: by using object expressions, and by using class types. In either case, the class type or object expression provides method bodies for abstract methods of the interface. Implementations are specific to each type that implements the interface. Therefore, interface methods on different types might be different from each other.  
  
 The keywords `interface` and `end`, which mark the start and end of the definition, are optional when you use lightweight syntax. If you do not use these keywords, the compiler attempts to infer whether the type is a class or an interface by analyzing the constructs that you use. If you define a member or use other class syntax, the type is interpreted as a class.  
  
 The .NET coding style is to begin all interfaces with a capital `I`.  
  
## Implementing Interfaces by Using Class Types  
 You can implement one or more interfaces in a class type by using the `interface` keyword, the name of the interface, and the `with` keyword, followed by the interface member definitions, as shown in the following code.  
  
 [!code[FsLangRef1#2801](../vs140/codesnippet/FSharp/interfaces--fsharp-_1.fs)]  
  
 Interface implementations are inherited, so any derived classes do not need to reimplement them.  
  
## Calling Interface Methods  
 Interface methods can be called only through the interface, not through any object of the type that implements the interface. Thus, you might have to upcast to the interface type by using the `:>` operator or the `upcast` operator in order to call these methods.  
  
 To call the interface method when you have an object of type `SomeClass`, you must upcast the object to the interface type, as shown in the following code.  
  
 [!code[FsLangRef1#2802](../vs140/codesnippet/FSharp/interfaces--fsharp-_2.fs)]  
  
 An alternative is to declare a method on the object that upcasts and calls the interface method, as in the following example.  
  
 [!code[FsLangRef1#2803](../vs140/codesnippet/FSharp/interfaces--fsharp-_3.fs)]  
  
## Implementing Interfaces by Using Object Expressions  
 Object expressions provide a short way to implement an interface. They are useful when you do not have to create a named type, and you just want an object that supports the interface methods, without any additional methods. An object expression is illustrated in the following code.  
  
 [!code[FsLangRef1#2804](../vs140/codesnippet/FSharp/interfaces--fsharp-_4.fs)]  
  
## Interface Inheritance  
 Interfaces can inherit from one or more base interfaces.  
  
 [!code[FsLangRef1#2805](../vs140/codesnippet/FSharp/interfaces--fsharp-_5.fs)]  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Object Expressions](../vs140/object-expressions--fsharp-.md)   
 [Classes](../vs140/classes--fsharp-.md)