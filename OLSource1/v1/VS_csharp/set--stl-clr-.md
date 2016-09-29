---
title: "set (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "set (STL/CLR)"
f1_keywords: 
  - "cliext::set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<cliext/set> header [STL/CLR]"
  - "<set> header [STL/CLR]"
  - "set class [STL/CLR]"
ms.assetid: 27d3628c-741a-43a7-bef1-5085536f679e
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has bidirectional access. You use the container `set` to manage a sequence of elements as a (nearly) balanced ordered tree of nodes, each storing one element.  
  
 In the description below, `GValue` is the same as `GKey`, which in turn is the same as `Key` unless the latter is a ref type, in which case it is `Key^`.  
  
## Syntax  
  
```  
template<typename Key>  
    ref class set  
        :   public  
        System::ICloneable,  
        System::Collections::IEnumerable,  
        System::Collections::ICollection,  
        System::Collections::Generic::IEnumerable<GValue>,  
        System::Collections::Generic::ICollection<GValue>,  
        System::Collections::Generic::IList<GValue>,  
        Microsoft::VisualC::StlClr::ITree<Gkey, GValue>  
    { ..... };  
```  
  
#### Parameters  
 Key  
 The type of the key component of an element in the controlled sequence.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[const_iterator](../VS_csharp/set--const_iterator--stl-clr-.md)|The type of a constant iterator for the controlled sequence.|  
|[const_reference](../VS_csharp/set--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[const_reverse_iterator](../VS_csharp/set--const_reverse_iterator--stl-clr-.md)|The type of a constant reverse iterator for the controlled sequence.|  
|[difference_type](../VS_csharp/set--difference_type--stl-clr-.md)|The type of a (possibly signed) distance between two elements.|  
|[generic_container](../VS_csharp/set--generic_container--stl-clr-.md)|The type of the generic interface for the container.|  
|[generic_iterator](../VS_csharp/set--generic_iterator--stl-clr-.md)|The type of an iterator for the generic interface for the container.|  
|[generic_reverse_iterator](../VS_csharp/set--generic_reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the generic interface for the container.|  
|[generic_value](../VS_csharp/set--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container.|  
|[iterator](../VS_csharp/set--iterator--stl-clr-.md)|The type of an iterator for the controlled sequence.|  
|[key_compare](../VS_csharp/set--key_compare--stl-clr-.md)|The ordering delegate for two keys.|  
|[key_type](../VS_csharp/set--key_type--stl-clr-.md)|The type of an ordering key.|  
|[reference](../VS_csharp/set--reference--stl-clr-.md)|The type of a reference to an element.|  
|[reverse_iterator](../VS_csharp/set--reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the controlled sequence.|  
|[size_type](../VS_csharp/set--size_type--stl-clr-.md)|The type of a (non-negative) distance between two elements.|  
|[value_compare](../VS_csharp/set--value_compare--stl-clr-.md)|The ordering delegate for two element values.|  
|[value_type](../VS_csharp/set--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[begin](../VS_csharp/set--begin--stl-clr-.md)|Designates the beginning of the controlled sequence.|  
|[clear](../VS_csharp/set--clear--stl-clr-.md)|Removes all elements.|  
|[count](../VS_csharp/set--count--stl-clr-.md)|Counts elements matching a specified key.|  
|[empty](../VS_csharp/set--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[end](../VS_csharp/set--end--stl-clr-.md)|Designates the end of the controlled sequence.|  
|[equal_range](../VS_csharp/set--equal_range--stl-clr-.md)|Finds range that matches a specified key.|  
|[erase](../VS_csharp/set--erase--stl-clr-.md)|Removes elements at specified positions.|  
|[find](../VS_csharp/set--find--stl-clr-.md)|Finds an element that matches a specified key.|  
|[insert](../VS_csharp/set--insert--stl-clr-.md)|Adds elements.|  
|[key_comp](../VS_csharp/set--key_comp--stl-clr-.md)|Copies the ordering delegate for two keys.|  
|[lower_bound](../VS_csharp/set--lower_bound--stl-clr-.md)|Finds beginning of range that matches a specified key.|  
|[make_value](../VS_csharp/set--make_value--stl-clr-.md)|Constructs a value object.|  
|[rbegin](../VS_csharp/set--rbegin--stl-clr-.md)|Designates the beginning of the reversed controlled sequence.|  
|[rend](../VS_csharp/set--rend--stl-clr-.md)|Designates the end of the reversed controlled sequence.|  
|[set](../VS_csharp/set--set--stl-clr-.md)|Constructs a container object.|  
|[size](../VS_csharp/set--size--stl-clr-.md)|Counts the number of elements.|  
|[swap](../VS_csharp/set--swap--stl-clr-.md)|Swaps the contents of two containers.|  
|[to_array](../VS_csharp/set--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
|[upper_bound](../VS_csharp/set--upper_bound--stl-clr-.md)|Finds end of range that matches a specified key.|  
|[value_comp](../VS_csharp/set--value_comp--stl-clr-.md)|Copies the ordering delegate for two element values.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../VS_csharp/set--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
|[set::operator!= (STL/CLR)](../VS_csharp/operator!=--set---stl-clr-.md)|Determines if a `set` object is not equal to another `set` object.|  
|[set::operator< (STL/CLR)](../VS_csharp/operator---set---stl-clr-.md)|Determines if a `set` object is less than another `set` object.|  
|[set::operator<= (STL/CLR)](../VS_csharp/operator-=--set---stl-clr-.md)|Determines if a `set` object is less than or equal to another `set` object.|  
|[set::operator== (STL/CLR)](../VS_csharp/operator==--set---stl-clr-.md)|Determines if a `set` object is equal to another `set` object.|  
|[set::operator> (STL/CLR)](../VS_csharp/operator---set---stl-clr-.md)|Determines if a `set` object is greater than another `set` object.|  
|[set::operator>= (STL/CLR)](../VS_csharp/operator-=--set---stl-clr-.md)|Determines if a `set` object is greater than or equal to another `set` object.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|<xref:System.ICloneable*>|Duplicate an object.|  
|<xref:System.Collections.IEnumerable*>|Sequence through elements.|  
|<xref:System.Collections.ICollection*>|Maintain group of elements.|  
|<xref:System.Collections.Generic.IEnumerable`1*>|Sequence through typed elements.|  
|<xref:System.Collections.Generic.ICollection`1*>|Maintain group of typed elements.|  
|ITree<Key, Value>|Maintain generic container.|  
  
## Remarks  
 The object allocates and frees storage for the sequence it controls as individual nodes. It inserts elements into a (nearly) balanced tree that it keeps ordered by altering the links between nodes, never by copying the contents of one node to another. That means you can insert and remove elements freely without disturbing remaining elements.  
  
 The object orders the sequence it controls by calling a stored delegate object of type [key_compare](../VS_csharp/set--key_compare--stl-clr-.md). You can specify the stored delegate object when you construct the set; if you specify no delegate object, the default is the comparison `operator<(key_type, key_type)`. You access this stored object by calling the member function [key_comp](../VS_csharp/set--key_comp--stl-clr-.md)`()`.  
  
 Such a delegate object must impose a strict weak ordering on keys of type [key_type](../VS_csharp/set--key_type--stl-clr-.md). That means, for any two keys `X` and `Y`:  
  
 `key_comp()(X, Y)` returns the same Boolean result on every call.  
  
 If `key_comp()(X, Y)` is true, then `key_comp()(Y, X)` must be false.  
  
 If `key_comp()(X, Y)` is true, then `X` is said to be ordered before `Y`.  
  
 If `!key_comp()(X, Y) && !key_comp()(Y, X)` is true, then `X` and `Y` are said to have equivalent ordering.  
  
 For any element `X` that precedes `Y` in the controlled sequence, `key_comp()(Y, X)` is false. (For the default delegate object, keys never decrease in value.) Unlike template class [set](../VS_csharp/set--stl-clr-.md), an object of template class `set` does not require that keys for all elements are unique. (Two or more keys can have equivalent ordering.)  
  
 Each element serves as both a ey and a value. The sequence is represented in a way that permits lookup, insertion, and removal of an arbitrary element with a number of operations proportional to the logarithm of the number of elements in the sequence (logarithmic time). Moreover, inserting an element invalidates no iterators, and removing an element invalidates only those iterators which point at the removed element.  
  
 A set supports bidirectional iterators, which means you can step to adjacent elements given an iterator that designates an element in the controlled sequence. A special head node corresponds to the iterator returned by [end](../VS_csharp/set--end--stl-clr-.md)`()`. You can decrement this iterator to reach the last element in the controlled sequence, if present. You can increment a set iterator to reach the head node, and it will then compare equal to `end()`. But you cannot dereference the iterator returned by `end()`.  
  
 Note that you cannot refer to a set element directly given its numerical position -- that requires a random-access iterator.  
  
 A set iterator stores a handle to its associated set node, which in turn stores a handle to its associated container. You can use iterators only with their associated container objects. A set iterator remains valid so long as its associated set node is associated with some set. Moreover, a valid iterator is dereferencable -- you can use it to access or alter the element value it designates -- so long as it is not equal to `end()`.  
  
 Erasing or removing an element calls the destructor for its stored value. Destroying the container erases all elements. Thus, a container whose element type is a ref class ensures that no elements outlive the container. Note, however, that a container of handles does `not` destroy its elements.  
  
## Requirements  
 **Header:** <cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../VS_csharp/hash_map--stl-clr-.md)   
 [hash_set](../VS_csharp/hash_set--stl-clr-.md)   
 [hash_set](../VS_csharp/hash_set--stl-clr-.md)   
 [hash_set](../VS_csharp/hash_set--stl-clr-.md)   
 [map](../VS_csharp/map--stl-clr-.md)   
 [set](../VS_csharp/set--stl-clr-.md)   
 [set](../VS_csharp/set--stl-clr-.md)   
 [STL/CLR Library](../VS_csharp/stl-clr-library-reference.md)