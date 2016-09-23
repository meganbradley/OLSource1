---
title: "Class Statement (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.Class
dev_langs: 
  - VB
helpviewer_keywords: 
  - class modules
  - Class statement
  - classes [Visual Basic], fields
  - fields, of classes
  - class types, class statements
  - classes [Visual Basic], creating
  - classes [Visual Basic], data members
  - data members, of classes
ms.assetid: f2664f38-eb5a-4d4b-a374-1d041521fb6c
caps.latest.revision: 33
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Class Statement (Visual Basic)
Declares the name of a class and introduces the definition of the variables, properties, events, and procedures that the class comprises.  
  
## Syntax  
  
```  
[ <attributelist> ] [ accessmodifier ] [ Shadows ] [ MustInherit | NotInheritable ] [ Partial ] _  
Class name [ ( Of typelist ) ]  
    [ Inherits classname ]  
    [ Implements interfacenames ]  
    [ statements ]  
End Class  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`attributelist`|Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).|  
|`accessmodifier`|Optional. Can be one of the following:<br /><br /> -   [Public](../vs140/public--visual-basic-.md)<br />-   [Protected](../vs140/protected--visual-basic-.md)<br />-   [Friend](../vs140/friend--visual-basic-.md)<br />-   [Private](../vs140/private--visual-basic-.md)<br />-   `Protected Friend`<br /><br /> See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).|  
|`Shadows`|Optional. See [Shadows](../vs140/shadows--visual-basic-.md).|  
|`MustInherit`|Optional. See [MustInherit](../vs140/mustinherit--visual-basic-.md).|  
|`NotInheritable`|Optional. See [NotInheritable](../vs140/notinheritable--visual-basic-.md).|  
|`Partial`|Optional. Indicates a partial definition of the class. See [Partial (Visual Basic)](../vs140/partial--visual-basic-.md).|  
|`name`|Required. Name of this class. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).|  
|`Of`|Optional. Specifies that this is a generic class.|  
|`typelist`|Required if you use the [Of](../vs140/of-clause--visual-basic-.md) keyword. List of type parameters for this class. See [Type List](../vs140/type-list--visual-basic-.md).|  
|`Inherits`|Optional. Indicates that this class inherits the members of another class. See [Inherits Statement](../vs140/inherits-statement.md).|  
|`classname`|Required if you use the `Inherits` statement. The name of the class from which this class derives.|  
|`Implements`|Optional. Indicates that this class implements the members of one or more interfaces. See [Implements Statement](../vs140/implements-statement.md).|  
|`interfacenames`|Required if you use the `Implements` statement. The names of the interfaces this class implements.|  
|`statements`|Optional. Statements which define the members of this class.|  
|`End Class`|Required. Terminates the `Class` definition.|  
  
## Remarks  
 A `Class` statement defines a new data type. A *class* is a fundamental building block of object-oriented programming (OOP). For more information, see [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md).  
  
 You can use `Class` only at namespace or module level. This means the *declaration context* for a class must be a source file, namespace, class, structure, module, or interface, and cannot be a procedure or block. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 Each instance of a class has a lifetime independent of all other instances. This lifetime begins when it is created by a [New (Visual Basic)](../vs140/new-operator--visual-basic-.md) clause or by a function such as <xref:Microsoft.VisualBasic.Interaction.CreateObject?qualifyHint=False>. It ends when all variables pointing to the instance have been set to [Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md) or to instances of other classes.  
  
 Classes default to [Friend (Visual Basic)](../vs140/friend--visual-basic-.md) access. You can adjust their access levels with the access modifiers. For more information, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
## Rules  
  
-   **Nesting.** You can define one class within another. The outer class is called the *containing class*, and the inner class is called a *nested class*.  
  
-   **Inheritance.** If the class uses the [Inherits Statement](../vs140/inherits-statement.md), you can specify only one base class or interface. A class cannot inherit from more than one element.  
  
     A class cannot inherit from another class with a more restrictive access level. For example, a `Public` class cannot inherit from a `Friend` class.  
  
     A class cannot inherit from a class nested within it.  
  
-   **Implementation.** If the class uses the [Implements Statement](../vs140/implements-statement.md), you must implement every member defined by every interface you specify in `interfacenames`. An exception to this is reimplementation of a base class member. For more information, see "Reimplementation" in [Implements (Visual Basic)](../vs140/implements-clause--visual-basic-.md).  
  
-   **Default Property.** A class can specify at most one property as its *default property*. For more information, see [Default (Visual Basic)](../vs140/default--visual-basic-.md).  
  
## Behavior  
  
-   **Access Level.** Within a class, you can declare each member with its own access level. Class members default to [Public (Visual Basic)](../vs140/public--visual-basic-.md) access, except variables and constants, which default to [Private (Visual Basic)](../vs140/private--visual-basic-.md) access. When a class has more restricted access than one of its members, the class access level takes precedence.  
  
-   **Scope.** A class is in scope throughout its containing namespace, class, structure, or module.  
  
     The scope of every class member is the entire class.  
  
     **Lifetime.** Visual Basic does not support static classes. The functional equivalent of a static class is provided by a module. For more information, see [Module Statement](../vs140/module-statement.md).  
  
     Class members have lifetimes depending on how and where they are declared. For more information, see [Lifetime in Visual Basic](../vs140/lifetime-in-visual-basic.md).  
  
-   **Qualification.** Code outside a class must qualify a member's name with the name of that class.  
  
     If code inside a nested class makes an unqualified reference to a programming element, Visual Basic searches for the element first in the nested class, then in its containing class, and so on out to the outermost containing element.  
  
## Classes and Modules  
 These elements have many similarities, but there are some important differences as well.  
  
-   **Terminology.** Previous versions of Visual Basic recognize two types of modules: *class modules* (.cls files) and *standard modules* (.bas files). The current version calls these *classes* and *modules*, respectively.  
  
-   **Shared Members.** You can control whether a member of a class is a shared or instance member.  
  
-   **Object Orientation.** Classes are object-oriented, but modules are not. You can create one or more instances of a class. For more information, see [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md).  
  
## Example  
 The following example uses a `Class` statement to define a class and several members.  
  
 [!code[VbVbalrStatements#62](../vs140/codesnippet/VisualBasic/class-statement--visual-basic-_1.vb)]
  
  
## See Also  
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)   
 [Structures and Classes](../vs140/structures-and-classes--visual-basic-.md)   
 [Interface Statement](../vs140/interface-statement--visual-basic-.md)   
 [Module Statement](../vs140/module-statement.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Object Lifetime: How Objects Are Created and Destroyed](../vs140/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [How to: Use a Generic Class](../vs140/how-to--use-a-generic-class--visual-basic-.md)