---
title: "insert_iterator::insert_iterator"
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
  - "iterator/std::insert_iterator::insert_iterator"
  - "insert_iterator.insert_iterator"
  - "std.insert_iterator.insert_iterator"
  - "std::insert_iterator::insert_iterator"
  - "insert_iterator::insert_iterator"
  - "insert_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert_iterator class, constructor"
  - "insert_iterator method"
ms.assetid: a33c8791-09f0-4777-ac72-05773b633da8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# insert_iterator::insert_iterator
Constructs an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that inserts an element into a specified position in a container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The container into which the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is to insert elements.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The position for the insertion.  
  
## Remarks  
 All containers have the insert member function called by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For associative containers the position parameter is merely a suggestion. The inserter function provides a convenient way to insert to values.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The list L is:**  
 **( 10 20 30 ).**  
**After the insertions, the list L is:**  
 **( 2 10 20 30 300 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [insert_iterator Class](../vs140/insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)