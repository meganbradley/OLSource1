---
title: "concurrent_unordered_multimap::insert Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - concurrent_unordered_map/concurrency::concurrent_unordered_multimap::insert
dev_langs: 
  - C++
helpviewer_keywords: 
  - insert method
ms.assetid: 6da233d1-1809-42c6-a8ab-75959c3891c1
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_multimap::insert Method
Adds elements to the `concurrent_unordered_multimap` object.  
  
## Syntax  
  
```  
iterator insert(  
   const value_type& _Value  
);  
  
iterator insert(  
   const_iterator _Where,  
   const value_type& _Value  
);  
  
template<  
   class _Iterator  
>  
void insert(  
   _Iterator_First,  
   _Iterator_Last  
);  
  
template<  
   class _Valty  
>  
iterator insert(  
   _Valty&& _Value  
);  
  
template<  
   class _Valty  
>  
typename std::tr1::enable_if<!std::tr1::is_same<const_iterator, typename std::tr1::remove_reference<_Valty>::type>::value, iterator>::type insert(  
   const_iterator _Where,  
   _Valty&& _Value  
);  
```  
  
#### Parameters  
 `_Iterator`  
 The iterator type used for insertion.  
  
 `_Valty`  
 The type of the value inserted into the map.  
  
 `_Value`  
 The value to be inserted.  
  
 `_Where`  
 The starting location to search for an insertion point.  
  
 `_First`  
 The beginning of the range to insert.  
  
 `_Last`  
 The end of the range to insert.  
  
## Return Value  
 An iterator pointing to the insertion location.  
  
## Remarks  
 The first member function inserts the element `_Value` in the controlled sequence, then returns the iterator that designates the inserted element.  
  
 The second member function returns insert(`_Value`), using `_Where` as a starting place within the controlled sequence to search for the insertion point.  
  
 The third member function inserts the sequence of element values from the range [`_First`, `_Last`).  
  
 The last two member functions behave the same as the first two, except that `_Value` is used to construct the inserted value.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multimap Class](../vs140/concurrent_unordered_multimap-class.md)