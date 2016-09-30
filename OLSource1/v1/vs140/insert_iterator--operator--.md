---
title: "insert_iterator::operator++"
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
  - "std.insert_iterator.operator++"
  - "operator++"
  - "++"
  - "iterator/std::insert_iterator::operator++"
  - "std::insert_iterator::operator++"
  - "insert_iterator.operator++"
  - "insert_iterator::operator++"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "++ operator"
  - "operator++"
  - "++ operator, with specific objects"
ms.assetid: aa71ffe0-f6f3-416a-b70b-ef63a930564a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# insert_iterator::operator++
Increments the **insert_iterator** to the next location into which a value may be stored.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> addressing the next location into which a value may be stored.  
  
## Remarks  
 Both preincrementation and postincrementation operators return the same result.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector vec is:**  
 **( 1 2 3 4 ).**  
**After the insertions, the vector vec becomes:**  
 **( 30 40 50 1 2 3 4 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [insert_iterator Class](../vs140/insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)