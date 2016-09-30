---
title: "Constraints on Generic Type Parameters (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "Constraints on Generic Type Parameters (C++/CLI)"
f1_keywords: 
  - "where"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "where keyword [C++]"
  - "constraints, C++"
ms.assetid: eb828cc9-684f-48a3-a898-b327700c0a63
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constraints on Generic Type Parameters (C++-CLI)
In generic type or method declarations, you can qualify a type parameter with constraints. A constraint is a requirement that types used as type arguments must satisfy. For example, a constraint might be that the type argument must implement a certain interface or inherit from a specific class.  
  
 Constraints are optional; not specifying a constraint on a parameter is equivalent to constraining that parameter to \<xref:System.Object*>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *type-parameter*  
 One of the type parameters, to be constrained.  
  
 *constraint list*  
 *constraint list* is a comma-separated list of constraint specifications. The list can include interfaces to be implemented by the type parameter.  
  
 The list can also include a class. For the type argument to satisfy a base class constraint, it must be the same class as the constraint or derive from the constraint.  
  
 You can also specify <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to indicate the type argument must have a public parameterless constructor; or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to indicate the type argument must be a reference type, including any class, interface, delegate, or array type; or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to indicate the type argument must be a value type. Any value type except Nullable\<T> can be specified.  
  
 You can also specify a generic parameter as a constraint. The type argument supplied for the type you are constraining must be or derive from the type of the constraint. This is called a naked type constraint.  
  
## Remarks  
 The constraint clause consists of **where** followed by a type parameter, a colon (**:**), and the constraint, which specifies the nature of the restriction on the type parameter. **where** is a context-sensitive keyword; see [Context-Sensitive Keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md) for more information. Separate multiple **where** clauses with a space.  
  
 Constraints are applied to type parameters to place limitations on the types that can be used as arguments for a generic type or method.  
  
 Class and interface constraints specify that the argument types must be or inherit from a specified class or implement a specified interface.  
  
 The application of constraints to a generic type or method allows code in that type or method to take advantage of the known features of the constrained types. For example, you can declare a generic class such that the type parameter implements the **IComparable\<T>** interface:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This constraint requires that a type argument used for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> implements <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> at compile time. It also allows interface methods, such as **CompareTo**, to be called. No cast is needed on an instance of the type parameter to call interface methods.  
  
 Static methods in the type argument's class cannot be called through the type parameter; they can be called only through the actual named type.  
  
 A constraint cannot be a value type, including built-in types such as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or **double**. Since value types cannot have derived classes, only one class would ever be able to satisfy the constraint. In that case, the generic can be rewritten with the type parameter replaced by the specific value type.  
  
 Constraints are required in some cases since the compiler will not allow the use of methods or other features of an unknown type unless the constraints imply that the unknown type supports the methods or interfaces.  
  
 Multiple constraints for the same type parameter can be specified in a comma-separated list  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 With multiple type parameters, use one **where** clause for each type parameter. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 To summarize, use constraints in your code according to the following rules:  
  
-   If multiple constraints are listed, the constraints may be listed in any order.  
  
-   Constraints can also be class types, such as abstract base classes. However, constraints cannot be value types or sealed classes.  
  
-   Constraints cannot themselves be type parameters, but they can involve the type parameters in an open constructed type. For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates using constraints to call instance methods on type parameters.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **"parent" is not a senior**  
**"grandfather" is a senior**   
## Example  
 When a generic type parameter is used as a constraint, it is called a naked type constraint. Naked type constraints are useful when a member function with its own type parameter needs to constrain that parameter to the type parameter of the containing type.  
  
 In the following example, T is a naked type constraint in the context of the Add method.  
  
 Naked type constraints can also be used in generic class definitions. The usefulness of naked type constraints with generic classes is limited because the compiler can assume nothing about a naked type constraint except that it derives from \<xref:System.Object*>. Use naked type constraints on generic classes in scenarios in which you wish to enforce an inheritance relationship between two type parameters.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [Generics (C++)](../vs140/generics---c---component-extensions-.md)