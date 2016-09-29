---
title: "hash_multimap::insert"
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
  - "stdext.hash_multimap.insert"
  - "std.hash_multimap.insert"
  - "hash_multimap::insert"
  - "Insert"
  - "insert"
  - "stdext::hash_multimap::insert"
  - "hash_multimap.insert"
  - "std::hash_multimap::insert"
  - "hash_map/stdext::hash_multimap::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: dcc06c17-b992-468a-a82c-19b5b430f082
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::insert
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Inserts an element or a range of elements into a hash_multimap.  
  
## Syntax  
  
```  
iterator insert(  
   const value_type& Val  
);  
iterator insert(  
   const_iterator Where,  
   const value_type& Val  
);void insert(  
    initializer_list<value_type> IList  
);  
template<class InputIterator>   
   void insert(  
      InputIterator First,  
      InputIterator Last  
);  
template<class ValTy>  
    iterator insert(  
        ValTy&& Val  
);  
template<class ValTy>  
    iterator insert(  
        const_iterator Where,  
        ValTy&& Val  
);  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Val`|The value of an element to be inserted into the hash_multimap unless it already contains that element, or more generally, unless it already contains an element whose key is equivalently ordered.|  
|`Where`|A hint about where to start searching for the correct point of insertion.|  
|`First`|The position of the first element to be copied from a map.|  
|`Last`|The position just beyond the last element to be copied from a map.|  
  
## Return Value  
 The first two `insert` member functions return an iterator that points to the position where the new element was inserted.  
  
 The third member function uses an initializer_list for the elements to be inserted.  
  
 The fourth member function inserts the sequence of element values into a map that corresponds to each element addressed by an iterator in the range `[First, Last)` of a specified set.  
  
 The last two `insert` member functions behave the same as the first two, except that they move-construct the inserted value.  
  
## Remarks  
 The [value_type](../vs140/hash_multimap--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair in which the first component is equal to the key value and the second component is equal to the data value of the element.  
  
 Insertion can occur in amortized constant time for the hint version of `insert`, instead of logarithmic time, if the insertion point immediately follows `Where`.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)