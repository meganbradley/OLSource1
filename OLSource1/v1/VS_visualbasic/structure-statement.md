---
title: "Structure Statement"
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
  - "vb.Structure"
  - "Structure"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "user-defined types, Structure statement"
  - "compound data types"
  - "Structure keyword"
  - "Structure statement"
  - "UDT (user-defined types)"
  - "types [Visual Basic], user-defined"
ms.assetid: 9bd1deea-2a89-4cdc-812c-6dcbb947c391
caps.latest.revision: 28
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
# Structure Statement
Declares the name of a structure and introduces the definition of the variables, properties, events, and procedures that the structure comprises.  
  
## Syntax  
  
```  
[ <attributelist> ] [ accessmodifier ] [ Shadows ] [ Partial ] _  
Structure name [ ( Of typelist ) ]  
    [ Implements interfacenames ]  
    [ datamemberdeclarations ]  
    [ methodmemberdeclarations ]  
End Structure  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`attributelist`|Optional. See [Attribute List](../VS_visualbasic/attribute-list--visual-basic-.md).|  
|`accessmodifier`|Optional. Can be one of the following:<br /><br /> -   [Public](../VS_visualbasic/public--visual-basic-.md)<br />-   [Protected](../VS_visualbasic/protected--visual-basic-.md)<br />-   [Friend](../VS_visualbasic/friend--visual-basic-.md)<br />-   [Private](../VS_visualbasic/private--visual-basic-.md)<br />-   `Protected Friend`<br /><br /> See [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md).|  
|`Shadows`|Optional. See [Shadows](../VS_visualbasic/shadows--visual-basic-.md).|  
|`Partial`|Optional. Indicates a partial definition of the structure. See [Partial](../VS_visualbasic/partial--visual-basic-.md).|  
|`name`|Required. Name of this structure. See [Declared Element Names](../VS_visualbasic/declared-element-names--visual-basic-.md).|  
|`Of`|Optional. Specifies that this is a generic structure.|  
|`typelist`|Required if you use the [Of](../VS_visualbasic/of-clause--visual-basic-.md) keyword. List of type parameters for this structure. See [Type List](../VS_visualbasic/type-list--visual-basic-.md).|  
|`Implements`|Optional. Indicates that this structure implements the members of one or more interfaces. See [Implements Statement](../VS_visualbasic/implements-statement.md).|  
|`interfacenames`|Required if you use the `Implements` statement. The names of the interfaces this structure implements.|  
|`datamemberdeclarations`|Required. Zero or more `Const`, `Dim`, `Enum`, or `Event` statements declaring *data members* of the structure.|  
|`methodmemberdeclarations`|Optional. Zero or more declarations of `Function`, `Operator`, `Property`, or `Sub` procedures, which serve as *method members* of the structure.|  
|`End Structure`|Required. Terminates the `Structure` definition.|  
  
## Remarks  
 The `Structure` statement defines a composite value type that you can customize. A *structure* is a generalization of the user-defined type (UDT) of previous versions of Visual Basic. For more information, see [Structures](../VS_visualbasic/structures--visual-basic-.md).  
  
 Structures support many of the same features as classes. For example, structures can have properties and procedures, they can implement interfaces, and they can have parameterized constructors. However, there are significant differences between structures and classes in areas such as inheritance, declarations, and usage. Also, classes are reference types and structures are value types. For more information, see [Structures and Classes](../VS_visualbasic/structures-and-classes--visual-basic-.md).  
  
 You can use `Structure` only at namespace or module level. This means the *declaration context* for a structure must be a source file, namespace, class, structure, module, or interface, and cannot be a procedure or block. For more information, see [Declaration Contexts and Default Access Levels](../VS_visualbasic/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 Structures default to [Friend](../VS_visualbasic/friend--visual-basic-.md) access. You can adjust their access levels with the access modifiers. For more information, see [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md).  
  
## Rules  
  
-   **Nesting.** You can define one structure within another. The outer structure is called the *containing structure*, and the inner structure is called a *nested structure*. However, you cannot access a nested structure's members through the containing structure. Instead, you must declare a variable of the nested structure's data type.  
  
-   **Member Declaration.** You must declare every member of a structure. A structure member cannot be [Protected](../VS_visualbasic/protected--visual-basic-.md) or `Protected Friend` because nothing can inherit from a structure. The structure itself, however, can be `Protected` or `Protected Friend`.  
  
     You can declare zero or more nonshared variables or nonshared, noncustom events in a structure. You cannot have only constants, properties, and procedures, even if some of them are nonshared.  
  
-   **Initialization.** You cannot initialize the value of any nonshared data member of a structure as part of its declaration. You must either initialize such a data member by means of a parameterized constructor on the structure, or assign a value to the member after you have created an instance of the structure.  
  
-   **Inheritance.** A structure cannot inherit from any type other than \<xref:System.ValueType>, from which all structures inherit. In particular, one structure cannot inherit from another.  
  
     You cannot use the [Inherits Statement](../VS_visualbasic/inherits-statement.md) in a structure definition, even to specify \<xref:System.ValueType>.  
  
-   **Implementation.** If the structure uses the [Implements Statement](../VS_visualbasic/implements-statement.md), you must implement every member defined by every interface you specify in `interfacenames`.  
  
-   **Default Property.** A structure can specify at most one property as its *default property*, using the [Default](../VS_visualbasic/default--visual-basic-.md) modifier. For more information, see [Default](../VS_visualbasic/default--visual-basic-.md).  
  
## Behavior  
  
-   **Access Level.** Within a structure, you can declare each member with its own access level. All structure members default to [Public](../VS_visualbasic/public--visual-basic-.md) access. Note that if the structure itself has a more restricted access level, this automatically restricts access to its members, even if you adjust their access levels with the access modifiers.  
  
-   **Scope.** A structure is in scope throughout its containing namespace, class, structure, or module.  
  
     The scope of every structure member is the entire structure.  
  
-   **Lifetime.** A structure does not itself have a lifetime. Rather, each instance of that structure has a lifetime independent of all other instances.  
  
     The lifetime of an instance begins when it is created by a [New Operator](../VS_visualbasic/new-operator--visual-basic-.md) clause. It ends when the lifetime of the variable that holds it ends.  
  
     You cannot extend the lifetime of a structure instance. An approximation to static structure functionality is provided by a module. For more information, see [Module Statement](../VS_visualbasic/module-statement.md).  
  
     Structure members have lifetimes depending on how and where they are declared. For more information, see "Lifetime" in [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md).  
  
-   **Qualification.** Code outside a structure must qualify a member's name with the name of that structure.  
  
     If code inside a nested structure makes an unqualified reference to a programming element, Visual Basic searches for the element first in the nested structure, then in its containing structure, and so on out to the outermost containing element. For more information, see [References to Declared Elements](../VS_visualbasic/references-to-declared-elements--visual-basic-.md).  
  
-   **Memory Consumption.** As with all composite data types, you cannot safely calculate the total memory consumption of a structure by adding together the nominal storage allocations of its members. Furthermore, you cannot safely assume that the order of storage in memory is the same as your order of declaration. If you need to control the storage layout of a structure, you can apply the \<xref:System.Runtime.InteropServices.StructLayoutAttribute> attribute to the `Structure` statement.  
  
## Example  
 The following example uses the `Structure` statement to define a set of related data for an employee. It shows the use of `Public`, `Friend`, and `Private` members to reflect the sensitivity of the data items. It also shows procedure, property, and event members.  
  
 [!code[VbVbalrStatements#57](../VS_visualbasic/codesnippet/VisualBasic/structure-statement_1.vb)]  
  
## See Also  
 [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md)   
 [Interface Statement](../VS_visualbasic/interface-statement--visual-basic-.md)   
 [Module Statement](../VS_visualbasic/module-statement.md)   
 [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md)   
 [Const Statement](../VS_visualbasic/const-statement--visual-basic-.md)   
 [Enum Statement](../VS_visualbasic/enum-statement--visual-basic-.md)   
 [Event Statement](../VS_visualbasic/event-statement.md)   
 [Operator Statement](../VS_visualbasic/operator-statement.md)   
 [Property Statement](../VS_visualbasic/property-statement.md)   
 [Structures and Classes](../VS_visualbasic/structures-and-classes--visual-basic-.md)