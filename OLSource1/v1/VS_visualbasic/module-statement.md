---
title: "Module Statement"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 24
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Module Statement
Declares the name of a module and introduces the definition of the variables, properties, events, and procedures that the module comprises.  
  
## Syntax  
  
```  
[ <attributelist> ] [ accessmodifier ]  Module name  
    [ statements ]  
End Module  
```  
  
## Parts  
 `attributelist`  
 Optional. See [Attribute List](../VS_visualbasic/attribute-list--visual-basic-.md).  
  
 `accessmodifier`  
 Optional. Can be one of the following:  
  
-   [Public](../VS_visualbasic/public--visual-basic-.md)  
  
-   [Friend](../VS_visualbasic/friend--visual-basic-.md)  
  
 See [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md).  
  
 `name`  
 Required. Name of this module. See [Declared Element Names](../VS_visualbasic/declared-element-names--visual-basic-.md).  
  
 `statements`  
 Optional. Statements which define the variables, properties, events, procedures, and nested types of this module.  
  
 `End Module`  
 Terminates the `Module` definition.  
  
## Remarks  
 A `Module` statement defines a reference type available throughout its namespace. A *module* (sometimes called a *standard module*)is similar to a class but with some important distinctions. Every module has exactly one instance and does not need to be created or assigned to a variable. Modules do not support inheritance or implement interfaces. Notice that a module is not a *type* in the sense that a class or structure is — you cannot declare a programming element to have the data type of a module.  
  
 You can use `Module` only at namespace level. This means the *declaration context* for a module must be a source file or namespace, and cannot be a class, structure, module, interface, procedure, or block. You cannot nest a module within another module, or within any type. For more information, see [Declaration Contexts and Default Access Levels](../VS_visualbasic/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 A module has the same lifetime as your program. Because its members are all `Shared`, they also have lifetimes equal to that of the program.  
  
 Modules default to [Friend](../VS_visualbasic/friend--visual-basic-.md) access. You can adjust their access levels with the access modifiers. For more information, see [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md).  
  
 All members of a module are implicitly `Shared`.  
  
## Classes and Modules  
 These elements have many similarities, but there are some important differences as well.  
  
-   **Terminology.** Previous versions of Visual Basic recognize two types of modules: *class modules* (.cls files) and *standard modules* (.bas files). The current version calls these *classes* and *modules*, respectively.  
  
-   **Shared Members.** You can control whether a member of a class is a shared or instance member.  
  
-   **Object Orientation.** Classes are object-oriented, but modules are not. So only classes can be instantiated as objects. For more information, see [Objects and Classes](../VS_visualbasic/objects-and-classes-in-visual-basic.md).  
  
## Rules  
  
-   **Modifiers.** All module members are implicitly [Shared](../VS_visualbasic/shared--visual-basic-.md). You cannot use the `Shared` keyword when declaring a member, and you cannot alter the shared status of any member.  
  
-   **Inheritance.** A module cannot inherit from any type other than \<xref:System.Object>, from which all modules inherit. In particular, one module cannot inherit from another.  
  
     You cannot use the [Inherits Statement](../VS_visualbasic/inherits-statement.md) in a module definition, even to specify \<xref:System.Object>.  
  
-   **Default Property.** You cannot define any default properties in a module. For more information, see [Default](../VS_visualbasic/default--visual-basic-.md).  
  
## Behavior  
  
-   **Access Level.** Within a module, you can declare each member with its own access level. Module members default to [Public](../VS_visualbasic/public--visual-basic-.md) access, except variables and constants, which default to [Private](../VS_visualbasic/private--visual-basic-.md) access. When a module has more restricted access than one of its members, the specified module access level takes precedence.  
  
-   **Scope.** A module is in scope throughout its namespace.  
  
     The scope of every module member is the entire module. Notice that all members undergo *type promotion*, which causes their scope to be promoted to the namespace containing the module. For more information, see [Type Promotion](../VS_visualbasic/type-promotion--visual-basic-.md).  
  
-   **Qualification.** You can have multiple modules in a project, and you can declare members with the same name in two or more modules. However, you must qualify any reference to such a member with the appropriate module name if the reference is from outside that module. For more information, see [References to Declared Elements](../VS_visualbasic/references-to-declared-elements--visual-basic-.md).  
  
## Example  
 [!code[VbVbalrStatements#69](../VS_visualbasic/codesnippet/VisualBasic/module-statement_1.vb)]  
  
## See Also  
 [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md)   
 [Namespace Statement](../VS_visualbasic/namespace-statement.md)   
 [Structure Statement](../VS_visualbasic/structure-statement.md)   
 [Interface Statement](../VS_visualbasic/interface-statement--visual-basic-.md)   
 [Property Statement](../VS_visualbasic/property-statement.md)   
 [Type Promotion](../VS_visualbasic/type-promotion--visual-basic-.md)