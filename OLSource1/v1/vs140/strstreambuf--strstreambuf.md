---
title: "strstreambuf::strstreambuf"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "strstreambuf.strstreambuf"
  - "std::strstreambuf::strstreambuf"
  - "strstreambuf"
  - "strstreambuf::strstreambuf"
  - "std.strstreambuf.strstreambuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strstreambuf class, constructor"
  - "strstreambuf method"
ms.assetid: 6a14fd53-744d-4a4b-b9bd-e6dd33a44619
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstreambuf::strstreambuf
Constructs an object of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *_Allocfunc*  
 The function used to allocate buffer memory.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Determines the length of the buffer pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not an argument (first constructor form), a suggested allocation size for the buffers.  
  
 *_Freefunc*  
 The function used to free buffer memory.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A buffer used for input.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A buffer used for output.  
  
## Remarks  
 The first constructor stores a null pointer in all the pointers controlling the input buffer, the output buffer, and strstreambuf allocation. It sets the stored strstreambuf mode to make the controlled sequence modifiable and extendable. It also accepts <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> as a suggested initial allocation size.  
  
 The second constructor behaves like the first, except that it stores _*Allocfunc* as the pointer to the function to call to allocate storage and \_*Freefunc* as the pointer to the function to call to free that storage.  
  
 The three constructors:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 also behave like the first, except that <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> designates the array object used to hold the controlled sequence. (Hence, it must not be a null pointer.) The number of elements *N* in the array is determined as follows:  
  
-   If (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> > 0), then *N* is **count**.  
  
-   If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> == 0), then *N* is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>( (**const** <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> *)<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> ).  
  
-   If (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> < 0), then *N* is **INT_MAX**.  
  
 If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a null pointer, the function establishes just an input buffer by executing:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Otherwise, it establishes both input and output buffers by executing:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 In this case, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> must be in the interval [<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> + *N*].  
  
 Finally, the three constructors:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 all behave the same as:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 except that the stored mode makes the controlled sequence neither modifiable nor extendable.  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)