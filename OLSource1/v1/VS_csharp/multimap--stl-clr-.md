---
title: "multimap (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multimap (STL/CLR)"
f1_keywords: 
  - "cliext::multimap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<map> header [STL/CLR]"
  - "<cliext/map> header [STL/CLR]"
  - "multimap class [STL/CLR]"
ms.assetid: 3dfe329d-a078-462a-b050-7999ce6110ad
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has bidirectional access. You use the container `multimap` to manage a sequence of elements as a (nearly) balanced ordered tree of nodes, each storing one element. An element consists of a key, for ordering the sequence, and a mapped value, which goes along for the ride.  
  
 In the description below, `GValue` is the same as:  
  
 `Microsoft::VisualC::StlClr::GenericPair<GKey, GMapped>`  
  
 where:  
  
 `GKey` is the same as `Key` unless the latter is a ref type, in which case it is `Key^`  
  
 `GMapped` is the same as `Mapped` unless the latter is a ref type, in which case it is `Mapped^`  
  
## Syntax  
  
```  
template<typename Key,  
    typename Mapped>  
    ref class multimap  
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
  
 Mapped  
 The type of the additional component of an element in the controlled sequence.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[const_iterator](../VS_csharp/multimap--const_iterator--stl-clr-.md)|The type of a constant iterator for the controlled sequence.|  
|[const_reference](../VS_csharp/multimap--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[const_reverse_iterator](../VS_csharp/multimap--const_reverse_iterator--stl-clr-.md)|The type of a constant reverse iterator for the controlled sequence.|  
|[difference_type](../VS_csharp/multimap--difference_type--stl-clr-.md)|The type of a (possibly signed) distance between two elements.|  
|[generic_container](../VS_csharp/multimap--generic_container--stl-clr-.md)|The type of the generic interface for the container.|  
|[generic_iterator](../VS_csharp/multimap--generic_iterator--stl-clr-.md)|The type of an iterator for the generic interface for the container.|  
|[generic_reverse_iterator](../VS_csharp/multimap--generic_reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the generic interface for the container.|  
|[generic_value](../VS_csharp/multimap--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container.|  
|[iterator](../VS_csharp/multimap--iterator--stl-clr-.md)|The type of an iterator for the controlled sequence.|  
|[key_compare](../VS_csharp/multimap--key_compare--stl-clr-.md)|The ordering delegate for two keys.|  
|[key_type](../VS_csharp/multimap--key_type--stl-clr-.md)|The type of an ordering key.|  
|[mapped_type](../VS_csharp/multimap--mapped_type--stl-clr-.md)|The type of the mapped value associated with each key.|  
|[reference](../VS_csharp/multimap--reference--stl-clr-.md)|The type of a reference to an element.|  
|[reverse_iterator](../VS_csharp/multimap--reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the controlled sequence.|  
|[size_type](../VS_csharp/multimap--size_type--stl-clr-.md)|The type of a (non-negative) distance between two elements.|  
|[value_compare](../VS_csharp/multimap--value_compare--stl-clr-.md)|The ordering delegate for two element values.|  
|[value_type](../VS_csharp/multimap--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[begin](../VS_csharp/multimap--begin--stl-clr-.md)|Designates the beginning of the controlled sequence.|  
|[clear](../VS_csharp/multimap--clear--stl-clr-.md)|Removes all elements.|  
|[count](../VS_csharp/multimap--count--stl-clr-.md)|Counts elements matching a specified key.|  
|[empty](../VS_csharp/multimap--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[end](../VS_csharp/multimap--end--stl-clr-.md)|Designates the end of the controlled sequence.|  
|[equal_range](../VS_csharp/multimap--equal_range--stl-clr-.md)|Finds range that matches a specified key.|  
|[erase](../VS_csharp/multimap--erase--stl-clr-.md)|Removes elements at specified positions.|  
|[find](../VS_csharp/multimap--find--stl-clr-.md)|Finds an element that matches a specified key.|  
|[insert](../VS_csharp/multimap--insert--stl-clr-.md)|Adds elements.|  
|[key_comp](../VS_csharp/multimap--key_comp--stl-clr-.md)|Copies the ordering delegate for two keys.|  
|[lower_bound](../VS_csharp/multimap--lower_bound--stl-clr-.md)|Finds beginning of range that matches a specified key.|  
|[make_value](../VS_csharp/multimap--make_value--stl-clr-.md)|Constructs a value object.|  
|[multimap](../VS_csharp/multimap--multimap--stl-clr-.md)|Constructs a container object.|  
|[rbegin](../VS_csharp/multimap--rbegin--stl-clr-.md)|Designates the beginning of the reversed controlled sequence.|  
|[rend](../VS_csharp/multimap--rend--stl-clr-.md)|Designates the end of the reversed controlled sequence.|  
|[size](../VS_csharp/multimap--size--stl-clr-.md)|Counts the number of elements.|  
|[swap](../VS_csharp/multimap--swap--stl-clr-.md)|Swaps the contents of two containers.|  
|[to_array](../VS_csharp/multimap--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
|[upper_bound](../VS_csharp/multimap--upper_bound--stl-clr-.md)|Finds end of range that matches a specified key.|  
|[value_comp](../VS_csharp/multimap--value_comp--stl-clr-.md)|Copies the ordering delegate for two element values.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../VS_csharp/multimap--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
|[multimap::operator!= (STL/CLR)](../VS_csharp/operator!=--multimap---stl-clr-.md)|Determines if a `multimap` object is not equal to another `multimap` object.|  
|[multimap::operator< (STL/CLR)](../VS_csharp/operator---multimap---stl-clr-.md)|Determines if a `multimap` object is less than another `multimap` object.|  
|[multimap::operator<= (STL/CLR)](../VS_csharp/operator-=--multimap---stl-clr-.md)|Determines if a `multimap` object is less than or equal to another `multimap` object.|  
|[multimap::operator== (STL/CLR)](../VS_csharp/operator==--multimap---stl-lr-.md)|Determines if a `multimap` object is equal to another `multimap` object.|  
|[multimap::operator> (STL/CLR)](../VS_csharp/operator---multimap---stl-clr-.md)|Determines if a `multimap` object is greater than another `multimap` object.|  
|[multimap::operator>= (STL/CLR)](../VS_csharp/operator-=--multimap---stl-clr-.md)|Determines if a `multimap` object is greater than or equal to another `multimap` object.|  
  
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
  
 The object orders the sequence it controls by calling a stored delegate object of type [key_compare](../VS_csharp/multimap--key_compare--stl-clr-.md). You can specify the stored delegate object when you construct the multimap; if you specify no delegate object, the default is the comparison `operator<(key_type, key_type)`. You access this stored object by calling the member function [key_comp](../VS_csharp/multimap--key_comp--stl-clr-.md)`()`.  
  
 Such a delegate object must impose a strict weak ordering on keys of type [key_type](../VS_csharp/multimap--key_type--stl-clr-.md). That means, for any two keys `X` and `Y`:  
  
 `key_comp()(X, Y)` returns the same Boolean result on every call.  
  
 If `key_comp()(X, Y)` is true, then `key_comp()(Y, X)` must be false.  
  
 If `key_comp()(X, Y)` is true, then `X` is said to be ordered before `Y`.  
  
 If `!key_comp()(X, Y) && !key_comp()(Y, X)` is true, then `X` and `Y` are said to have equivalent ordering.  
  
 For any element `X` that precedes `Y` in the controlled sequence, `key_comp()(Y, X)` is false. (For the default delegate object, keys never decrease in value.) Unlike template class [map](../VS_csharp/map--stl-clr-.md), an object of template class `multimap` does not require that keys for all elements are unique. (Two or more keys can have equivalent ordering.)  
  
 Each element contains a separate key and a mapped value. The sequence is represented in a way that permits lookup, insertion, and removal of an arbitrary element with a number of operations proportional to the logarithm of the number of elements in the sequence (logarithmic time). Moreover, inserting an element invalidates no iterators, and removing an element invalidates only those iterators which point at the removed element.  
  
 A multimap supports bidirectional iterators, which means you can step to adjacent elements given an iterator that designates an element in the controlled sequence. A special head node corresponds to the iterator returned by [end](../VS_csharp/multimap--end--stl-clr-.md)`()`. You can decrement this iterator to reach the last element in the controlled sequence, if present. You can increment a multimap iterator to reach the head node, and it will then compare equal to `end()`. But you cannot dereference the iterator returned by `end()`.  
  
 Note that you cannot refer to a multimap element directly given its numerical position -- that requires a random-access iterator.  
  
 A multimap iterator stores a handle to its associated multimap node, which in turn stores a handle to its associated container. You can use iterators only with their associated container objects. A multimap iterator remains valid so long as its associated multimap node is associated with some multimap. Moreover, a valid iterator is dereferencable -- you can use it to access or alter the element value it designates -- so long as it is not equal to `end()`.  
  
 Erasing or removing an element calls the destructor for its stored value. Destroying the container erases all elements. Thus, a container whose element type is a ref class ensures that no elements outlive the container. Note, however, that a container of handles does `not` destroy its elements.  
  
## Requirements  
 **Header:** <cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../VS_csharp/hash_map--stl-clr-.md)   
 [hash_multimap](../VS_csharp/hash_multimap--stl-clr-.md)   
 [hash_multiset](../VS_csharp/hash_multiset--stl-clr-.md)   
 [hash_set](../VS_csharp/hash_set--stl-clr-.md)   
 [map](../VS_csharp/map--stl-clr-.md)   
 [multiset](../VS_csharp/multiset--stl-clr-.md)   
 [set](../VS_csharp/set--stl-clr-.md)   
 [STL/CLR Library](../VS_csharp/stl-clr-library-reference.md)