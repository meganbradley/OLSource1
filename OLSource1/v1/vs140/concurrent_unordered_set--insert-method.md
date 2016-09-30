---
title: "concurrent_unordered_set::insert Method"
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
  - "concurrent_unordered_set/concurrency::concurrent_unordered_set::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: 60fe2015-234b-4d70-bb79-e232b14ea330
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_set::insert Method
Adds elements to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The iterator type used for insertion.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the value inserted into the set.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The value to be inserted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The starting location to search for an insertion point.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The beginning of the range to insert.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The end of the range to insert.  
  
## Return Value  
 A pair that contains an iterator and a boolean value. See the Remarks section for more details.  
  
## Remarks  
 The first member function determines whether an element X exists in the sequence whose key has equivalent ordering to that of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If not, it creates such an element X and initializes it with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The function then determines the iterator <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that designates X. If an insertion occurred, the function returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Otherwise, it returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The second member function returns insert(<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>), using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> as a starting place within the controlled sequence to search for the insertion point.  
  
 The third member function inserts the sequence of element values from the range [<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>).  
  
 The last two member functions behave the same as the first two, except that <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is used to construct the inserted value.  
  
## Requirements  
 **Header:** concurrent_unordered_set.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_set Class](../vs140/concurrent_unordered_set-class.md)