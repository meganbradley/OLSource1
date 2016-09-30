---
title: "priority_queue::priority_queue (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "priority_queue::priority_queue (STL/CLR)"
f1_keywords: 
  - "cliext::priority_queue::priority_queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "priority_queue member [STL/CLR]"
ms.assetid: aab423d7-959e-48fd-9028-e9f45f43cb8a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::priority_queue (STL-CLR)
Constructs a container adapter object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 cont  
 Container to copy.  
  
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
  
 creates an empty wrapped container, with the default ordering predicate. You use it to specify an empty initial controlled sequence, with the default ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 creates a wrapped container that is a copy of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, with the ordering predicate <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the queue object <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, with the same ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 creates a wrapped container that is a copy of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, with the ordering predicate <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the queue object <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, with the same ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 creates an empty wrapped container, with the ordering predicate <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. You use it to specify an empty initial controlled sequence, with the specified ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 creates an empty wrapped container, with the ordering predicate <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, then pushes all the elements of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> You use it to specify an initial controlled sequence from an existing container, with the specified ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 creates an empty wrapped container, with the default ordering predicate, then pushes the sequence <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence from a specified eqeuence, with the specified ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 creates an empty wrapped container, with the ordering predicate <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, then pushes the sequence <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence from a specified seqeuence, with the specified ordering predicate.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 creates an empty wrapped container, with the ordering predicate <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, then pushes all the elements of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> plus the sequence <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence from an existing container and a specified seqeuence, with the specified ordering predicate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **size() = 0**  
 **c a b**  
**size() = 0**  
 **a c b**  
 **a c b**  
 **c a b**  
 **a c b**  
 **a a b c c b**  
 **c a b**  
 **c a b**  
 **a c b**   
## Requirements  
 **Header:** \<cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [priority_queue](../vs140/priority_queue--stl-clr-.md)   
 [assign](../vs140/priority_queue--assign--stl-clr-.md)   
 [generic_container](../vs140/priority_queue--generic_container--stl-clr-.md)   
 [operator=](../vs140/priority_queue--operator=--stl-clr-.md)