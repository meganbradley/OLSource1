---
title: "hash_multiset::hash_multiset (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::hash_multiset (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::hash_multiset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_multiset member [STL/CLR]"
ms.assetid: 1b224c60-b714-4ed5-9234-79b61b92a953
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::hash_multiset (STL-CLR)
Constructs a container object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 first  
 Beginning of range to insert.  
  
 hashfn  
 Hash function for mapping keys to buckets.  
  
 last  
 End of range to insert.  
  
 pred  
 Ordering predicate for the controlled sequence.  
  
 right  
 Object or range to insert.  
  
## Remarks  
 The constructor:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with no elements, with the default ordering predicate <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and with the default hash function. You use it to specify an empty initial controlled sequence, with the default ordering predicate and hash function.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with no elements, with the ordering predicate <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and with the default hash function. You use it to specify an empty initial controlled sequence, with the specified ordering predicate and the default hash function.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with no elements, with the ordering predicate <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and with the hash function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. You use it to specify an empty initial controlled sequence, with the specified ordering predicate and hash function.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>[begin](../vs140/hash_multiset--begin--stl-clr-.md)<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>[end](../vs140/hash_multiset--end--stl-clr-.md)<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, with the default ordering predicate, and with the default hash function. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the hash_multiset object <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, with the default ordering predicate and hash function.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>[begin](../vs140/hash_multiset--begin--stl-clr-.md)<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>[end](../vs140/hash_multiset--end--stl-clr-.md)<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, with the default ordering predicate, and with the default hash function. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the hash_multiset object <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, with the default ordering predicate and hash function.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, with the default ordering predicate, and with the default hash function. You use it to make the controlled sequence a copy of another sequence, with the default ordering predicate and hash function.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, with the ordering predicate <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and with the default hash function. You use it to make the controlled sequence a copy of another sequence, with the specified ordering predicate and the default hash function.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, with the ordering predicate <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, and with the hash function <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. You use it to make the controlled sequence a copy of another sequence, with the specified ordering predicate and hash function.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence designated by the enumerator <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, with the default ordering predicate, and with the default hash function. You use it to make the controlled sequence a copy of another sequence described by an enumerator, with the default ordering predicate and hash function.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence designated by the enumerator <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, with the ordering predicate <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and with the default hash function. You use it to make the controlled sequence a copy of another sequence described by an enumerator, with the specified ordering predicate and default hash function.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
 initializes the controlled sequence with the sequence designated by the enumerator <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, with the ordering predicate <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and with the hash function <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. You use it to make the controlled sequence a copy of another sequence described by an enumerator, with the specified ordering predicate and hash function.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **size() = 0**  
 **a b c**  
**size() = 0**  
 **a b c**  
**size() = 0**  
 **c b a**  
 **a b c**  
 **a b c**  
 **c b a**  
 **a b c**  
 **a b c**  
 **c b a**  
 **a b c**  
 **a b c**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [generic_container](../vs140/hash_multiset--generic_container--stl-clr-.md)   
 [operator=](../vs140/hash_multiset--operator=--stl-clr-.md)