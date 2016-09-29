---
title: "Partial (Visual Basic)"
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
  - "vb.Partial"
  - "partial"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "structures, partial"
  - "classes [Visual Basic]"
  - "partial, types [Visual Basic]"
  - "partial, structures"
  - "partial, classes [Visual Basic]"
  - "classes [Visual Basic], partial"
  - "Partial keyword [Visual Basic]"
  - "type promotion"
ms.assetid: 7adaef80-f435-46e1-970a-269fff63b448
caps.latest.revision: 40
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Partial (Visual Basic)
Indicates that a type declaration is a partial definition of the type.  
  
 You can divide the definition of a type among several declarations by using the `Partial` keyword. You can use as many partial declarations as you want, in as many different source files as you want. However, all the declarations must be in the same assembly and the same namespace.  
  
> [!NOTE]
>  Visual Basic supports *partial methods*, which are typically implemented in partial classes. For more information, see [Partial Methods](../VS_csharp/partial-methods--visual-basic-.md) and [Sub Statement](../VS_csharp/sub-statement--visual-basic-.md).  
  
## Syntax  
  
```  
[ <attrlist> ] [ accessmodifier ] [ Shadows ] [ MustInherit | NotInheritable ] _  
Partial { Class | Structure | Interface | Module } name [ (Of typelist) ]  
    [ Inherits classname ]  
    [ Implements interfacenames ]  
    [ variabledeclarations ]  
    [ proceduredeclarations ]  
{ End Class | End Structure }  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`attrlist`|Optional. List of attributes that apply to this type. You must enclose the [Attribute List](../VS_csharp/attribute-list--visual-basic-.md) in angle brackets (`< >`).|  
|`accessmodifier`|Optional. Specifies what code can access this type. See [Access Levels in Visual Basic](../VS_csharp/access-levels-in-visual-basic.md).|  
|`Shadows`|Optional. See [Shadows](../VS_csharp/shadows--visual-basic-.md).|  
|`MustInherit`|Optional. See [MustInherit](../VS_csharp/mustinherit--visual-basic-.md).|  
|`NotInheritable`|Optional. See [NotInheritable](../VS_csharp/notinheritable--visual-basic-.md).|  
|`name`|Required. Name of this type. Must match the name defined in all other partial declarations of the same type.|  
|`Of`|Optional. Specifies that this is a generic type. See [Generic Types in Visual Basic](../VS_csharp/generic-types-in-visual-basic--visual-basic-.md).|  
|`typelist`|Required if you use [Of](../VS_csharp/of-clause--visual-basic-.md). See [Type List](../VS_csharp/type-list--visual-basic-.md).|  
|`Inherits`|Optional. See [Inherits Statement](../VS_csharp/inherits-statement.md).|  
|`classname`|Required if you use `Inherits`. The name of the class or interface from which this class derives.|  
|`Implements`|Optional. See [Implements Statement](../VS_csharp/implements-statement.md).|  
|`interfacenames`|Required if you use `Implements`. The names of the interfaces this type implements.|  
|`variabledeclarations`|Optional. Statements which declare additional variables and events for the type.|  
|`proceduredeclarations`|Optional. Statements which declare and define additional procedures for the type.|  
|`End Class` or `End Structure`|Ends this partial `Class` or `Structure` definition.|  
  
## Remarks  
 Visual Basic uses partial-class definitions to separate generated code from user-authored code in separate source files. For example, the **Windows Form Designer** defines partial classes for controls such as <xref:System.Windows.Forms.Form*>. You should not modify the generated code in these controls.  
  
 All the rules for class, structure, interface, and module creation, such as those for modifier usage and inheritance, apply when creating a partial type.  
  
## Best Practices  
  
-   Under normal circumstances, you should not split the development of a single type across two or more declarations. Therefore, in most cases you do not need the `Partial` keyword.  
  
-   For readability, every partial declaration of a type should include the `Partial` keyword. The compiler allows at most one partial declaration to omit the keyword; if two or more omit it the compiler signals an error.  
  
## Behavior  
  
-   **Union of Declarations.** The compiler treats the type as the union of all its partial declarations. Every modifier from every partial definition applies to the entire type, and every member from every partial definition is available to the entire type.  
  
-   **Type Promotion Not Allowed For Partial Types in Modules.** If a partial definition is inside a module, type promotion of that type is automatically defeated. In such a case, a set of partial definitions can cause unexpected results and even compiler errors. For more information, see [Type Promotion](../VS_csharp/type-promotion--visual-basic-.md).  
  
     The compiler merges partial definitions only when their fully qualified paths are identical.  
  
 The `Partial` keyword can be used in these contexts:  
  
 [Class Statement](../VS_csharp/class-statement--visual-basic-.md)  
  
 [Structure Statement](../VS_csharp/structure-statement.md)  
  
## Example  
 The following example splits the definition of class `sampleClass` into two declarations, each of which defines a different `Sub` procedure.  
  
 [!code[VbVbalrKeywords#3](../VS_csharp/codesnippet/VisualBasic/partial--visual-basic-_1.vb)]  
  
 The two partial definitions in the preceding example could be in the same source file or in two different source files.  
  
## See Also  
 [Class Statement](../VS_csharp/class-statement--visual-basic-.md)   
 [Structure Statement](../VS_csharp/structure-statement.md)   
 [Type Promotion](../VS_csharp/type-promotion--visual-basic-.md)   
 [Shadows](../VS_csharp/shadows--visual-basic-.md)   
 [Generic Types in Visual Basic](../VS_csharp/generic-types-in-visual-basic--visual-basic-.md)   
 [Partial Methods](../VS_csharp/partial-methods--visual-basic-.md)