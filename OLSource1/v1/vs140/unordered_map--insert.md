---
title: "unordered_map::insert"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::tr1::unordered_map::insert"
  - "unordered_map::insert"
  - "unordered_map/std::tr1::unordered_map::insert"
  - "std.tr1.unordered_map.insert"
  - "unordered_map.insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method [TR1]"
ms.assetid: 511d7840-cd52-44bb-91d2-5a929eaac9fe
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::insert
Inserts an element or a range of elements into an unordered_map.  
  
## Syntax  
  
```  
// (1) single element  
pair<iterator, bool> insert(  
    const value_type& Val  
);   
  
// (2) single element, perfect forwarded  
template<class ValTy>  
pair<iterator, bool> insert(  
    ValTy&& Val  
);  
  
// (3) single element with hint  
iterator insert(  
    const_iterator Where,  
    const value_type& Val  
);   
  
// (4) single element, perfect forwarded, with hint  
template<class ValTy>  
iterator insert(  
    const_iterator Where,  
    ValTy&& Val  
);  
  
// (5) range   
template<class InputIterator>   
void insert(  
    InputIterator First,  
    InputIterator Last  
);   
  
// (6) initializer list  
void insert(  
    initializer_list<value_type> IList  
);  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Val`|The value of an element to be inserted into the unordered_map unless it already contains an element whose key is equivalently ordered.|  
|`Where`|The place to start searching for the correct point of insertion.|  
|`ValTy`|Template parameter that specifies the argument type that the unordered_map can use to construct an element of [value_type](../vs140/map--value_type.md), and perfect-forwards `Val` as an argument.|  
|`First`|The position of the first element to be copied.|  
|`Last`|The position just beyond the last element to be copied.|  
|`InputIterator`|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map--value_type.md) objects.|  
|`IList`|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
## Return Value  
 The single-element member functions, (1) and (2), return a [pair](../vs140/pair-structure.md) whose `bool` component is true if an insertion was made, and false if the unordered_map already contained an element whose key had an equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the `bool` component is true, or to the existing element if the `bool` component is false.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the unordered_map or, if an element with an equivalent key already exists, to the existing element.  
  
## Remarks  
 No iterators, pointers, or references are invalidated by this function.  
  
 During the insertion of just one element, if an exception is thrown but does not occur in the container's hash function, the container's state is not modified. If the exception is thrown in the hash function, the result is undefined. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 To access the iterator component of a `pair``pr` that's returned by the single-element member functions, use `pr.first`; to dereference the iterator within the returned pair, use `*pr.first`, giving you an element. To access the `bool` component, use `pr.second`. For an example, see the sample code later in this article.  
  
 The [value_type](../vs140/map--value_type.md) of a container is a typedef that belongs to the container, and for map, `map<K, V>::value_type` is `pair<const K, V>`. The value of an element is an ordered pair in which the first component is equal to the key value and the second component is equal to the data value of the element.  
  
 The range member function (5) inserts the sequence of element values into an unordered_map that corresponds to each element addressed by an iterator in the range `[First, Last)`; therefore, `Last` does not get inserted. The container member function `end()` refers to the position just after the last element in the container—for example, the statement `m.insert(v.begin(), v.end());` attempts to insert all elements of `v` into `m`. Only elements that have unique values in the range are inserted; duplicates are ignored. To observe which elements are rejected, use the single-element versions of `insert`.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the unordered_map.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [unordered_map::emplace](../vs140/unordered_map--emplace.md) and [unordered_map::emplace_hint](../vs140/unordered_map--emplace_hint.md).  
  
 For a code example, see [map::insert](../vs140/map--insert.md).  
  
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map Class](../vs140/unordered_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)