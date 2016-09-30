---
title: "concurrent_unordered_multimap::insert Method"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_multimap::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: 6da233d1-1809-42c6-a8ab-75959c3891c1
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_multimap::insert Method
Adds elements to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The iterator type used for insertion.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the value inserted into the map.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The value to be inserted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The starting location to search for an insertion point.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The beginning of the range to insert.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The end of the range to insert.  
  
## Return Value  
 An iterator pointing to the insertion location.  
  
## Remarks  
 The first member function inserts the element <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the controlled sequence, then returns the iterator that designates the inserted element.  
  
 The second member function returns insert(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>), using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as a starting place within the controlled sequence to search for the insertion point.  
  
 The third member function inserts the sequence of element values from the range [<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>).  
  
 The last two member functions behave the same as the first two, except that <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is used to construct the inserted value.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multimap Class](../vs140/concurrent_unordered_multimap-class.md)