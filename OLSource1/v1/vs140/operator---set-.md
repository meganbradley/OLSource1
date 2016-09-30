---
title: "operator&gt; (set)"
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
  - "std::operator>"
  - "std.>"
  - "std.operator>"
  - "operator>"
  - "std::>"
  - ">"
  - "set/std::operator>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator >, set or multiset objects"
  - "> operator, comparing specific objects"
ms.assetid: 0a43c029-79bb-466a-a6d8-9f005cd04b26
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (set)
Tests if the set object on the left side of the operator is greater than the set object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
## Return Value  
 **true** if the set on the left side of the operator is greater than the set on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between set objects is based on a pairwise comparison of their elements. The greater-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The set s1 is not greater than the set s2.**  
**The set s1 is greater than the set s3.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)