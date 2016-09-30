---
title: "hash_multimap::hash_delegate (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multimap::hash_delegate (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multimap::hash_delegate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_delegate member [STL/CLR]"
ms.assetid: 2a459f6d-9bb1-4b03-a013-0998ba842c25
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::hash_delegate (STL-CLR)
Finds an element that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the delegate used to convert a key value to an integer. You use it to hash a key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **hash(L'a') = 1616896120**  
**hash(L'b') = 570892832**   
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multimap](../vs140/hash_multimap--stl-clr-.md)   
 [hasher](../vs140/hash_multimap--hasher--stl-clr-.md)