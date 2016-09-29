---
title: "hash_set (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<cliext/hash_set> header [STL/CLR]"
  - "hash_set class [STL/CLR]"
  - "<hash_set> header [STL/CLR]"
ms.assetid: d110e356-ba3e-4e52-9e2d-d997bf975c96
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has bidirectional access. You use the container `hash_set` to manage a sequence of elements as a hash table, each table entry storing a bidirectional linked list of nodes, and each node storing one element. The value of each element is used as a key, for ordering the sequence.  
  
 In the description below, `GValue` is the same as `GKey`, which in turn is the same as `Key` unless the latter is a ref type, in which case it is `Key^`.  
  
## Syntax  
  
```  
template<typename Key>  
    ref class hash_set  
        :   public  
        System::ICloneable,  
        System::Collections::IEnumerable,  
        System::Collections::ICollection,  
        System::Collections::Generic::IEnumerable<GValue>,  
        System::Collections::Generic::ICollection<GValue>,  
        System::Collections::Generic::IList<GValue>,  
        Microsoft::VisualC::StlClr::IHash<Gkey, GValue>  
    { ..... };  
```  
  
#### Parameters  
 Key  
 The type of the key component of an element in the controlled sequence.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[const_iterator](../vs140/hash_set--const_iterator--stl-clr-.md)|The type of a constant iterator for the controlled sequence.|  
|[const_reference](../vs140/hash_set--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[const_reverse_iterator](../vs140/hash_set--const_reverse_iterator--stl-clr-.md)|The type of a constant reverse iterator for the controlled sequence.|  
|[difference_type](../vs140/hash_set--difference_type--stl-clr-.md)|The type of a (possibly signed) distance between two elements.|  
|[generic_container](../vs140/hash_set--generic_container--stl-clr-.md)|The type of the generic interface for the container.|  
|[generic_iterator](../vs140/hash_set--generic_iterator--stl-clr-.md)|The type of an iterator for the generic interface for the container.|  
|[generic_reverse_iterator](../vs140/hash_set--generic_reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the generic interface for the container.|  
|[generic_value](../vs140/hash_set--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container.|  
|[hasher](../vs140/hash_set--hasher--stl-clr-.md)|The hashing delegate for a key.|  
|[iterator](../vs140/hash_set--iterator--stl-clr-.md)|The type of an iterator for the controlled sequence.|  
|[key_compare](../vs140/hash_set--key_compare--stl-clr-.md)|The ordering delegate for two keys.|  
|[key_type](../vs140/hash_set--key_type--stl-clr-.md)|The type of an ordering key.|  
|[reference](../vs140/hash_set--reference--stl-clr-.md)|The type of a reference to an element.|  
|[reverse_iterator](../vs140/hash_set--reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the controlled sequence.|  
|[size_type](../vs140/hash_set--size_type--stl-clr-.md)|The type of a (non-negative) distance between two elements.|  
|[value_compare](../vs140/hash_set--value_compare--stl-clr-.md)|The ordering delegate for two element values.|  
|[value_type](../vs140/hash_set--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[begin](../vs140/hash_set--begin--stl-clr-.md)|Designates the beginning of the controlled sequence.|  
|[bucket_count](../vs140/hash_set--bucket_count--stl-clr-.md)|Counts the number of buckets.|  
|[clear](../vs140/hash_set--clear--stl-clr-.md)|Removes all elements.|  
|[count](../vs140/hash_set--count--stl-clr-.md)|Counts elements matching a specified key.|  
|[empty](../vs140/hash_set--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[end](../vs140/hash_set--end--stl-clr-.md)|Designates the end of the controlled sequence.|  
|[equal_range](../vs140/hash_set--equal_range--stl-clr-.md)|Finds range that matches a specified key.|  
|[erase](../vs140/hash_set--erase--stl-clr-.md)|Removes elements at specified positions.|  
|[find](../vs140/hash_set--find--stl-clr-.md)|Finds an element that matches a specified key.|  
|[hash_delegate](../vs140/hash_set--hash_delegate--stl-clr-.md)|Copies the hashing delegate for a key.|  
|[hash_set](../vs140/hash_set--hash_set--stl-clr-.md)|Constructs a container object.|  
|[insert](../vs140/hash_set--insert--stl-clr-.md)|Adds elements.|  
|[key_comp](../vs140/hash_set--key_comp--stl-clr-.md)|Copies the ordering delegate for two keys.|  
|[load_factor](../vs140/hash_set--load_factor--stl-clr-.md)|Counts the average elements per bucket.|  
|[lower_bound](../vs140/hash_set--lower_bound--stl-clr-.md)|Finds beginning of range that matches a specified key.|  
|[make_value](../vs140/hash_set--make_value--stl-clr-.md)|Constructs a value object.|  
|[max_load_factor](../vs140/hash_set--max_load_factor--stl-clr-.md)|Gets or sets the maximum elements per bucket.|  
|[rbegin](../vs140/hash_set--rbegin--stl-clr-.md)|Designates the beginning of the reversed controlled sequence.|  
|[rehash](../vs140/hash_set--rehash--stl-clr-.md)|Rebuilds the hash table.|  
|[rend](../vs140/hash_set--rend--stl-clr-.md)|Designates the end of the reversed controlled sequence.|  
|[size](../vs140/hash_set--size--stl-clr-.md)|Counts the number of elements.|  
|[swap](../vs140/hash_set--swap--stl-clr-.md)|Swaps the contents of two containers.|  
|[to_array](../vs140/hash_set--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
|[upper_bound](../vs140/hash_set--upper_bound--stl-clr-.md)|Finds end of range that matches a specified key.|  
|[value_comp](../vs140/hash_set--value_comp--stl-clr-.md)|Copies the ordering delegate for two element values.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../vs140/hash_set--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|<xref:System.ICloneable*>|Duplicate an object.|  
|<xref:System.Collections.IEnumerable*>|Sequence through elements.|  
|<xref:System.Collections.ICollection*>|Maintain group of elements.|  
|<xref:System.Collections.Generic.IEnumerable`1*>|Sequence through typed elements.|  
|<xref:System.Collections.Generic.ICollection`1*>|Maintain group of typed elements.|  
|IHash<Key, Value>|Maintain generic container.|  
  
## Remarks  
 The object allocates and frees storage for the sequence it controls as individual nodes in a bidirectional linked list. To speed access, the object also maintains a varying-length array of pointers into the list (the hash table), effectively managing the whole list as a sequence of sublists, or buckets. It inserts elements into a bucket that it keeps ordered by altering the links between nodes, never by copying the contents of one node to another. That means you can insert and remove elements freely without disturbing remaining elements.  
  
 The object orders each bucket it controls by calling a stored delegate object of type [key_compare](../vs140/hash_set--key_compare--stl-clr-.md). You can specify the stored delegate object when you construct the hash_set; if you specify no delegate object, the default is the comparison `operator<=(key_type, key_type)`.  
  
 You access the stored delegate object by calling the member function [key_comp](../vs140/hash_set--key_comp--stl-clr-.md)`()`. Such a delegate object must define equivalent ordering between keys of type [key_type](../vs140/hash_set--key_type--stl-clr-.md). That means, for any two keys `X` and `Y`:  
  
 `key_comp()(X, Y)` returns the same Boolean result on every call.  
  
 If `key_comp()(X, Y) && key_comp()(Y, X)` is true, then `X` and `Y` are said to have equivalent ordering.  
  
 Any ordering rule that behaves like `operator<=(key_type, key_type)`, `operator>=(key_type, key_type)` or `operator==(key_type, key_type)` defines eqivalent ordering.  
  
 Note that the container ensures only that elements whose keys have equivalent ordering (and which hash to the same integer value) are adjacent within a bucket. Unlike template class [hash_multiset](../vs140/hash_multiset--stl-clr-.md), an object of template class `hash_set` ensures that keys for all elements are unique. (No two keys have equivalent ordering.)  
  
 The object determines which bucket should contain a given ordering key by calling a stored delegate object of type [hasher](../vs140/hash_set--hasher--stl-clr-.md). You access this stored object by calling the member function [hash_delegate](../vs140/hash_set--hash_delegate--stl-clr-.md)`()` to obtain an integer value that depends on the key value. You can specify the stored delegate object when you construct the hash_set; if you specify no delegate object, the default is the function `System::Object::hash_value(key_type)`. That means, for any keys `X` and `Y`:  
  
 `hash_delegate()(X)` returns the same integer result on every call.  
  
 If `X` and `Y` have equivalent ordering, then `hash_delegate()(X)` should return the same integer result as `hash_delegate()(Y)`.  
  
 Each element serves as both a key and a value. The sequence is represented in a way that permits lookup, insertion, and removal of an arbitrary element with a number of operations that is independent of the number of elements in the sequence (constant time) -- at least in the best of cases. Moreover, inserting an element invalidates no iterators, and removing an element invalidates only those iterators which point at the removed element.  
  
 If hashed values are not uniformly distributed, however, a hash table can degenerate. In the extreme -- for a hash function that always returns the same value -- lookup, insertion, and removal are proportional to the number of elements in the sequence (linear time). The container endeavors to choose a reasonable hash function, mean bucket size, and hash-table size (total number of buckets), but you can override any or all of these choices. See, for example, the functions [max_load_factor](../vs140/hash_set--max_load_factor--stl-clr-.md) and [rehash](../vs140/hash_set--rehash--stl-clr-.md).  
  
 A hash_set supports bidirectional iterators, which means you can step to adjacent elements given an iterator that designates an element in the controlled sequence. A special head node corresponds to the iterator returned by [end](../vs140/hash_set--end--stl-clr-.md)`()`. You can decrement this iterator to reach the last element in the controlled sequence, if present. You can increment a hash_set iterator to reach the head node, and it will then compare equal to `end()`. But you cannot dereference the iterator returned by `end()`.  
  
 Note that you cannot refer to a hash_set element directly given its numerical position -- that requires a random-access iterator.  
  
 A hash_set iterator stores a handle to its associated hash_set node, which in turn stores a handle to its associated container. You can use iterators only with their associated container objects. A hash_set iterator remains valid so long as its associated hash_set node is associated with some hash_set. Moreover, a valid iterator is dereferencable -- you can use it to access or alter the element value it designates -- so long as it is not equal to `end()`.  
  
 Erasing or removing an element calls the destructor for its stored value. Destroying the container erases all elements. Thus, a container whose element type is a ref class ensures that no elements outlive the container. Note, however, that a container of handles does `not` destroy its elements.  
  
## Requirements  
 **Header:** <cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [map](../vs140/map--stl-clr-.md)   
 [set](../vs140/set--stl-clr-.md)   
 [set](../vs140/set--stl-clr-.md)   
 [set](../vs140/set--stl-clr-.md)   
 [STL/CLR Library](../vs140/stl-clr-library-reference.md)