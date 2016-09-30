---
title: "unordered_set::difference_type"
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
  - "tr1::unordered_set::difference_type"
  - "std::tr1::unordered_set::difference_type"
  - "unordered_set/std::tr1::unordered_set::difference_type"
  - "unordered_set::difference_type"
  - "difference_type"
  - "std.tr1.unordered_set.difference_type"
  - "unordered_set.difference_type"
  - "tr1.unordered_set.difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef [TR1]"
  - "difference_type typedef"
ms.assetid: af77e038-b851-4ed0-b974-f189cc0d0dc0
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::difference_type
The type of a signed distance between two elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in the controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c] [b] [a]**  
**end()-begin() == 3**  
**begin()-end() == -3**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::size_type](../vs140/unordered_set--size_type.md)