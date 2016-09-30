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
The template class describes an object that controls a varying-length sequence of elements that has bidirectional access. You use the container `map` to manage a sequence of elements as a (nearly) balanced ordered tree of nodes, each storing one element. An element consists of a key, for ordering the sequence, and a mapped value, which goes along for the ride.  
  
 In the description below, `GValue` is the same as:  
  
 `Microsoft::VisualC::StlClr::GenericPair<GKey, GMapped>`  
  
 where:  
  
 `GKey` is the same as `Key` unless the latter is a ref type, in which case it is `Key^`  
  
 `GMapped` is the same as `Mapped` unless the latter is a ref type, in which case it is `Mapped^`  
  
## Syntax  
  
```  
template<typename Key,  
    typename Mapped>  
    ref class map  
        :   public  
        System::ICloneable,  
        System::Collections::IEnumerable,  
        System::Collections::ICollection,  
        System::Collections::Generic::IEnumerable<GValue>,  
        System::Collections::Generic::ICollection<GValue>,  
        System::Collections::Generic::IList<GValue>,  
        System::Collections::Generic::IDictionary<Gkey, GMapped>,  
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
|[map::operator!= (STL/CLR)](../vs140/operator!=--map---stl-clr-.md)|Determines if a `map` object is not equal to another `map` object.|  
|[map::operator< (STL/CLR)](../vs140/operator---map---stl-clr-.md)|Determines if a `map` object is less than another `map` object.|  
|[map::operator<= (STL/CLR)](../vs140/operator-=--map---stl-clr-.md)|Determines if a `map` object is less than or equal to another `map` object.|  
|[map::operator== (STL/CLR)](../vs140/operator==--map---stl-clr-.md)|Determines if a `map` object is equal to another `map` object.|  
|[map::operator> (STL/CLR)](../vs140/operator---map---stl-clr-.md)|Determines if a `map` object is greater than another `map` object.|  
|[map::operator>= (STL/CLR)](../vs140/operator-=--map---stl-clr-.md)|Determines if a `map` object is greater than or equal to another `map` object.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|\<xref:System.ICloneable*>|Duplicate an object.|  
|\<xref:System.Collections.IEnumerable*>|Sequence through elements.|  
|\<xref:System.Collections.ICollection*>|Maintain group of elements.|  
|<xref:System.Collections.Generic.IEnumerable`1*>|Sequence through typed elements.|  
|<xref:System.Collections.Generic.ICollection`1*>|Maintain group of typed elements.|  
|<xref:System.Collections.Generic.IDictionary`2*>|Maintain group of {key, value} pairs.|  
|ITree<Key, Value>|Maintain generic container.|  
  
## Remarks  
 The object allocates and frees storage for the sequence it controls as individual nodes. It inserts elements into a (nearly) balanced tree that it keeps ordered by altering the links between nodes, never by copying the contents of one node to another. That means you can insert and remove elements freely without disturbing remaining elements.  
  
 The object orders the sequence it controls by calling a stored delegate object of type [key_compare](../vs140/map--key_compare--stl-clr-.md). You can specify the stored delegate object when you construct the map; if you specify no delegate object, the default is the comparison `operator<(key_type, key_type)`. You access this stored object by calling the member function [key_comp](../vs140/map--key_comp--stl-clr-.md)`()`.  
  
 Such a delegate object must impose a strict weak ordering on keys of type [key_type](../vs140/map--key_type--stl-clr-.md). That means, for any two keys `X` and `Y`:  
  
 `key_comp()(X, Y)` returns the same Boolean result on every call.  
  
 If `key_comp()(X, Y)` is true, then `key_comp()(Y, X)` must be false.  
  
 If `key_comp()(X, Y)` is true, then `X` is said to be ordered before `Y`.  
  
 If `!key_comp()(X, Y) && !key_comp()(Y, X)` is true, then `X` and `Y` are said to have equivalent ordering.  
  
 For any element `X` that precedes `Y` in the controlled sequence, `key_comp()(Y, X)` is false. (For the default delegate object, keys never decrease in value.) Unlike template class [map](../vs140/map--stl-clr-.md), an object of template class `map` does not require that keys for all elements are unique. (Two or more keys can have equivalent ordering.)  
  
 Each element contains a separate key and a mapped value. The sequence is represented in a way that permits lookup, insertion, and removal of an arbitrary element with a number of operations proportional to the logarithm of the number of elements in the sequence (logarithmic time). Moreover, inserting an element invalidates no iterators, and removing an element invalidates only those iterators which point at the removed element.  
  
 A map supports bidirectional iterators, which means you can step to adjacent elements given an iterator that designates an element in the controlled sequence. A special head node corresponds to the iterator returned by [end](../vs140/map--end--stl-clr-.md)`()`. You can decrement this iterator to reach the last element in the controlled sequence, if present. You can increment a map iterator to reach the head node, and it will then compare equal to `end()`. But you cannot dereference the iterator returned by `end()`.  
  
 Note that you cannot refer to a map element directly given its numerical position -- that requires a random-access iterator.  
  
 A map iterator stores a handle to its associated map node, which in turn stores a handle to its associated container. You can use iterators only with their associated container objects. A map iterator remains valid so long as its associated map node is associated with some map. Moreover, a valid iterator is dereferencable -- you can use it to access or alter the element value it designates -- so long as it is not equal to `end()`.  
  
 Erasing or removing an element calls the destructor for its stored value. Destroying the container erases all elements. Thus, a container whose element type is a ref class ensures that no elements outlive the container. Note, however, that a container of handles does `not` destroy its elements.  
  
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