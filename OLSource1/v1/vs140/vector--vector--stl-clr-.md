---
title: "vector::vector (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::vector (STL/CLR)"
f1_keywords: 
  - "cliext::vector::vector"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "vector member [STL/CLR]"
ms.assetid: a0b5e807-1ef2-422b-b772-1f96cd62fb51
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::vector (STL-CLR)
Constructs a container object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 count  
 Number of elements to insert.  
  
 first  
 Beginning of range to insert.  
  
 last  
 End of range to insert.  
  
 right  
 Object or range to insert.  
  
 val  
 Value of the element to insert.  
  
## Remarks  
 The constructor:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with no elements. You use it to specify an empty initial controlled sequence.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[begin](../vs140/vector--begin--stl-clr-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[end](../vs140/vector--end--stl-clr-.md)<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the vector object <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>[begin](../vs140/vector--begin--stl-clr-.md)<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>[end](../vs140/vector--end--stl-clr-.md)<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the vector object whose handle is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> elements each with value <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. You use it to fill the container with elements all having the default value.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> elements each with value <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. You use it to fill the container with elements all having the same value.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. You use it to make the controlled sequence a copy of another sequence.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence designated by the enumerator <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. You use it to make the controlled sequence a copy of another sequence described by an enumerator.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **size() = 0**  
 **0 0 0**  
 **x x x x x x**  
 **x x x x x**  
 **x x x x x x**  
 **x x x x x x**  
 **x x x x x x**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [assign](../vs140/vector--assign--stl-clr-.md)   
 [generic_container](../vs140/vector--generic_container--stl-clr-.md)   
 [operator=](../vs140/vector--operator=--stl-clr-.md)