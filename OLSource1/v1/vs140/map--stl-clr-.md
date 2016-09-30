---
title: "map (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "map (STL/CLR)"
f1_keywords: 
  - "cliext::map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<map> header [STL/CLR]"
  - "map class [STL/CLR]"
  - "<cliext/map> header [STL/CLR]"
ms.assetid: 8b0a7764-b5e4-4175-a802-82b72eb8662a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has bidirectional access. You use the container <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to manage a sequence of elements as a (nearly) balanced ordered tree of nodes, each storing one element. An element consists of a key, for ordering the sequence, and a mapped value, which goes along for the ride.  
  
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
|[const_iterator](../vs140/map--const_iterator--stl-clr-.md)|The type of a constant iterator for the controlled sequence.|  
|[const_reference](../vs140/map--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[const_reverse_iterator](../vs140/map--const_reverse_iterator--stl-clr-.md)|The type of a constant reverse iterator for the controlled sequence.|  
|[difference_type](../vs140/map--difference_type--stl-clr-.md)|The type of a (possibly signed) distance between two elements.|  
|[generic_container](../vs140/map--generic_container--stl-clr-.md)|The type of the generic interface for the container.|  
|[generic_iterator](../vs140/map--generic_iterator--stl-clr-.md)|The type of an iterator for the generic interface for the container.|  
|[generic_reverse_iterator](../vs140/map--generic_reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the generic interface for the container.|  
|[generic_value](../vs140/map--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container.|  
|[iterator](../vs140/map--iterator--stl-clr-.md)|The type of an iterator for the controlled sequence.|  
|[key_compare](../vs140/map--key_compare--stl-clr-.md)|The ordering delegate for two keys.|  
|[key_type](../vs140/map--key_type--stl-clr-.md)|The type of an ordering key.|  
|[mapped_type](../vs140/map--mapped_type--stl-clr-.md)|The type of the mapped value associated with each key.|  
|[reference](../vs140/map--reference--stl-clr-.md)|The type of a reference to an element.|  
|[reverse_iterator](../vs140/map--reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the controlled sequence.|  
|[size_type](../vs140/map--size_type--stl-clr-.md)|The type of a (non-negative) distance between two elements.|  
|[value_compare](../vs140/map--value_compare--stl-clr-.md)|The ordering delegate for two element values.|  
|[value_type](../vs140/map--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[begin](../vs140/map--begin--stl-clr-.md)|Designates the beginning of the controlled sequence.|  
|[clear](../vs140/map--clear--stl-clr-.md)|Removes all elements.|  
|[count](../vs140/map--count--stl-clr-.md)|Counts elements matching a specified key.|  
|[empty](../vs140/map--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[end](../vs140/map--end--stl-clr-.md)|Designates the end of the controlled sequence.|  
|[equal_range](../vs140/map--equal_range--stl-clr-.md)|Finds range that matches a specified key.|  
|[erase](../vs140/map--erase--stl-clr-.md)|Removes elements at specified positions.|  
|[find](../vs140/map--find--stl-clr-.md)|Finds an element that matches a specified key.|  
|[insert](../vs140/map--insert--stl-clr-.md)|Adds elements.|  
|[key_comp](../vs140/map--key_comp--stl-clr-.md)|Copies the ordering delegate for two keys.|  
|[lower_bound](../vs140/map--lower_bound--stl-clr-.md)|Finds beginning of range that matches a specified key.|  
|[make_value](../vs140/map--make_value--stl-clr-.md)|Constructs a value object.|  
|[map](../vs140/map--map--stl-clr-.md)|Constructs a container object.|  
|[rbegin](../vs140/map--rbegin--stl-clr-.md)|Designates the beginning of the reversed controlled sequence.|  
|[rend](../vs140/map--rend--stl-clr-.md)|Designates the end of the reversed controlled sequence.|  
|[size](../vs140/map--size--stl-clr-.md)|Counts the number of elements.|  
|[swap](../vs140/map--swap--stl-clr-.md)|Swaps the contents of two containers.|  
|[to_array](../vs140/map--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
|[upper_bound](../vs140/map--upper_bound--stl-clr-.md)|Finds end of range that matches a specified key.|  
|[value_comp](../vs140/map--value_comp--stl-clr-.md)|Copies the ordering delegate for two element values.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../vs140/map--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
|[map::operator&#91;&#93; (STL/CLR)](../vs140/map--operator-stl-clr-.md)|Maps a key to its associated mapped value.|  
|[map::operator!= (STL/CLR)](../vs140/operator!=--map---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is not equal to another <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[map::operator< (STL/CLR)](../vs140/operator---map---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object is less than another <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[map::operator<= (STL/CLR)](../vs140/operator-=--map---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object is less than or equal to another <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[map::operator== (STL/CLR)](../vs140/operator==--map---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object is equal to another <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
|[map::operator> (STL/CLR)](../vs140/operator---map---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object is greater than another <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
|[map::operator>= (STL/CLR)](../vs140/operator-=--map---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object is greater than or equal to another <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|\<xref:System.ICloneable*>|Duplicate an object.|  
|\<xref:System.Collections.IEnumerable*>|Sequence through elements.|  
|\<xref:System.Collections.ICollection*>|Maintain group of elements.|  
|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>1*>|Maintain group of typed elements.|  
|<xref:System.Collections.Generic.IDictionary<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>operator<(key_type, key_type)<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>()<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>X<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>Y<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>key_comp()(X, Y)<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>key_comp()(X, Y)<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>key_comp()(Y, X)<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>key_comp()(X, Y)<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>X<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>Y<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>!key_comp()(X, Y) && !key_comp()(Y, X)<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>X<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>Y<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>X<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>Y<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>key_comp()(Y, X)<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>map<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>()<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>end()<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>end()<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>end()<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>not` destroy its elements.  
  
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [map](../vs140/map--stl-clr-.md)   
 [multiset](../vs140/multiset--stl-clr-.md)   
 [set](../vs140/set--stl-clr-.md)   
 [STL/CLR Library](../vs140/stl-clr-library-reference.md)