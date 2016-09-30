---
title: "Aliases and typedefs (C++)"
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
  - "typedef"
dev_langs: 
  - "C++"
ms.assetid: af1c24d2-4bfd-408a-acfc-482e264232f5
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Aliases and typedefs (C++)
You can use an *alias declaration* to declare a name to use as a synonym for a previously declared type. (This mechanism is also referred to informally as a *type alias*). You can also use this mechanism to create an *alias template*, which can be particularly useful for custom allocators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The name of the alias.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The type identifier you are creating an alias for.  
  
 An alias does not introduce a new type and cannot change the meaning of an existing type name.  
  
 The simplest form of an alias is equivalent to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> mechanism from C++03:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Both of these enable the creation of variables of type "counter". Something more useful would be a type alias like this one for <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Aliases also work with function pointers, but much more readable than typedef's equivalent:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A limitation of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> mechanism is that it doesn't work with templates. However, the type alias syntax in C++11 enables the creation of alias templates:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates how to use an alias template with a custom allocator—in this case, an integer vector type. You can substitute any type for <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to create a convenient alias to hide the complex parameter lists in your main functional code. By using the custom allocator throughout your code you can improve readability and reduce the risk of introducing bugs caused by typos.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Output  
 **1701 1764 1664**   
## Typedefs  
 A <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> declaration introduces a name that, within its scope, becomes a synonym for the type given by the *type-declaration* portion of the declaration.  
  
 You can use typedef declarations to construct shorter or more meaningful names for types already defined by the language or for types that you have declared. Typedef names allow you to encapsulate implementation details that may change.  
  
 In contrast to the **class**, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, **union**, and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> declarations, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> declarations do not introduce new types — they introduce new names for existing types.  
  
 Names declared using <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> occupy the same namespace as other identifiers (except statement labels). Therefore, they cannot use the same identifier as a previously declared name, except in a class-type declaration. Consider the following example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The name-hiding rules that pertain to other identifiers also govern the visibility of names declared using <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. Therefore, the following example is legal in C++:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
-   [Redeclaration of typedef Names](../vs140/redeclaration-of-typedef-names.md)  
  
-   [Use of typedef with Class Types](../vs140/use-of-typedef-with-class-types.md)  
  
-   [Namespace of typedef Names](../vs140/name-space-of-typedef-names.md)  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 When declaring a local-scope identifier by the same name as a typedef, or when declaring a member of a structure or union in the same scope or in an inner scope, the type specifier must be specified. For example:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 To reuse the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> name for an identifier, a structure member, or a union member, the type must be provided:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 It is not sufficient to say  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 because the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is taken to be part of the type, not an identifier that is being redeclared. This declaration is taken to be an illegal declaration like  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 You can declare any type with typedef, including pointer, function, and array types. You can declare a typedef name for a pointer to a structure or union type before you define the structure or union type, as long as the definition has the same visibility as the declaration.  
  
### Examples  
 One use of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> declarations is to make declarations more uniform and compact. For example:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 To use <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to specify fundamental and derived types in the same declaration, you can separate declarators with commas. For example:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The following example provides the type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> for a function returning no value and taking two int arguments:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 After the above <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> statement, the declaration  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 would be equivalent to the declaration  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is often combined with <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to declare and name user-defined types:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 **10   0.990000**   
### Re-declaration of typedefs  
 The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> declaration can be used to redeclare the same name to refer to the same type. For example:  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The program PROG.CPP includes two header files, both of which contain <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> declarations for the name <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. As long as both declarations refer to the same type, such redeclaration is acceptable.  
  
 A <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> cannot redefine a name that was previously declared as a different type. Therefore, if FILE2.H contains  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 the compiler issues an error because of the attempt to redeclare the name <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to refer to a different type. This extends to constructs such as:  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### typedefs in C++ vs. C  
 Use of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> specifier with class types is supported largely because of the ANSI C practice of declaring unnamed structures in <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> declarations. For example, many C programmers use the following:  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The advantage of such a declaration is that it enables declarations like:  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 instead of:  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 In C++, the difference between <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> names and real types (declared with the **class**, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, **union**, and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> keywords) is more distinct. Although the C practice of declaring a nameless structure in a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> statement still works, it provides no notational benefits as it does in C.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The preceding example declares a class named <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> using the unnamed class <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> syntax. <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is treated as a class name; however, the following restrictions apply to names introduced this way:  
  
-   The name (the synonym) cannot appear after a **class**, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, or **union** prefix.  
  
-   The name cannot be used as constructor or destructor names within a class declaration.  
  
 In summary, this syntax does not provide any mechanism for inheritance, construction, or destruction.  
  
## See Also  
 [using Keyword](../vs140/using-keyword.md)