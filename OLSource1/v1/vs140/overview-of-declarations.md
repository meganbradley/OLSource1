---
title: "Overview of Declarations"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "declarations, about declarations"
  - "type qualifiers"
ms.assetid: fcd2364c-c2a5-4fbf-9027-19dac4144cb5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overview of Declarations
A "declaration" specifies the interpretation and attributes of a set of identifiers. A declaration that also causes storage to be reserved for the object or function named by the identifier is called a "definition." C declarations for variables, functions, and types have this syntax:  
  
## Syntax  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>:  
 *declaration-specifiers* *attribute-seq*opt*init-declarator-list*opt**;**  
  
 /\* *attribute-seq*opt is Microsoft specific */  
  
 *declaration-specifiers*:  
 *storage-class-specifier declaration-specifiers*opt  
  
 *type-specifier declaration-specifiers*opt  
  
 *type-qualifier declaration-specifiers*opt  
  
 *init-declarator-list*:  
 *init-declarator*  
  
 *init-declarator-list* , *init-declarator*  
  
 *init-declarator*:  
 *declarator*  
  
 *declarator*  **=**  *initializer*  
  
> [!NOTE]
>  This syntax for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is not repeated in the following sections. Syntax in the following sections usually begins with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> nonterminal.  
  
 The declarations in the *init-declarator-list* contain the identifiers being named; *init* is an abbreviation for initializer. The *init-declarator-list* is a comma-separated sequence of declarators, each of which can have additional type information, or an initializer, or both. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> contains the identifiers, if any, being declared. The *declaration-specifiers* nonterminal consists of a sequence of type and storage-class specifiers that indicate the linkage, storage duration, and at least part of the type of the entities that the declarators denote. Therefore, declarations are made up of some combination of storage-class specifiers, type specifiers, type qualifiers, declarators, and initializers.  
  
 Declarations can contain one or more of the optional attributes listed in *attribute-seq*; *seq* is an abbreviation for sequence. These Microsoft-specific attributes perform a variety of functions, which are discussed in detail throughout this book.  
  
 In the general form of a variable declaration, *type-specifier* gives the data type of the variable. The *type-specifier* can be a compound, as when the type is modified by **const** or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> gives the name of the variable, possibly modified to declare an array or a pointer type. For example,  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 declares a variable named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as a pointer to a nonmodifiable (**const**) <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value. You can define more than one variable in a declaration by using multiple declarators, separated by commas.  
  
 A declaration must have at least one declarator, or its type specifier must declare a structure tag, union tag, or members of an enumeration. Declarators provide any remaining information about an identifier. A declarator is an identifier that can be modified with brackets (**[ ]**), asterisks (**\***), or parentheses ( **( )** ) to declare an array, pointer, or function type, respectively. When you declare simple variables (such as character, integer, and floating-point items), or structures and unions of simple variables, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is just an identifier. For more information on declarators, see [Declarators and Variable Declarations](../vs140/declarators-and-variable-declarations.md).  
  
 All definitions are implicitly declarations, but not all declarations are definitions. For example, variable declarations that begin with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> storage-class specifier are "referencing," rather than "defining" declarations. If an external variable is to be referred to before it is defined, or if it is defined in another source file from the one where it is used, an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> declaration is necessary. Storage is not allocated by "referencing" declarations, nor can variables be initialized in declarations.  
  
 A storage class or a type (or both) is required in variable declarations. Except for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, only one storage-class specifier is allowed in a declaration and not all storage-class specifiers are permitted in every context. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> storage class is allowed with other storage-class specifiers, and it is allowed more than once. The storage-class specifier of a declaration affects how the declared item is stored and initialized, and which parts of a program can reference the item.  
  
 The *storage-class-specifier* terminals defined in C include **auto**, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, **register**, **static**, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. In addition, Microsoft C includes the *storage-class-specifier* terminal <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. All *storage-class-specifier* terminals except <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are discussed in [Storage Classes](../vs140/c-storage-classes.md). See [Typedef Declarations](../vs140/typedef-declarations.md) for information about <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. See [Extended Storage-Class Attributes](../vs140/c-extended-storage-class-attributes.md) for information about <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 The location of the declaration within the source program and the presence or absence of other declarations of the variable are important factors in determining the lifetime of variables. There can be multiple redeclarations but only one definition. However, a definition can appear in more than one translation unit. For objects with internal linkage, this rule applies separately to each translation unit, because internally linked objects are unique to a translation unit. For objects with external linkage, this rule applies to the entire program. See [Lifetime, Scope, Visibility, and Linkage](../vs140/lifetime--scope--visibility--and-linkage.md) for more information about visibility.  
  
 Type specifiers provide some information about the data types of identifiers. The default type specifier is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For more information, see [Type Specifiers](../vs140/c-type-specifiers.md). Type specifiers can also define type tags, structure and union component names, and enumeration constants. For more information see [Enumeration Declarations](../vs140/c-enumeration-declarations.md), [Structure Declarations](../vs140/structure-declarations.md), and [Union Declarations](../vs140/union-declarations.md).  
  
 There are two *type-qualifier* terminals: **const** and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. These qualifiers specify additional properties of types that are relevant only when accessing objects of that type through l-values. For more information on **const** and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, see [Type Qualifiers](../vs140/type-qualifiers.md). For a definition of l-values, see [L-Value and R-Value Expressions](../vs140/l-value-and-r-value-expressions.md).  
  
## See Also  
 [C Language Syntax Summary](../vs140/c-language-syntax-summary.md)   
 [Declarations and Types](../vs140/declarations-and-types.md)   
 [Summary of Declarations](../vs140/summary-of-declarations.md)