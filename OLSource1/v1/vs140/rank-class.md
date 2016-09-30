---
title: "rank Class"
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
  - "std::tr1::rank"
  - "std.tr1.rank"
  - "rank"
  - "std.rank"
  - "std::rank"
  - "type_traits/std::rank"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rank class [TR1]"
  - "rank"
ms.assetid: bc9f1b8f-800f-46ca-b6f4-d8579ed5406a
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# rank Class
Gets number of array dimensions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 The type query holds the value of the number of dimensions of the array type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or 0 if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not an array type.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **rank\<int> == 0**  
**rank\<int[5]> == 1**  
**rank\<int[5][10]> == 2**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [extent](../vs140/extent-class.md)