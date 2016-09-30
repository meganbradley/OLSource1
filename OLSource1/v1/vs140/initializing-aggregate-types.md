---
title: "Initializing Aggregate Types"
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
  - "aggregate types [C++]"
  - "union keyword [C], declarations"
  - "types [C], initializing"
  - "union keyword [C]"
  - "aggregates [C++], initializing"
ms.assetid: a8f8ed75-39db-4592-93b9-d3920d915810
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Initializing Aggregate Types
An "aggregate" type is a structure, union, or array type. If an aggregate type contains members of aggregate types, the initialization rules apply recursively.  
  
## Syntax  
 *initializer*:  
 **{**  *initializer-list*  **}** /* For aggregate initialization \*/  
  
 **{**  *initializer-list*  **, }**  
  
 *initializer-list*:  
 *initializer*  
  
 *initializer-list*  **,**  *initializer*  
  
 The *initializer-list* is a list of initializers separated by commas. Each initializer in the list is either a constant expression or an initializer list. Therefore, initializer lists can be nested. This form is useful for initializing aggregate members of an aggregate type, as shown in the examples in this section. However, if the initializer for an automatic identifier is a single expression, it need not be a constant expression; it merely needs to have appropriate type for assignment to the identifier.  
  
 For each initializer list, the values of the constant expressions are assigned, in order, to the corresponding members of the aggregate variable.  
  
 If *initializer-list* has fewer values than an aggregate type, the remaining members or elements of the aggregate type are initialized to 0. The initial value of an automatic identifier not explicitly initialized is undefined. If *initializer-list* has more values than an aggregate type, an error results. These rules apply to each embedded initializer list, as well as to the aggregate as a whole.  
  
 A structure's initializer is either an expression of the same type, or a list of initializers for its members enclosed in curly braces (**{ }**). Unnamed bit-field members are not initialized.  
  
 When a union is initialized, *initializer-list* must be a single constant expression. The value of the constant expression is assigned to the first member of the union.  
  
 If an array has unknown size, the number of initializers determines the size of the array, and its type becomes complete. There is no way to specify repetition of an initializer in C, or to initialize an element in the middle of an array without providing all preceding values as well. If you need this operation in your program, write the routine in assembly language.  
  
 Note that the number of initializers can set the size of the array:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you specify the size and give the wrong number of initializers, however, the compiler generates an error.  
  
 **Microsoft Specific**  
  
 The maximum size for an array is defined by **size_t**. Defined in the header file STDDEF.H, **size_t** is an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with the range 0x00000000 to 0x7CFFFFFF.  
  
 **END Microsoft Specific**  
  
## Examples  
 This example shows initializers for an array.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This statement declares <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as a four-by-three array and initializes the elements of its first row to 1, the elements of its second row to 2, and so on through the fourth row. Note that the initializer list for the third and fourth rows contains commas after the last constant expression. The last initializer list (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) is also followed by a comma. These extra commas are permitted but are not required; only commas that separate constant expressions from one another, and those that separate one initializer list from another, are required.  
  
 If an aggregate member has no embedded initializer list, values are simply assigned, in order, to each member of the subaggregate. Therefore, the initialization in the previous example is equivalent to the following:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Braces can also appear around individual initializers in the list and would help to clarify the example above.  
  
 When you initialize an aggregate variable, you must be careful to use braces and initializer lists properly. The following example illustrates the compiler's interpretation of braces in more detail:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 In this example, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is declared as a 2-by-3 array of structures, each structure having three members. Row 1 of the initialization assigns values to the first row of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, as follows:  
  
1.  The first left brace on row 1 signals the compiler that initialization of the first aggregate member of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (that is, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) is beginning.  
  
2.  The second left brace indicates that initialization of the first aggregate member of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (that is, the structure at <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) is beginning.  
  
3.  The first right brace ends initialization of the structure <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>; the next left brace starts initialization of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
4.  The process continues until the end of the line, where the closing right brace ends initialization of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 Row 2 assigns values to the second row of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> in a similar way. Note that the outer sets of braces enclosing the initializers on rows 1 and 2 are required. The following construction, which omits the outer braces, would cause an error:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In this construction, the first left brace on line 1 starts the initialization of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, which is an array of three structures. The values 1, 2, and 3 are assigned to the three members of the first structure. When the next right brace is encountered (after the value 3), initialization of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is complete, and the two remaining structures in the three-structure array are automatically initialized to 0. Similarly, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> initializes the first structure in the second row of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. The remaining two structures of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are set to 0. When the compiler encounters the next initializer list ( <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> ), it tries to initialize <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. Since <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> has only two rows, this attempt causes an error.  
  
 In this next example, the three <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> members of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are initialized to 1, 2, and 3, respectively.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 In the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> structure above, the three elements in the first row of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> are initialized to 4.0; the elements of the remaining row of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are initialized to 0.0 by default.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The union variable <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, in this example, is initialized. The first element of the union is an array, so the initializer is an aggregate initializer. The initializer list <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> assigns values to the first row of the array. Since only one value appears in the list, the element in the first column is initialized to the character <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and the remaining two elements in the row are initialized to the value 0 by default. Similarly, the first element of the second row of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is initialized to the character <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, and the remaining two elements in the row are initialized to the value 0.  
  
## See Also  
 [Initialization](../vs140/initialization.md)