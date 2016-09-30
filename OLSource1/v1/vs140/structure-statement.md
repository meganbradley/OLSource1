---
title: "Structure Statement"
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
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Structure Statement
Declares the name of a structure and introduces the definition of the variables, properties, events, and procedures that the structure comprises.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional. Can be one of the following:\<br />\<br /> -   [Public](../vs140/public--visual-basic-.md)\<br />-   [Protected](../vs140/protected--visual-basic-.md)\<br />-   [Friend](../vs140/friend--visual-basic-.md)\<br />-   [Private](../vs140/private--visual-basic-.md)\<br />-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>\<br />\<br /> See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional. See [Shadows](../vs140/shadows--visual-basic-.md).|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional. Indicates a partial definition of the structure. See [Partial (Visual Basic)](../vs140/partial--visual-basic-.md).|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required. Name of this structure. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional. Specifies that this is a generic structure.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Required if you use the [Of](../vs140/of-clause--visual-basic-.md) keyword. List of type parameters for this structure. See [Type List](../vs140/type-list--visual-basic-.md).|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional. Indicates that this structure implements the members of one or more interfaces. See [Implements Statement](../vs140/implements-statement.md).|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Required if you use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement. The names of the interfaces this structure implements.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Required. Zero or more <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statements declaring *data members* of the structure.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional. Zero or more declarations of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> procedures, which serve as *method members* of the structure.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Required. Terminates the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> definition.|  
  
## Remarks  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement defines a composite value type that you can customize. A *structure* is a generalization of the user-defined type (UDT) of previous versions of Visual Basic. For more information, see [Structures: Your Own Data Types](../vs140/structures--visual-basic-.md).  
  
 Structures support many of the same features as classes. For example, structures can have properties and procedures, they can implement interfaces, and they can have parameterized constructors. However, there are significant differences between structures and classes in areas such as inheritance, declarations, and usage. Also, classes are reference types and structures are value types. For more information, see [Structures and Classes](../vs140/structures-and-classes--visual-basic-.md).  
  
 You can use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> only at namespace or module level. This means the *declaration context* for a structure must be a source file, namespace, class, structure, module, or interface, and cannot be a procedure or block. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 Structures default to [Friend (Visual Basic)](../vs140/friend--visual-basic-.md) access. You can adjust their access levels with the access modifiers. For more information, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
## Rules  
  
-   **Nesting.** You can define one structure within another. The outer structure is called the *containing structure*, and the inner structure is called a *nested structure*. However, you cannot access a nested structure's members through the containing structure. Instead, you must declare a variable of the nested structure's data type.  
  
-   **Member Declaration.** You must declare every member of a structure. A structure member cannot be [Protected](../vs140/protected--visual-basic-.md) or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> because nothing can inherit from a structure. The structure itself, however, can be <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
     You can declare zero or more nonshared variables or nonshared, noncustom events in a structure. You cannot have only constants, properties, and procedures, even if some of them are nonshared.  
  
-   **Initialization.** You cannot initialize the value of any nonshared data member of a structure as part of its declaration. You must either initialize such a data member by means of a parameterized constructor on the structure, or assign a value to the member after you have created an instance of the structure.  
  
-   **Inheritance.** A structure cannot inherit from any type other than \<xref:System.ValueType*>, from which all structures inherit. In particular, one structure cannot inherit from another.  
  
     You cannot use the [Inherits Statement](../vs140/inherits-statement.md) in a structure definition, even to specify \<xref:System.ValueType*>.  
  
-   **Implementation.** If the structure uses the [Implements Statement](../vs140/implements-statement.md), you must implement every member defined by every interface you specify in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
-   **Default Property.** A structure can specify at most one property as its *default property*, using the [Default (Visual Basic)](../vs140/default--visual-basic-.md) modifier. For more information, see [Default (Visual Basic)](../vs140/default--visual-basic-.md).  
  
## Behavior  
  
-   **Access Level.** Within a structure, you can declare each member with its own access level. All structure members default to [Public (Visual Basic)](../vs140/public--visual-basic-.md) access. Note that if the structure itself has a more restricted access level, this automatically restricts access to its members, even if you adjust their access levels with the access modifiers.  
  
-   **Scope.** A structure is in scope throughout its containing namespace, class, structure, or module.  
  
     The scope of every structure member is the entire structure.  
  
-   **Lifetime.** A structure does not itself have a lifetime. Rather, each instance of that structure has a lifetime independent of all other instances.  
  
     The lifetime of an instance begins when it is created by a [New (Visual Basic)](../vs140/new-operator--visual-basic-.md) clause. It ends when the lifetime of the variable that holds it ends.  
  
     You cannot extend the lifetime of a structure instance. An approximation to static structure functionality is provided by a module. For more information, see [Module Statement](../vs140/module-statement.md).  
  
     Structure members have lifetimes depending on how and where they are declared. For more information, see "Lifetime" in [Class Statement (Visual Basic)](../vs140/class-statement--visual-basic-.md).  
  
-   **Qualification.** Code outside a structure must qualify a member's name with the name of that structure.  
  
     If code inside a nested structure makes an unqualified reference to a programming element, Visual Basic searches for the element first in the nested structure, then in its containing structure, and so on out to the outermost containing element. For more information, see [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md).  
  
-   **Memory Consumption.** As with all composite data types, you cannot safely calculate the total memory consumption of a structure by adding together the nominal storage allocations of its members. Furthermore, you cannot safely assume that the order of storage in memory is the same as your order of declaration. If you need to control the storage layout of a structure, you can apply the \<xref:System.Runtime.InteropServices.StructLayoutAttribute*> attribute to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statement.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statement to define a set of related data for an employee. It shows the use of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> members to reflect the sensitivity of the data items. It also shows procedure, property, and event members.  
  
 [!code[VbVbalrStatements#57](../vs140/codesnippet/VisualBasic/structure-statement_1.vb)]  
  
## See Also  
 [Class Statement (Visual Basic)](../vs140/class-statement--visual-basic-.md)   
 [Interface Statement](../vs140/interface-statement--visual-basic-.md)   
 [Module Statement](../vs140/module-statement.md)   
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [Const Statement (Visual Basic)](../vs140/const-statement--visual-basic-.md)   
 [Enum Statement (Visual Basic)](../vs140/enum-statement--visual-basic-.md)   
 [Event Statement](../vs140/event-statement.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Structures and Classes](../vs140/structures-and-classes--visual-basic-.md)