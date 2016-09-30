---
title: "Typedef Declarations"
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
  - "declarations, typedef"
  - "typedef declarations"
  - "types [C], declarations"
ms.assetid: e92a3b82-9269-4bc6-834a-6f431ccac83e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Typedef Declarations
A typedef declaration is a declaration with typedef as the storage class. The declarator becomes a new type. You can use typedef declarations to construct shorter or more meaningful names for types already defined by C or for types that you have declared. Typedef names allow you to encapsulate implementation details that may change.  
  
 A typedef declaration is interpreted in the same way as a variable or function declaration, but the identifier, instead of assuming the type specified by the declaration, becomes a synonym for the type.  
  
## Syntax  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>:  
 *declaration-specifiers init-declarator-list* opt**;**  
  
 *declaration-specifiers*:  
 *storage-class-specifier declaration-specifiers* opt  
  
 *type-specifier declaration-specifiers* opt  
  
 *type-qualifier declaration-specifiers* opt  
  
 *storage-class-specifier*:  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 *type-specifier*:  
 **void**  
  
 **char**  
  
 **short**  
  
 **int**  
  
 **long**  
  
 **float**  
  
 **double**  
  
 **signed**  
  
 **unsigned**  
  
 *struct-or-union-specifier*  
  
 *enum-specifier*  
  
 *typedef-name*  
  
 *typedef-name*:  
 *identifier*  
  
 Note that a typedef declaration does not create types. It creates synonyms for existing types, or names for types that could be specified in other ways. When a typedef name is used as a type specifier, it can be combined with certain type specifiers, but not others. Acceptable modifiers include **const** and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 Typedef names share the name space with ordinary identifiers (see [Name Spaces](../vs140/name-spaces.md) for more information). Therefore, a program can have a typedef name and a local-scope identifier by the same name. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When declaring a local-scope identifier by the same name as a typedef, or when declaring a member of a structure or union in the same scope or in an inner scope, the type specifier must be specified. This example illustrates this constraint:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To reuse the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> name for an identifier, a structure member, or a union member, the type must be provided:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 It is not sufficient to say  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 because the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is taken to be part of the type, not an identifier that is being redeclared. This declaration is taken to be an illegal declaration like  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 You can declare any type with typedef, including pointer, function, and array types. You can declare a typedef name for a pointer to a structure or union type before you define the structure or union type, as long as the definition has the same visibility as the declaration.  
  
 Typedef names can be used to improve code readability. All three of the following declarations of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> specify exactly the same type, the first without making use of any typedef names.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Examples  
 The following examples illustrate typedef declarations:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Note that <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> could now be used in a variable declaration such as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. However, the declaration <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> would be illegal.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 This statement declares <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> as a structure type with three members. Since a structure tag, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, is also specified, either the typedef name (<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>) or the structure tag can be used in declarations. You must use the struct keyword with the tag, and you cannot use the struct keyword with the typedef name.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is declared as a pointer to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> type, which in turn is defined as a structure type.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 This example provides the type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> for a function returning no value and taking two int arguments. This means, for example, that the declaration  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 is equivalent to the declaration  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## See Also  
 [(NOTINBUILD)typedef Specifier](assetId:///cc96cf26-ba93-4179-951e-695d1f5fdcf1)