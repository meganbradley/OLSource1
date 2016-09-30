---
title: "operator!= (map)"
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
  - "std::!="
  - "!="
  - "std::operator!="
  - "std.operator!="
  - "std.!="
  - "map/std::operator!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator !=, maps"
  - "operator!=, maps"
ms.assetid: b68254ec-fd90-448f-8e63-f36bdee8ac3e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (map)
Tests if the map object on the left side of the operator is not equal to the map object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
## Return Value  
 **true** if the maps are not equal; **false** if maps are equal.  
  
## Remarks  
 The comparison between map objects is based on a pairwise comparison of their elements. Two maps are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The maps m1 and m2 are not equal.**  
**The maps m1 and m3 are equal.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)