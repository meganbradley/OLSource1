---
title: "operator== (unordered_multiset)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: a98d262f-bdd4-4f2a-bfb5-f94a3f0f1d66
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (unordered_multiset)
Tests whether the [unordered_multiset](../vs140/unordered_multiset-class.md) object on the left side of the operator is equal to the unordered_multiset object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the unordered_multisets are equal; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if they are not equal.  
  
## Remarks  
 The comparison between unordered_multiset objects is not affected by the arbitrary order in which they store their elements. Two unordered_multisets are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output:**  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)