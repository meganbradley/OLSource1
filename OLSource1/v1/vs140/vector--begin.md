---
title: "vector::begin"
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
  - "vector.begin"
  - "vector::begin"
  - "std.vector.begin"
  - "std::vector::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method, with specific classes"
ms.assetid: 5ab4af74-ab67-41f0-93dc-716a1d23e8cc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::begin
Returns a random-access iterator to the first element in the vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A random-access iterator addressing the first element in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or to the location succeeding an empty <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You should always compare the value returned with [vector::end](../vs140/vector--end.md) to ensure it is valid.  
  
## Remarks  
 If the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is assigned to a [vector::const_iterator](../vs140/vector--const_iterator.md), the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object cannot be modified. If the return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is assigned to an [vector::iterator](../vs140/vector--iterator.md), the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector c1 contains elements: 1 2**  
**The vector c1 now contains elements: 20 2**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)