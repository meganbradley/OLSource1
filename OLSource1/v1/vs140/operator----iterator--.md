---
title: "operator- (&lt;iterator&gt;)"
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
  - "std.-"
  - "-"
  - "operator-"
  - "iterator/std::operator-"
  - "std.operator-"
  - "std::-"
  - "std::operator-"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "- operator"
  - "- operator, iterator"
ms.assetid: 17101465-ad41-498c-bac6-f333b99ac488
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator- (&lt;iterator&gt;)
Subtracts one iterator from another and returns the difference.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An iterator.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An iterator.  
  
## Return Value  
 The difference between two iterators<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Remarks  
 The first template operator returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The second template operator returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is determined by the type of the returned expression. Otherwise, it is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial vector vec is: ( 0 2 4 6 8 10 ).**  
**The iterators rVPOS1 & rVPOS2 initially point to the first element**  
 **in the reversed sequence: 10.**  
**The iterator rVPOS2 now points to the fifth element**  
 **in the reversed sequence: 2.**  
**The difference: rVPOS2 - rVPOS1= 4.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)