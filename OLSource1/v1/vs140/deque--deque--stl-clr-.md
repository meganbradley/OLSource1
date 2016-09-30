---
title: "deque::deque (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque::deque (STL/CLR)"
f1_keywords: 
  - "cliext::deque::deque"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deque member [STL/CLR]"
ms.assetid: e5bc9511-619e-469c-b50a-e06858e7fce7
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::deque (STL-CLR)
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
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[begin](../vs140/deque--begin--stl-clr-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[end](../vs140/deque--end--stl-clr-.md)<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the deque object <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>[begin](../vs140/deque--begin--stl-clr-.md)<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>[end](../vs140/deque--end--stl-clr-.md)<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the deque object whose handle is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
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
 **Header:** \<cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [assign](../vs140/deque--assign--stl-clr-.md)   
 [generic_container](../vs140/deque--generic_container--stl-clr-.md)   
 [operator=](../vs140/operator=--deque---stl-clr-.md)