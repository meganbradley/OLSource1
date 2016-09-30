---
title: "back_insert_iterator::operator++"
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
  - "std::back_insert_iterator::operator++"
  - "operator++"
  - "std.back_insert_iterator.operator++"
  - "++"
  - "iterator/std::back_insert_iterator::operator++"
  - "back_insert_iterator::operator++"
  - "back_insert_iterator.operator++"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "++ operator"
  - "operator++"
  - "++ operator, with specific objects"
ms.assetid: a89795aa-c712-4c8a-9a75-2e03e65f0b23
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# back_insert_iterator::operator++
Increments the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the next location into which a value may be stored.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> addressing the next location into which a value may be stored.  
  
## Remarks  
 Both preincrementation and postincrementation operators return the same result.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector vec is: ( 10 20 ).**  
**After the insertions, the vector vec becomes: ( 10 20 30 40 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [back_insert_iterator Class](../vs140/back_insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)