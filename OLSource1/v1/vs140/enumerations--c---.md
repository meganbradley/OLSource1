---
title: "Enumerations (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "enum"
  - "enum_cpp"
  - "enum class"
  - "enum struct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "declarations, enumerations"
  - "enumerators, declaring"
  - "enum keyword [C++]"
  - "named constants, enumeration declarations"
  - "declaring enumerations"
ms.assetid: 081829db-5dca-411e-a53c-bffef315bcb3
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Enumerations (C++)
An enumeration is a user-defined type that consists of a set of named integral constants that are known as enumerators.  
  
> [!NOTE]
>  This article covers the ISO Standard C++ Language <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> type and the scoped (or strongly-typed) <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> type which is introduced in C++11. For information about the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> types in C++/CLI and C++/CX, see [enum class (C++ Component Extensions)](../vs140/enum-class---c---component-extensions-.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The type name given to the enumeration.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The underlying type of the enumerators; all enumerators have the same underlying type. May be any integral type.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Comma-separated list of the enumerators in the enumeration. Every enumerator or variable name in the scope must be unique. However, the values can be duplicated. In a unscoped enum, the scope is the surrounding scope; in a scoped enum, the scope is the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> itself.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 By using this keyword in the declaration, you specify the enum is scoped, and an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must be provided. You can also use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> keyword in place of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, as they are semantically equivalent in this context.  
  
## Remarks  
 An enumeration provides context to describe a range of values which are represented as named constants and are also called enumerators. In the original C and C++ enum types, the unqualified enumerators are visible throughout the scope in which the enum is declared. In scoped enums, the enumerator name must be qualified by the enum type name. The following example demonstrates this basic difference between the two kinds of enums:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Every name in an enumeration is assigned an integral value that corresponds to its place in the order of the values in the enumeration. By default, the first value is assigned 0, the next one is assigned 1, and so on, but you can explicitly set the value of an enumerator, as shown here:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The enumerator <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is assigned the value <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Subsequent enumerators, if they are not given an explicit value, receive the value of the previous enumerator plus one. In the previous example, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> would have the value 2, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> would have 3, and so on.  
  
 Every enumerator is treated as a constant and must have a unique name within the scope where the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is defined (for unscoped enums) or within the enum itself (for scoped enums). The values given to the names do not have to be unique. For example, if the declaration of a unscoped enum <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is this:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Then the values of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are 5, 6, 4, and 5, respectively. Notice that 5 is used more than once; this is allowed even though it may not be intended. These rules are the same for scoped enums.  
  
 **Casting rules**  
  
 Unscoped enum constants can be implicitly converted to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, but an <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is never implicitly convertible to an enum value. The following example shows what happens if you try to assign <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> a value that is not a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A cast is required to convert an <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to a scoped or unscoped enumerator. However, you can promote a unscoped enumerator to an integer value without a cast.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Using implicit conversions in this way can lead to unintended side-effects. To help eliminate programming errors associated with unscoped enums, scoped enum values are strongly typed. Scoped enumerators must be qualified by the enum type name (identifier) and cannot be implicitly converted, as shown in the following example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Notice that the line <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> still causes the error that occurs with unscoped enums, as shown earlier. It is allowed with an explicit cast. However, with scoped enums, the attempted conversion in the next statement, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, is no longer allowed without an explicit cast.  
  
## See Also  
 [C Enumeration Declarations](../vs140/c-enumeration-declarations.md)   
 [Keywords](../vs140/keywords--c---.md)