---
title: "vector::erase"
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
  - "std::vector::erase"
  - "vector::erase"
  - "vector.erase"
  - "std.vector.erase"
  - "Erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: 0b7065d2-da9f-4649-8784-31d8a5edc6bd
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::erase
Removes an element or a range of elements in a vector from specified positions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Position of the element to be removed from the vector.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Position of the first element removed from the vector.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Position just beyond the last element removed from the vector.|  
  
## Return Value  
 An iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the vector if no such element exists.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **v1 = 10 20 30 40 50**  
**v1 = 20 30 40 50**  
**v1 = 20 50**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [vector::empty, vector::erase, and vector::push_back](../vs140/vector--empty--vector--erase--and-vector--push_back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)