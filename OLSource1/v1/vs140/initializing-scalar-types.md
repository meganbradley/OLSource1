---
title: "Initializing Scalar Types"
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
  - "initializing scalar types"
  - "register variables"
  - "initialization, scalar types"
  - "initializing variables, scalar types"
  - "scalar types"
  - "static variables, initializing"
  - "automatic storage class, initializing scalar types"
  - "automatic storage class"
  - "types [C], initializing"
ms.assetid: 73c516f5-c3ad-4d56-ab3b-f2a82b621104
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Initializing Scalar Types
When initializing scalar types, the value of the *assignment-expression* is assigned to the variable. The conversion rules for assignment apply. (See [Type Conversions](../vs140/type-conversions--c-.md) for information on conversion rules.)  
  
## Syntax  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>:  
 *declaration-specifiers init-declarator-list* opt**;**  
  
 *declaration-specifiers*:  
 *storage-class-specifier declaration-specifiers* opt  
  
 *type-specifier declaration-specifiers* opt  
  
 *type-qualifier declaration-specifiers* opt  
  
 *init-declarator-list*:  
 *init-declarator*  
  
 *init-declarator-list*  **,**  *init-declarator*  
  
 *init-declarator*:  
 *declarator*  
  
 *declarator*  **=**  *initializer* /* For scalar initialization \*/  
  
 *initializer*:  
 *assignment-expression*  
  
 You can initialize variables of any type, provided that you obey the following rules:  
  
-   Variables declared at the file-scope level can be initialized. If you do not explicitly initialize a variable at the external level, it is initialized to 0 by default.  
  
-   A constant expression can be used to initialize any global variable declared with the **static** *storage-class-specifier*. Variables declared to be **static** are initialized when program execution begins. If you do not explicitly initialize a global **static** variable, it is initialized to 0 by default, and every member that has pointer type is assigned a null pointer.  
  
-   Variables declared with the **auto** or **register** storage-class specifier are initialized each time execution control passes to the block in which they are declared. If you omit an initializer from the declaration of an **auto** or **register** variable, the initial value of the variable is undefined. For automatic and register values, the initializer is not restricted to being a constant; it can be any expression involving previously defined values, even function calls.  
  
-   The initial values for external variable declarations and for all **static** variables, whether external or internal, must be constant expressions. (For more information, see [Constant Expressions](../vs140/c-constant-expressions.md).) Since the address of any externally declared or static variable is constant, it can be used to initialize an internally declared **static** pointer variable. However, the address of an **auto** variable cannot be used as a static initializer because it may be different for each execution of the block. You can use either constant or variable values to initialize **auto** and **register** variables.  
  
-   If the declaration of an identifier has block scope, and the identifier has external linkage, the declaration cannot have an initialization.  
  
## Examples  
 The following examples illustrate initializations:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The integer variable <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is initialized to the constant expression <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The pointer <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is initialized to 0, producing a "null" pointer.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example uses a constant expression <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to initialize <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to a constant value that cannot be modified because of the **const** keyword.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This statement initializes the pointer <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with the address of another variable, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The pointer <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is initialized with the address of a variable named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. However, since it is specified to be a **const**, the variable <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can only be initialized, never modified. It always points to the same location.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The global variable <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is declared at the external level, so it has global lifetime. The local variable <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> has **auto** storage class and only has an address during the execution of the function in which it is declared. Therefore, attempting to initialize the **static** pointer variable <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> with the address of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is not permitted. The **static** pointer variable <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> can be initialized to the address of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> because that address is always the same. Similarly, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> can be initialized because <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a local variable and can have a nonconstant initializer. Each time the block is entered, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> has a new address, which is then assigned to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
## See Also  
 [Initialization](../vs140/initialization.md)