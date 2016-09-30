---
title: "Interpreting More Complex Declarators"
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
  - "complex declarators"
  - "interpreting complex declarators"
ms.assetid: dd5b7019-c86d-4645-a5cc-21f834de6f4a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interpreting More Complex Declarators
You can enclose any declarator in parentheses to specify a particular interpretation of a "complex declarator." A complex declarator is an identifier qualified by more than one array, pointer, or function modifier. You can apply various combinations of array, pointer, and function modifiers to a single identifier. Generally <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> may be used to simplify declarations. See [Typedef Declarations](../vs140/typedef-declarations.md).  
  
 In interpreting complex declarators, brackets and parentheses (that is, modifiers to the right of the identifier) take precedence over asterisks (that is, modifiers to the left of the identifier). Brackets and parentheses have the same precedence and associate from left to right. After the declarator has been fully interpreted, the type specifier is applied as the last step. By using parentheses you can override the default association order and force a particular interpretation. Never use parentheses, however, around an identifier name by itself. This could be misinterpreted as a parameter list.  
  
 A simple way to interpret complex declarators is to read them "from the inside out," using the following four steps:  
  
1.  Start with the identifier and look directly to the right for brackets or parentheses (if any).  
  
2.  Interpret these brackets or parentheses, then look to the left for asterisks.  
  
3.  If you encounter a right parenthesis at any stage, go back and apply rules 1 and 2 to everything within the parentheses.  
  
4.  Apply the type specifier.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the steps are numbered in order and can be interpreted as follows:  
  
1.  The identifier <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is declared as  
  
2.  a pointer to  
  
3.  a function returning  
  
4.  a pointer to  
  
5.  an array of 10 elements, which are  
  
6.  pointers to  
  
7.  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> values.  
  
## Examples  
 The following examples illustrate other complex declarations and show how parentheses can affect the meaning of a declaration.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The array modifier has higher priority than the pointer modifier, so <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is declared to be an array. The pointer modifier applies to the type of the array elements; therefore, the array elements are pointers to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> values.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In this declaration for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, parentheses give the pointer modifier higher priority than the array modifier, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is declared to be a pointer to an array of five <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> values.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Function modifiers also have higher priority than pointer modifiers, so this declaration for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> declares <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to be a function returning a pointer to a **long** value. The function is declared to take two **long** values as arguments.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This example is similar to the previous one. Parentheses give the pointer modifier higher priority than the function modifier, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is declared to be a pointer to a function that returns a **long** value. Again, the function takes two **long** arguments.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The elements of an array cannot be functions, but this declaration demonstrates how to declare an array of pointers to functions instead. In this example, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is declared to be an array of five pointers to functions that return structures with two members. The arguments to the functions are declared to be two structures with the same structure type, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Note that the parentheses surrounding <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are required. Without them, the declaration is an illegal attempt to declare an array of functions, as shown below:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The following statement declares an array of pointers.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> array has 50 elements organized in a multidimensional array. The elements are pointers to a pointer that is a constant. This constant pointer points to a function that has no parameters and returns a pointer to an unsigned type.  
  
 This next example is a function returning a pointer to an array of three **double** values.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 In this declaration, a function returns a pointer to an array, since functions returning arrays are illegal. Here <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is declared to be a function returning a pointer to an array of three **double** values. The function <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> takes one argument. The argument, like the return value, is a pointer to an array of three **double** values. The argument type is given by a complex *abstract-declarator*. The parentheses around the asterisk in the argument type are required; without them, the argument type would be an array of three pointers to **double** values. For a discussion and examples of abstract declarators, see [Abstract Declarators](../vs140/c-abstract-declarators.md).  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 As the above example shows, a pointer can point to another pointer, and an array can contain arrays as elements. Here <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is an array of five elements. Each element is a five-element array of pointers to pointers to unions with two members.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 This example shows how the placement of parentheses changes the meaning of the declaration. In this example, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is a five-element array of pointers to five-element arrays of pointers to unions. For examples of how to use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to avoid complex declarations, see [Typedef Declarations](../vs140/typedef-declarations.md).  
  
## See Also  
 [Declarations and Types](../vs140/declarations-and-types.md)