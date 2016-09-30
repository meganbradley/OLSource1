---
title: "multiset (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multiset (STL/CLR)"
f1_keywords: 
  - "cliext::multiset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<cliext/set> header [STL/CLR]"
  - "<set> header [STL/CLR]"
  - "multiset class [STL/CLR]"
ms.assetid: 7c46e2b4-cd88-49b7-a9e6-63ad5ae7feb5
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has bidirectional access. You use the container <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to manage a sequence of elements as a (nearly) balanced ordered tree of nodes, each storing one element.  
  
 In the description below, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which in turn is the same as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> unless the latter is a ref type, in which case it is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Key  
 The type of the key component of an element in the controlled sequence.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[const_iterator](../vs140/multiset--const_iterator--stl-clr-.md)|The type of a constant iterator for the controlled sequence.|  
|[const_reference](../vs140/multiset--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[const_reverse_iterator](../vs140/multiset--const_reverse_iterator--stl-clr-.md)|The type of a constant reverse iterator for the controlled sequence.|  
|[difference_type](../vs140/multiset--difference_type--stl-clr-.md)|The type of a (possibly signed) distance between two elements.|  
|[generic_container](../vs140/multiset--generic_container--stl-clr-.md)|The type of the generic interface for the container.|  
|[generic_iterator](../vs140/multiset--generic_iterator--stl-clr-.md)|The type of an iterator for the generic interface for the container.|  
|[generic_reverse_iterator](../vs140/multiset--generic_reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the generic interface for the container.|  
|[generic_value](../vs140/multiset--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container.|  
|[iterator](../vs140/multiset--iterator--stl-clr-.md)|The type of an iterator for the controlled sequence.|  
|[key_compare](../vs140/multiset--key_compare--stl-clr-.md)|The ordering delegate for two keys.|  
|[key_type](../vs140/multiset--key_type--stl-clr-.md)|The type of an ordering key.|  
|[reference](../vs140/multiset--reference--stl-clr-.md)|The type of a reference to an element.|  
|[reverse_iterator](../vs140/multiset--reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the controlled sequence.|  
|[size_type](../vs140/multiset--size_type--stl-clr-.md)|The type of a (non-negative) distance between two elements.|  
|[value_compare](../vs140/multiset--value_compare--stl-clr-.md)|The ordering delegate for two element values.|  
|[value_type](../vs140/multiset--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[begin](../vs140/multiset--begin--stl-clr-.md)|Designates the beginning of the controlled sequence.|  
|[clear](../vs140/multiset--clear--stl-clr-.md)|Removes all elements.|  
|[count](../vs140/multiset--count--stl-clr-.md)|Counts elements matching a specified key.|  
|[empty](../vs140/multiset--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[end](../vs140/multiset--end--stl-clr-.md)|Designates the end of the controlled sequence.|  
|[equal_range](../vs140/multiset--equal_range--stl-clr-.md)|Finds range that matches a specified key.|  
|[erase](../vs140/multiset--erase--stl-clr-.md)|Removes elements at specified positions.|  
|[find](../vs140/multiset--find--stl-clr-.md)|Finds an element that matches a specified key.|  
|[insert](../vs140/multiset--insert--stl-clr-.md)|Adds elements.|  
|[key_comp](../vs140/multiset--key_comp--stl-clr-.md)|Copies the ordering delegate for two keys.|  
|[lower_bound](../vs140/multiset--lower_bound--stl-clr-.md)|Finds beginning of range that matches a specified key.|  
|[make_value](../vs140/multiset--make_value--stl-clr-.md)|Constructs a value object.|  
|[multiset](../vs140/multiset--multiset--stl-clr-.md)|Constructs a container object.|  
|[rbegin](../vs140/multiset--rbegin--stl-clr-.md)|Designates the beginning of the reversed controlled sequence.|  
|[rend](../vs140/multiset--rend--stl-clr-.md)|Designates the end of the reversed controlled sequence.|  
|[size](../vs140/multiset--size--stl-clr-.md)|Counts the number of elements.|  
|[swap](../vs140/multiset--swap--stl-clr-.md)|Swaps the contents of two containers.|  
|[to_array](../vs140/multiset--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
|[upper_bound](../vs140/multiset--upper_bound--stl-clr-.md)|Finds end of range that matches a specified key.|  
|[value_comp](../vs140/multiset--value_comp--stl-clr-.md)|Copies the ordering delegate for two element values.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../vs140/multiset--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
|[multiset::operator!= (STL/CLR)](../vs140/operator!=--multiset---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object is not equal to another <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
|[multiset::operator< (STL/CLR)](../vs140/operator---multiset---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is less than another <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
|[multiset::operator<= (STL/CLR)](../vs140/operator-=--multiset---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is less than or equal to another <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[multiset::operator== (STL/CLR)](../vs140/operator==--multiset---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object is equal to another <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[multiset::operator> (STL/CLR)](../vs140/operator---multiset---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object is greater than another <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[multiset::operator>= (STL/CLR)](../vs140/operator-=--multiset---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object is greater than or equal to another <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|\<xref:System.ICloneable*>|Duplicate an object.|  
|\<xref:System.Collections.IEnumerable*>|Sequence through elements.|  
|\<xref:System.Collections.ICollection*>|Maintain group of elements.|  
|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>1*>|Maintain group of typed elements.|  
|ITree\<Key, Value>|Maintain generic container.|  
  
## Remarks  
 The object allocates and frees storage for the sequence it controls as individual nodes. It inserts elements into a (nearly) balanced tree that it keeps ordered by altering the links between nodes, never by copying the contents of one node to another. That means you can insert and remove elements freely without disturbing remaining elements.  
  
 The object orders the sequence it controls by calling a stored delegate object of type [key_compare](../vs140/multiset--key_compare--stl-clr-.md). You can specify the stored delegate object when you construct the multiset; if you specify no delegate object, the default is the comparison <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. You access this stored object by calling the member function [key_comp](../vs140/multiset--key_comp--stl-clr-.md)<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 Such a delegate object must impose a strict weak ordering on keys of type [key_type](../vs140/multiset--key_type--stl-clr-.md). That means, for any two keys <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> returns the same Boolean result on every call.  
  
 If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is true, then <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> must be false.  
  
 If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is true, then <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is said to be ordered before <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is true, then <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> are said to have equivalent ordering.  
  
 For any element <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> that precedes <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> in the controlled sequence, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is false. (For the default delegate object, keys never decrease in value.) Unlike template class [set](../vs140/set--stl-clr-.md), an object of template class <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> does not require that keys for all elements are unique. (Two or more keys can have equivalent ordering.)  
  
 Each element serves as both a ey and a value. The sequence is represented in a way that permits lookup, insertion, and removal of an arbitrary element with a number of operations proportional to the logarithm of the number of elements in the sequence (logarithmic time). Moreover, inserting an element invalidates no iterators, and removing an element invalidates only those iterators which point at the removed element.  
  
 A multiset supports bidirectional iterators, which means you can step to adjacent elements given an iterator that designates an element in the controlled sequence. A special head node corresponds to the iterator returned by [end](../vs140/multiset--end--stl-clr-.md)<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. You can decrement this iterator to reach the last element in the controlled sequence, if present. You can increment a multiset iterator to reach the head node, and it will then compare equal to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. But you cannot dereference the iterator returned by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 Note that you cannot refer to a multiset element directly given its numerical position -- that requires a random-access iterator.  
  
 A multiset iterator stores a handle to its associated multiset node, which in turn stores a handle to its associated container. You can use iterators only with their associated container objects. A multiset iterator remains valid so long as its associated multiset node is associated with some multiset. Moreover, a valid iterator is dereferencable -- you can use it to access or alter the element value it designates -- so long as it is not equal to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 Erasing or removing an element calls the destructor for its stored value. Destroying the container erases all elements. Thus, a container whose element type is a ref class ensures that no elements outlive the container. Note, however, that a container of handles does <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> destroy its elements.  
  
## Requirements  
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [map](../vs140/map--stl-clr-.md)   
 [multiset](../vs140/multiset--stl-clr-.md)   
 [set](../vs140/set--stl-clr-.md)   
 [STL/CLR Library](../vs140/stl-clr-library-reference.md)