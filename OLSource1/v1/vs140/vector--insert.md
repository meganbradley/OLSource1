---
title: "vector::insert"
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
  - "Insert"
  - "std.vector.insert"
  - "vector::insert"
  - "vector.insert"
  - "std::vector::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: de278aeb-61df-459e-bd14-35bfde4511a2
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::insert
Inserts an element or a number of elements or a range of elements into the vector at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The position in the vector where the first element is inserted.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The value of the element being inserted into the vector.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The number of elements being inserted into the vector.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
  
## Return Value  
 The first two <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions return an iterator that points to the position where the new element was inserted into the vector.  
  
## Remarks  
 Any insertion operation can be expensive, see [vector Class](../vs140/vector-class.md) for a discussion of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> performance.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **v1 = 10 20 30**  
**v1 = 10 40 20 30**  
**v1 = 10 40 50 50 50 50 20 30**  
**v1 = 10 50 50 40 50 50 50 50 20 30**  
**vv1[0] = 10 50 50 40 50 50 50 50 20 30**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)