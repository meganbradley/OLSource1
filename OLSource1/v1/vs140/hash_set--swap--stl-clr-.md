---
title: "hash_set::swap (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::swap (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap member [STL/CLR]"
ms.assetid: 6476e48f-4744-486d-b028-cf0a048acd4d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::swap (STL-CLR)
Swaps the contents of two containers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 right  
 Container to swap contents with.  
  
## Remarks  
 The member function swaps the controlled sequences between <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. It does so in constant time and it throws no exceptions. You use it as a quick way to exchange the contents of two containers.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **d e f**  
 **d e f**  
 **a b c**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [operator=](../vs140/hash_set--operator=--stl-clr-.md)