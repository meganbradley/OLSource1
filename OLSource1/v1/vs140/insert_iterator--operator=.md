---
title: "insert_iterator::operator="
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
  - "="
  - "operator="
  - "std.insert_iterator.operator="
  - "insert_iterator::operator="
  - "insert_iterator.operator="
  - "std::insert_iterator::operator="
  - "iterator/std::insert_iterator::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, iterators"
  - "operator =, iterators"
  - "= operator, with specific standard C++ library objects"
ms.assetid: 5e798f53-d461-479f-8589-bb889b6eef1e
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# insert_iterator::operator=
Inserts a value into the container and returns the iterator updated to point to the new element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value to be assigned to the container.  
  
## Return Value  
 A reference to the element inserted into the container.  
  
## Remarks  
 The first member operator evaluates  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>;  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 then returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The second member operator evaluates  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 then returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original list L is:**  
 **( 0 2 4 6 ).**  
**After the insertions, the list L is:**  
 **( 10 20 30 0 2 4 6 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [insert_iterator Class](../vs140/insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)