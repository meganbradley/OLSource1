---
title: "Pointers (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "declarators, pointers"
  - "declarations, pointers"
  - "pointers"
  - "pointers, declarations"
ms.assetid: 595387c5-8e58-4670-848f-344c7caf985e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Pointers (C++)
Pointers are declared using the following sequence.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 where any valid pointer declarator may be used for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  The syntax for a simple pointer declarator is as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 1. The declaration specifiers:  
  
-   An optional storage class specifier. For more information, see [Specifiers](../vs140/specifiers.md).  
  
-   An optional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword applying to the type of the object to be pointed to.  
  
-   The type specifier: the name of a type representing the type of the object to be pointed to.  
  
 2. The declarator:  
  
-   An optional Microsoft specific modifier. For more information, see [Microsoft-Specific Modifiers](../vs140/microsoft-specific-modifiers.md).  
  
-   The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> operator.  
  
-   An optional <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword applying to the pointer itself.  
  
-   The identifier.  
  
-   An optional initializer.  
  
 The declarator for a pointer to function looks like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   For an array of pointers, the syntax looks like this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   However, pointer declarators can be more complex. For more information,see [Declarators](assetId:///8a7b9b51-92bd-4ac0-b3fe-0c4abe771838).  
  
-   Multiple declarators and their initializers may appear together in a single declaration in a comma separated list following the declaration specifier.  
  
 A simple example of a pointer declaration is:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The preceding declaration specifies that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> points to an object of type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 A more complex example is  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The preceding declaration specifies that <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a constant pointer to an object of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> with static storage duration.  
  
 The next example shows how multiple pointers are declared and initialized:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 In the preceding example, pointers p and q both point to objects of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and are initialized to the addresses of i and j respectively.  The storage class specifier <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> applies to both pointers.  
  
## Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **0x0012FEC8**  
**0x0012FEC8 2**  
**0x0012FEC8 7**  
**j is 10**  
**0x00320850 5**  
**0x00320850 0**  
**0x00320854 10**  
**0x00320858 20**  
**0x0032085C 30**  
**0x00320860 40**  
**dog dog**   
## Example  
 Another example illustrates the use of pointers in data structures; in this case, a linked list.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>a (add node)  d (display list)  q (quit)**  
**enter a number:**   
**a (add node)  d (display list)  q (quit)**  
**node 1 = 45**  
**a (add node)  d (display list)  q (quit)**  
**enter a number:**   
**a (add node)  d (display list)  q (quit)**  
**node 1 = 45**  
**node 2 = 789**  
**a (add node)  d (display list)  q (quit)**   
## See Also  
 [C++ Abstract Declarators](assetId:///e7e18c18-0cad-4450-942b-d27e1d4dd088)   
 [Addition of Pointer Types](../vs140/addition-of-pointer-types.md)   
 [Indirection Operator: *](../vs140/indirection-operator---.md)   
 [Address-of Operator: &](../vs140/address-of-operator---.md)