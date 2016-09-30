---
title: "move_iterator::operator++"
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
  - "operator++"
  - "iterator/std::move_iterator::operator++"
  - "move_iterator::operator++"
  - "move_iterator.operator++"
  - "std::move_iterator::operator++"
  - "std.move_iterator.operator++"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator++"
  - "operator++ operator"
ms.assetid: 12cd1feb-3d2f-4308-8d7f-5d366c9d753b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# move_iterator::operator++
Increments the stored iterator that belongs to this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> The current element is accessed by the postincrement operator. The next element is accessed by the preincrement operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
## Property Value/Return Value  
 The preincrement version of the operator returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 The postincrement version of the operator returns a copy of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> made before the operator evaluates <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first (preincrement) operator increments the stored iterator. Then returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The second (postincrement) operator makes a copy of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, evaluates <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Then returns the copy.  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [move_iterator Class](../vs140/move_iterator-class.md)   
 [\<iterator>](../vs140/-iterator-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)