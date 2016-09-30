---
title: "operator&gt;= (multiset)"
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
  - "operator>="
  - "std::>="
  - "std.operator>="
  - ">="
  - "set/std::operator>="
  - "std.>="
  - "std::operator>="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ">= operator"
  - "operator>="
ms.assetid: 5de6be94-3d48-4bb6-aa96-d07999f3d58f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;= (multiset)
Tests if the multiset object on the left side of the operator is greater than or equal to the multiset object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 **true** if the multiset on the left side of the operator is greater than or equal to the multiset on the right side of the list; otherwise **false**.  
  
## Remarks  
 The comparison between multiset objects is based on a pairwise comparison of their elements. The greater than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The multiset s1 is less than the multiset s2.**  
**The multiset s1 is greater than or equal to the multiset s3.**  
**The multiset s1 is greater than or equal to the multiset s4.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)