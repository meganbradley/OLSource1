---
title: "Storage-Class Specifiers for External-Level Declarations"
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
  - "external definitions"
  - "linkage [C++], external"
  - "external linkage, variable declarations"
  - "declaring variables, external variables"
  - "declarations [C++], external"
  - "declarations [C++], specifiers"
  - "external declarations"
  - "static variables, external declarations"
  - "variables, visibility"
  - "external linkage, storage-class specifiers"
  - "referencing declarations"
  - "visibility, variables"
  - "static storage class specifiers"
ms.assetid: b76b623a-80ec-4d5d-859b-6cef422657ee
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Storage-Class Specifiers for External-Level Declarations
External variables are variables at file scope. They are defined outside any function, and they are potentially available to many functions. Functions can only be defined at the external level and, therefore, cannot be nested. By default, all references to external variables and functions of the same name are references to the same object, which means they have "external linkage." (You can use the **static** keyword to override this. See information later in this section for more details on **static**.)  
  
 Variable declarations at the external level are either definitions of variables ("defining declarations"), or references to variables defined elsewhere ("referencing declarations").  
  
 An external variable declaration that also initializes the variable (implicitly or explicitly) is a defining declaration of the variable. A definition at the external level can take several forms:  
  
-   A variable that you declare with the **static** storage-class specifier. You can explicitly initialize the **static** variable with a constant expression, as described in [Initialization](../vs140/initialization.md). If you omit the initializer, the variable is initialized to 0 by default. For example, these two statements are both considered definitions of the variable <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   A variable that you explicitly initialize at the external level. For example, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a definition of the variable <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 In variable declarations at the external level (that is, outside all functions), you can use the **static** or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> storage-class specifier or omit the storage-class specifier entirely. You cannot use the **auto** and **register** *storage-class-specifier* terminals at the external level.  
  
 Once a variable is defined at the external level, it is visible throughout the rest of the translation unit. The variable is not visible prior to its declaration in the same source file. Also, it is not visible in other source files of the program, unless a referencing declaration makes it visible, as described below.  
  
 The rules relating to **static** include:  
  
-   Variables declared outside all blocks without the **static** keyword always retain their values throughout the program. To restrict their access to a particular translation unit, you must use the **static** keyword. This gives them "internal linkage." To make them global to an entire program, omit the explicit storage class or use the keyword <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (see the rules in the next list). This gives them "external linkage." Internal and external linkage are also discussed in [Linkage](../vs140/linkage.md).  
  
-   You can define a variable at the external level only once within a program. You can define another variable with the same name and the **static** storage-class specifier in a different translation unit. Since each **static** definition is visible only within its own translation unit, no conflict occurs. This provides a useful way to hide identifier names that must be shared among functions of a single translation unit, but not visible to other translation units.  
  
-   The **static** storage-class specifier can apply to functions as well. If you declare a function **static**, its name is invisible outside of the file in which it is declared.  
  
 The rules for using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are:  
  
-   The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> storage-class specifier declares a reference to a variable defined elsewhere. You can use an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> declaration to make a definition in another source file visible, or to make a variable visible prior to its definition in the same source file. Once you have declared a reference to the variable at the external level, the variable is visible throughout the remainder of the translation unit in which the declared reference occurs.  
  
-   For an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> reference to be valid, the variable it refers to must be defined once, and only once, at the external level. This definition (without the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> storage class) can be in any of the translation units that make up the program.  
  
## Example  
 The example below illustrates external declarations:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The two source files in this example contain a total of three external declarations of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Only one declaration is a "defining declaration." That declaration,  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 defines the global variable <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and initializes it with initial value 3. The "referencing" declaration of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> at the top of the first source file using <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> makes the global variable visible prior to its defining declaration in the file. The referencing declaration of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> in the second source file also makes the variable visible in that source file. If a defining instance for a variable is not provided in the translation unit, the compiler assumes there is an  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 referencing declaration and that a defining reference  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 appears in another translation unit of the program.  
  
 All three functions, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, perform the same task: they increase <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and print it. The values 4, 5, and 6 are printed.  
  
 If the variable <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> had not been initialized, it would have been set to 0 automatically. In this case, the values 1, 2, and 3 would have been printed. See [Initialization](../vs140/initialization.md) for information about variable initialization.  
  
## See Also  
 [C Storage Classes](../vs140/c-storage-classes.md)