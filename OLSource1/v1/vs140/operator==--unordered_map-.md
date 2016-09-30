---
title: "operator== (unordered_map)"
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
ms.assetid: 02c0b110-2e07-4198-aa8b-fbea796c7f1f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (unordered_map)
Tests whether the [unordered_map](../vs140/unordered_map-class.md) object on the left side of the operator is equal to the unordered_map object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the unordered_maps are equal; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if they are not equal.  
  
## Remarks  
 The comparison between unordered_map objects is not affected by the arbitrary order in which they store their elements. Two unordered_maps are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output:**  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)