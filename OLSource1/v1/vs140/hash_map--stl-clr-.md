---
title: "hash_map (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map (STL/CLR)"
f1_keywords: 
  - "cliext::hash_map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<cliext/hash_map> header [STL/CLR]"
  - "<hash_map> header [STL/CLR]"
  - "hash_map class [STL/CLR]"
ms.assetid: c3cfc69b-04c6-42ae-a30e-0eda953fe883
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has bidirectional access. You use the container <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to manage a sequence of elements as a hash table, each table entry storing a bidirectional linked list of nodes, and each node storing one element. An element consists of a key, for ordering the sequence, and a mapped value, which goes along for the ride.  
  
 In the description below, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the same as:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 where:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> unless the latter is a ref type, in which case it is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> unless the latter is a ref type, in which case it is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Key  
 The type of the key component of an element in the controlled sequence.  
  
 Mapped  
 The type of the additional component of an element in the controlled sequence.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[const_iterator](../vs140/hash_map--const_iterator--stl-clr-.md)|The type of a constant iterator for the controlled sequence.|  
|[const_reference](../vs140/hash_map--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[const_reverse_iterator](../vs140/hash_map--const_reverse_iterator--stl-clr-.md)|The type of a constant reverse iterator for the controlled sequence.|  
|[difference_type](../vs140/hash_map--difference_type--stl-clr-.md)|The type of a (possibly signed) distance between two elements.|  
|[generic_container](../vs140/hash_map--generic_container--stl-clr-.md)|The type of the generic interface for the container.|  
|[generic_iterator](../vs140/hash_map--generic_iterator--stl-clr-.md)|The type of an iterator for the generic interface for the container.|  
|[generic_reverse_iterator](../vs140/hash_map--generic_reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the generic interface for the container.|  
|[generic_value](../vs140/hash_map--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container.|  
|[hasher](../vs140/hash_map--hasher--stl-clr-.md)|The hashing delegate for a key.|  
|[iterator](../vs140/hash_map--iterator--stl-clr-.md)|The type of an iterator for the controlled sequence.|  
|[key_compare](../vs140/hash_map--key_compare--stl-clr-.md)|The ordering delegate for two keys.|  
|[key_type](../vs140/hash_map--key_type--stl-clr-.md)|The type of an ordering key.|  
|[mapped_type](../vs140/hash_map--mapped_type--stl-clr-.md)|The type of the mapped value associated with each key.|  
|[reference](../vs140/hash_map--reference--stl-clr-.md)|The type of a reference to an element.|  
|[reverse_iterator](../vs140/hash_map--reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the controlled sequence.|  
|[size_type](../vs140/hash_map--size_type--stl-clr-.md)|The type of a (non-negative) distance between two elements.|  
|[value_compare](../vs140/hash_map--value_compare--stl-clr-.md)|The ordering delegate for two element values.|  
|[value_type](../vs140/hash_map--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[begin](../vs140/hash_map--begin--stl-clr-.md)|Designates the beginning of the controlled sequence.|  
|[bucket_count](../vs140/hash_map--bucket_count--stl-clr-.md)|Counts the number of buckets.|  
|[clear](../vs140/hash_map--clear--stl-clr-.md)|Removes all elements.|  
|[count](../vs140/hash_map--count--stl-clr-.md)|Counts elements matching a specified key.|  
|[empty](../vs140/hash_map--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[end](../vs140/hash_map--end--stl-clr-.md)|Designates the end of the controlled sequence.|  
|[equal_range](../vs140/hash_map--equal_range--stl-clr-.md)|Finds range that matches a specified key.|  
|[erase](../vs140/hash_map--erase--stl-clr-.md)|Removes elements at specified positions.|  
|[find](../vs140/hash_map--find--stl-clr-.md)|Finds an element that matches a specified key.|  
|[hash_delegate](../vs140/hash_map--hash_delegate--stl-clr-.md)|Copies the hashing delegate for a key.|  
|[hash_map](../vs140/hash_map--hash_map--stl-clr-.md)|Constructs a container object.|  
|[insert](../vs140/hash_map--insert--stl-clr-.md)|Adds elements.|  
|[key_comp](../vs140/hash_map--key_comp--stl-clr-.md)|Copies the ordering delegate for two keys.|  
|[load_factor](../vs140/hash_map--load_factor--stl-clr-.md)|Counts the average elements per bucket.|  
|[lower_bound](../vs140/hash_map--lower_bound--stl-clr-.md)|Finds beginning of range that matches a specified key.|  
|[make_value](../vs140/hash_map--make_value--stl-clr-.md)|Constructs a value object.|  
|[max_load_factor](../vs140/hash_map--max_load_factor--stl-clr-.md)|Gets or sets the maximum elements per bucket.|  
|[rbegin](../vs140/hash_map--rbegin--stl-clr-.md)|Designates the beginning of the reversed controlled sequence.|  
|[rehash](../vs140/hash_map--rehash--stl-clr-.md)|Rebuilds the hash table.|  
|[rend](../vs140/hash_map--rend--stl-clr-.md)|Designates the end of the reversed controlled sequence.|  
|[size](../vs140/hash_map--size--stl-clr-.md)|Counts the number of elements.|  
|[swap](../vs140/hash_map--swap--stl-clr-.md)|Swaps the contents of two containers.|  
|[to_array](../vs140/hash_map--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
|[upper_bound](../vs140/hash_map--upper_bound--stl-clr-.md)|Finds end of range that matches a specified key.|  
|[value_comp](../vs140/hash_map--value_comp--stl-clr-.md)|Copies the ordering delegate for two element values.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../vs140/hash_map--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
|[operator&#91;&#93;](../vs140/hash_map--operator-stl-clr-.md)|Maps a key to its associated mapped value.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|\<xref:System.ICloneable*>|Duplicate an object.|  
|\<xref:System.Collections.IEnumerable*>|Sequence through elements.|  
|\<xref:System.Collections.ICollection*>|Maintain group of elements.|  
|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>1*>|Maintain group of typed elements.|  
|<xref:System.Collections.Generic.IDictionary<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>operator<=(key_type, key_type)<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>()<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>X<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>Y<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>key_comp()(X, Y)<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>key_comp()(X, Y) && key_comp()(Y, X)<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>X<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>Y<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>operator<=(key_type, key_type)<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>operator>=(key_type, key_type)<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>operator==(key_type, key_type)<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>hash_map<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>()<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>System::Object::hash_value(key_type)<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>X<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>Y<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>hash_delegate()(X)<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>X<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>Y<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>hash_delegate()(X)<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>hash_delegate()(Y)<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>()<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>end()<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>end()<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>end()<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>not` destroy its elements.  
  
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [map](../vs140/map--stl-clr-.md)   
 [multimap](../vs140/multimap--stl-clr-.md)   
 [multiset](../vs140/multiset--stl-clr-.md)   
 [set](../vs140/set--stl-clr-.md)   
 [STL/CLR Library](../vs140/stl-clr-library-reference.md)