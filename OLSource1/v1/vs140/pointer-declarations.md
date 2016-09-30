---
title: "Pointer Declarations"
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
  - "pointer declarations"
  - "declarations, pointers"
  - "const keyword [C]"
  - "pointers, declarations"
ms.assetid: 8b3b7fc7-f44d-480d-b6f9-cebe4e5462a6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Pointer Declarations
A "pointer declaration" names a pointer variable and specifies the type of the object to which the variable points. A variable declared as a pointer holds a memory address.  
  
## Syntax  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>:  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>opt*direct-declarator*  
  
 *direct-declarator*:  
 *identifier*  
  
 **(**  *declarator*  **)**  
  
 *direct-declarator*  **[**  *constant-expression*opt**]**  
  
 *direct-declarator*  **(**  *parameter-type-list*  **)**  
  
 *direct-declarator*  **(**  *identifier-list*opt**)**  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>:  
 **\*** *type-qualifier-list*opt  
  
 **\*** *type-qualifier-list*opt<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 *type-qualifier-list*:  
 *type-qualifier*  
  
 *type-qualifier-list type-qualifier*  
  
 The *type-specifier* gives the type of the object, which can be any basic, structure, or union type. Pointer variables can also point to functions, arrays, and other pointers. (For information on declaring and interpreting more complex pointer types, refer to [Interpreting More Complex Declarators](../vs140/interpreting-more-complex-declarators.md).)  
  
 By making the *type-specifier* <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, you can delay specification of the type to which the pointer refers. Such an item is referred to as a "pointer to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>" and is written as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. A variable declared as a pointer to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> can be used to point to an object of any type. However, to perform most operations on the pointer or on the object to which it points, the type to which it points must be explicitly specified for each operation. (Variables of type **char \*** and type **void \*** are assignment-compatible without a type cast.) Such conversion can be accomplished with a type cast (see [Type-Cast Conversions](../vs140/type-cast-conversions.md) for more information).  
  
 The *type-qualifier* can be either **const** or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, or both. These specify, respectively, that the pointer cannot be modified by the program itself (**const**), or that the pointer can legitimately be modified by some process beyond the control of the program (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>). (See [Type Qualifiers](../vs140/type-qualifiers.md) for more information on **const** and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.)  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> names the variable and can include a type modifier. For example, if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> represents an array, the type of the pointer is modified to be a pointer to an array.  
  
 You can declare a pointer to a structure, union, or enumeration type before you define the structure, union, or enumeration type. You declare the pointer by using the structure or union tag as shown in the examples below. Such declarations are allowed because the compiler does not need to know the size of the structure or union to allocate space for the pointer variable.  
  
## Examples  
 The following examples illustrate pointer declarations.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> pointer points to a variable with <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> type.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> array has 10 elements; each element is a pointer to a variable with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The pointer variable points to an array with 10 elements. Each element in this array has <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The pointer <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> can be modified to point to a different <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> value, but the value to which it points cannot be modified.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The variable <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> in these declarations is declared as a constant pointer to an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> value. The value it points to can be modified, but the pointer itself must always point to the same location: the address of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. Similarly, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is a constant pointer, but it is also declared to point to an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> whose value cannot be modified by the program. The additional specifier <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> indicates that although the value of the **const int** pointed to by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> cannot be modified by the program, it could legitimately be modified by a process running concurrently with the program. The declaration of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> specifies that the program cannot change the value pointed to and that the program cannot modify the pointer.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 This example declares two pointer variables, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, that point to the structure type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. This declaration can appear before the definition of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> structure type (see the next example), as long as the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> type definition has the same visibility as the declaration.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The variable <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> has the structure type named <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> structure type has three members: the first member is a pointer to a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> value, the second is an <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> value, and the third is a pointer to another <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> structure.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The variable <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> has the structure type <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. Note that <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is declared as a pointer to another structure type named <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. This declaration can appear before the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> type is defined.  
  
## See Also  
 [Declarators and Variable Declarations](../vs140/declarators-and-variable-declarations.md)