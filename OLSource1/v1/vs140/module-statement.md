---
title: "Module Statement"
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
  - "Module"
  - "vb.Module"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "modules, classes"
  - "modules"
  - "Module statement"
  - "modules, declaring"
  - "standard modules"
  - "classes [Visual Basic], vs. modules"
  - "declarations, modules"
ms.assetid: a1243afc-14a5-45df-95d5-51118aeac362
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Module Statement
Declares the name of a module and introduces the definition of the variables, properties, events, and procedures that the module comprises.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Optional. Can be one of the following:  
  
-   [Public](../vs140/public--visual-basic-.md)  
  
-   [Friend](../vs140/friend--visual-basic-.md)  
  
 See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. Name of this module. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional. Statements which define the variables, properties, events, procedures, and nested types of this module.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Terminates the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> definition.  
  
## Remarks  
 A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement defines a reference type available throughout its namespace. A *module* (sometimes called a *standard module*)is similar to a class but with some important distinctions. Every module has exactly one instance and does not need to be created or assigned to a variable. Modules do not support inheritance or implement interfaces. Notice that a module is not a *type* in the sense that a class or structure is — you cannot declare a programming element to have the data type of a module.  
  
 You can use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> only at namespace level. This means the *declaration context* for a module must be a source file or namespace, and cannot be a class, structure, module, interface, procedure, or block. You cannot nest a module within another module, or within any type. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 A module has the same lifetime as your program. Because its members are all <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, they also have lifetimes equal to that of the program.  
  
 Modules default to [Friend (Visual Basic)](../vs140/friend--visual-basic-.md) access. You can adjust their access levels with the access modifiers. For more information, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
 All members of a module are implicitly <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Classes and Modules  
 These elements have many similarities, but there are some important differences as well.  
  
-   **Terminology.** Previous versions of Visual Basic recognize two types of modules: *class modules* (.cls files) and *standard modules* (.bas files). The current version calls these *classes* and *modules*, respectively.  
  
-   **Shared Members.** You can control whether a member of a class is a shared or instance member.  
  
-   **Object Orientation.** Classes are object-oriented, but modules are not. So only classes can be instantiated as objects. For more information, see [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md).  
  
## Rules  
  
-   **Modifiers.** All module members are implicitly [Shared (Visual Basic)](../vs140/shared--visual-basic-.md). You cannot use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword when declaring a member, and you cannot alter the shared status of any member.  
  
-   **Inheritance.** A module cannot inherit from any type other than \<xref:System.Object*>, from which all modules inherit. In particular, one module cannot inherit from another.  
  
     You cannot use the [Inherits Statement](../vs140/inherits-statement.md) in a module definition, even to specify \<xref:System.Object*>.  
  
-   **Default Property.** You cannot define any default properties in a module. For more information, see [Default (Visual Basic)](../vs140/default--visual-basic-.md).  
  
## Behavior  
  
-   **Access Level.** Within a module, you can declare each member with its own access level. Module members default to [Public (Visual Basic)](../vs140/public--visual-basic-.md) access, except variables and constants, which default to [Private (Visual Basic)](../vs140/private--visual-basic-.md) access. When a module has more restricted access than one of its members, the specified module access level takes precedence.  
  
-   **Scope.** A module is in scope throughout its namespace.  
  
     The scope of every module member is the entire module. Notice that all members undergo *type promotion*, which causes their scope to be promoted to the namespace containing the module. For more information, see [Type Promotion](../vs140/type-promotion--visual-basic-.md).  
  
-   **Qualification.** You can have multiple modules in a project, and you can declare members with the same name in two or more modules. However, you must qualify any reference to such a member with the appropriate module name if the reference is from outside that module. For more information, see [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md).  
  
## Example  
 [!code[VbVbalrStatements#69](../vs140/codesnippet/VisualBasic/module-statement_1.vb)]  
  
## See Also  
 [Class Statement](../vs140/class-statement--visual-basic-.md)   
 [Namespace Statement](../vs140/namespace-statement.md)   
 [Structure Statement](../vs140/structure-statement.md)   
 [Interface Statement](../vs140/interface-statement--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Type Promotion](../vs140/type-promotion--visual-basic-.md)