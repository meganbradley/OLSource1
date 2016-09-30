---
title: "multiset::swap (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multiset::swap (STL/CLR)"
f1_keywords: 
  - "cliext::multiset::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap member [STL/CLR]"
ms.assetid: 8a3023c7-e58b-4ffe-8fd5-2e0bf02cc291
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::swap (STL-CLR)
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
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [multiset](../vs140/multiset--stl-clr-.md)   
 [operator=](../vs140/multiset--operator=--stl-clr-.md)