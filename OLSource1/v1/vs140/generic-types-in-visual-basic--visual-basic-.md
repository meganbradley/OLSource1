---
title: "Generic Types in Visual Basic (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "generic interfaces"
  - "data type arguments, defining"
  - "generic delegates"
  - "arguments [Visual Basic], data types"
  - "Of keyword, using"
  - "delegates, generic"
  - "constraints, Visual Basic generic types"
  - "generic parameters"
  - "data type parameters"
  - "procedures, generic"
  - "generic procedures"
  - "data types [Visual Basic], generic"
  - "data types [Visual Basic], as parameters"
  - "generics [Visual Basic], generic types"
  - "data types [Visual Basic], as arguments"
  - "generic classes, Visual Basic"
  - "parameters, type"
  - "type arguments"
  - "interfaces, generic"
  - "generics [Visual Basic]"
  - "types [Visual Basic], generic"
  - "parameters, generic"
  - "generic structures"
  - "generic classes"
  - "type parameters"
  - "data type arguments"
  - "structures, generic"
  - "parameters, data type"
  - "collections, generic"
  - "classes [Visual Basic], generic"
  - "data type parameters, defining"
  - "type arguments, defining"
  - "arguments [Visual Basic], type"
ms.assetid: 89f771d9-ecbb-4737-88b8-116b63c6cf4d
caps.latest.revision: 49
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic Types in Visual Basic (Visual Basic)
A *generic type* is a single programming element that adapts to perform the same functionality for a variety of data types. When you define a generic class or procedure, you do not have to define a separate version for each data type for which you might want to perform that functionality.  
  
 An analogy is a screwdriver set with removable heads. You inspect the screw you need to turn and select the correct head for that screw (slotted, crossed, starred). Once you insert the correct head in the screwdriver handle, you perform the exact same function with the screwdriver, namely turning the screw.  
  
 ![Diagram of a screwdriver set as a generic tool](../vs140/media/genericscrewdriver.gif "GenericScrewDriver")  
Screwdriver set as a generic tool  
  
 When you define a generic type, you parameterize it with one or more data types. This allows the using code to tailor the data types to its requirements. Your code can declare several different programming elements from the generic element, each one acting on a different set of data types. But the declared elements all perform the identical logic, no matter what data types they are using.  
  
 For example, you might want to create and use a queue class that operates on a specific data type such as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. You can declare such a class from <xref:System.Collections.Generic.Queue<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>stringQ<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>String<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>stringQ<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>String<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>Object<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>t<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>classHolder<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>t<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>processNewItem<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>integerClass<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>Object<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>String<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>Integer<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>customer<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Object<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>Object<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>Object<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>Object<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>itemManager<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>{ }<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>Class<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>Structure` keyword.  
  
 For more information on constraints, see [Type List](../vs140/type-list--visual-basic-.md).  
  
### Example of Multiple Constraints  
 The following example shows a skeleton definition of a generic class with a constraint list on the type parameter. In the code that creates an instance of this class, the type argument must implement both the \<xref:System.IComparable*> and \<xref:System.IDisposable*> interfaces, be a reference type, and expose an accessible parameterless constructor.  
  
 [!code[VbVbalrDataTypes#6](../vs140/codesnippet/VisualBasic/generic-types-in-visual-basic--visual-basic-_6.vb)]  
  
## Important Terms  
 Generic types introduce and use the following terms:  
  
-   *Generic Type*. A definition of a class, structure, interface, procedure, or delegate for which you supply at least one data type when you declare it.  
  
-   *Type Parameter*. In a generic type definition, a placeholder for a data type you supply when you declare the type.  
  
-   *Type Argument*. A specific data type that replaces a type parameter when you declare a constructed type from a generic type.  
  
-   *Constraint*. A condition on a type parameter that restricts the type argument you can supply for it. A constraint can require that the type argument must implement a particular interface, be or inherit from a particular class, have an accessible parameterless constructor, or be a reference type or a value type. You can combine these constraints, but you can specify at most one class.  
  
-   *Constructed Type*. A class, structure, interface, procedure, or delegate declared from a generic type by supplying type arguments for its type parameters.  
  
## See Also  
 [Data Types in Visual Basic](../vs140/data-types-in-visual-basic.md)   
 [Type Characters](../vs140/type-characters--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md)   
 [Of](../vs140/of-clause--visual-basic-.md)   
 [As](../vs140/as-clause--visual-basic-.md)   
 [Object Data Type](../vs140/object-data-type.md)   
 [Covariance and Contravariance (C# and Visual Basic)](../vs140/covariance-and-contravariance--csharp-and-visual-basic-.md)   
 [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md)