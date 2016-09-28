---
title: "Type List (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "StructureConstraint"
  - "vb.StructureConstraint"
  - "ClassConstraint"
  - "vb.ClassConstraint"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "class constraint"
  - "constraints, Visual Basic generic types"
  - "generic parameters"
  - "generics [Visual Basic], constraints"
  - "generics [Visual Basic], type list"
  - "structure constraint"
  - "constraints, in type parameters"
  - "generics [Visual Basic], generic types"
  - "parameters, type"
  - "constraints, Structure keyword"
  - "type parameters, constraints"
  - "types [Visual Basic], generic"
  - "parameters, generic"
  - "generics [Visual Basic], type parameters"
  - "type parameters"
  - "constraints, Class keyword"
ms.assetid: 56db947a-2ae8-40f2-a70a-960764e9d0db
caps.latest.revision: 37
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type List (Visual Basic)
Specifies the *type parameters* for a *generic* programming element. Multiple parameters are separated by commas. Following is the syntax for one type parameter.  
  
## Syntax  
  
```  
  
[genericmodifier] typename [ As constraintlist ]  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`genericmodifier`|Optional. Can be used only in generic interfaces and delegates. You can declare a type covariant by using the [Out](../vs140/out--generic-modifier---visual-basic-.md) keyword or contravariant by using the [In](../vs140/in--generic-modifier---visual-basic-.md) keyword. See [Covariance and Contravariance (C# and Visual Basic)](../vs140/covariance-and-contravariance--csharp-and-visual-basic-.md).|  
|`typename`|Required. Name of the type parameter. This is a placeholder, to be replaced by a defined type supplied by the corresponding type argument.|  
|`constraintlist`|Optional. List of requirements that constrain the data type that can be supplied for `typename`. If you have multiple constraints, enclose them in curly braces (`{ }`) and separate them with commas. You must introduce the constraint list with the [As](../vs140/as-clause--visual-basic-.md) keyword. You use `As` only once, at the beginning of the list.|  
  
## Remarks  
 Every generic programming element must take at least one type parameter. A type parameter is a placeholder for a specific type (a *constructed element*) that client code specifies when it creates an instance of the generic type. You can define a generic class, structure, interface, procedure, or delegate.  
  
 For more information on when to define a generic type, see [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md). For more information on type parameter names, see [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
## Rules  
  
-   **Parentheses.** If you supply a type parameter list, you must enclose it in parentheses, and you must introduce the list with the [Of](../vs140/of-clause--visual-basic-.md) keyword. You use `Of` only once, at the beginning of the list.  
  
-   **Constraints.** A list of *constraints* on a type parameter can include the following items in any combination:  
  
    -   Any number of interfaces. The supplied type must implement every interface in this list.  
  
    -   At most one class. The supplied type must inherit from that class.  
  
    -   The `New` keyword. The supplied type must expose a parameterless constructor that your generic type can access. This is useful if you constrain a type parameter by one or more interfaces. A type that implements interfaces does not necessarily expose a constructor, and depending on the access level of a constructor, the code within the generic type might not be able to access it.  
  
    -   Either the `Class` keyword or the `Structure` keyword. The `Class` keyword constrains a generic type parameter to require that any type argument passed to it be a reference type, for example a string, array, or delegate, or an object created from a class. The `Structure` keyword constrains a generic type parameter to require that any type argument passed to it be a value type, for example a structure, enumeration, or elementary data type. You cannot include both `Class` and `Structure` in the same `constraintlist`.  
  
     The supplied type must satisfy every requirement you include in `constraintlist`.  
  
     Constraints on each type parameter are independent of constraints on other type parameters.  
  
## Behavior  
  
-   **Compile-Time Substitution.** When you create a constructed type from a generic programming element, you supply a defined type for each type parameter. The Visual Basic compiler substitutes that supplied type for every occurrence of `typename` within the generic element.  
  
-   **Absence of Constraints.** If you do not specify any constraints on a type parameter, your code is limited to the operations and members supported by the [Object Data Type](../vs140/object-data-type.md) for that type parameter.  
  
## Example  
 The following example shows a skeleton definition of a generic dictionary class, including a skeleton function to add a new entry to the dictionary.  
  
 [!code[VbVbalrStatements#3](../vs140/codesnippet/VisualBasic/type-list--visual-basic-_1.vb)]  
  
## Example  
 Because `dictionary` is generic, the code that uses it can create a variety of objects from it, each having the same functionality but acting on a different data type. The following example shows a line of code that creates a `dictionary` object with `String` entries and `Integer` keys.  
  
 [!code[VbVbalrStatements#4](../vs140/codesnippet/VisualBasic/type-list--visual-basic-_2.vb)]  
  
## Example  
 The following example shows the equivalent skeleton definition generated by the preceding example.  
  
 [!code[VbVbalrStatements#5](../vs140/codesnippet/VisualBasic/type-list--visual-basic-_3.vb)]  
  
## See Also  
 [Of](../vs140/of-clause--visual-basic-.md)   
 [New (Visual Basic)](../vs140/new-operator--visual-basic-.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)   
 [Object Data Type](../vs140/object-data-type.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Structure Statement](../vs140/structure-statement.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [How to: Use a Generic Class](../vs140/how-to--use-a-generic-class--visual-basic-.md)   
 [Covariance and Contravariance (C# and Visual Basic)](../vs140/covariance-and-contravariance--csharp-and-visual-basic-.md)   
 [in (Generic Modifier) (Visual Basic)](../vs140/in--generic-modifier---visual-basic-.md)   
 [Out (Generic Modifier) (Visual Basic)](../vs140/out--generic-modifier---visual-basic-.md)