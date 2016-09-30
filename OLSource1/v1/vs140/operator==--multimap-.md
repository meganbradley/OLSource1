---
title: "operator== (multimap)"
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
  - "std.=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "map/std::operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=="
  - "== operator"
ms.assetid: a6b0a435-e2f8-49ae-a8a7-e751764d10a7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (multimap)
Tests if the multimap object on the left side of the operator is equal to the multimap object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 **true** if the multimap on the left side of the operator is equal to the multimap on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between multimap objects is based on a pairwise comparison of their elements. Two multimaps are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **m1 and m2 are not equal**  
**m1 and m3 are equal**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)