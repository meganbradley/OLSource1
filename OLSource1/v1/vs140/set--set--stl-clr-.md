---
title: "set::set (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "set::set (STL/CLR)"
f1_keywords: 
  - "cliext::set::set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set member [STL/CLR]"
ms.assetid: 0cce8501-92ed-431c-b711-14e0b7be7375
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::set (STL-CLR)
Constructs a container object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 first  
 Beginning of range to insert.  
  
 last  
 End of range to insert.  
  
 pred  
 Ordering predicate for the controlled sequence.  
  
 right  
 Object or range to insert.  
  
## Remarks  
 The constructor:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with no elements, with the default ordering predicate <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You use it to specify an empty initial controlled sequence, with the default ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with no elements, with the ordering predicate <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You use it to specify an empty initial controlled sequence, with the specified ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>[begin](../vs140/set--begin--stl-clr-.md)<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>[end](../vs140/set--end--stl-clr-.md)<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, with the default ordering predicate. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the set object <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, with the default ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>[begin](../vs140/set--begin--stl-clr-.md)<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>[end](../vs140/set--end--stl-clr-.md)<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, with the default ordering predicate. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the set object <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, with the default ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, with the default ordering predicate. You use it to make the controlled sequence a copy of another sequence, with the default ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, with the ordering predicate <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. You use it to make the controlled sequence a copy of another sequence, with the specified ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence designated by the enumerator <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, with the default ordering predicate. You use it to make the controlled sequence a copy of another sequence described by an enumerator, with the default ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence designated by the enumerator <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, with the ordering predicate <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. You use it to make the controlled sequence a copy of another sequence described by an enumerator, with the specified ordering predicate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **size() = 0**  
 **a b c**  
**size() = 0**  
 **c b a**  
 **a b c**  
 **c b a**  
 **a b c**  
 **c b a**  
 **c b a**  
 **a b c**   
## Requirements  
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [set](../vs140/set--stl-clr-.md)   
 [generic_container](../vs140/set--generic_container--stl-clr-.md)   
 [operator=](../vs140/set--operator=--stl-clr-.md)