---
title: "bind2nd (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "bind2nd (STL/CLR)"
f1_keywords: 
  - "cliext::bind2nd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bind2nd function [STL/CLR]"
ms.assetid: 457cebea-38e4-4466-a468-fe9eb138e80c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bind2nd (STL-CLR)
Generates a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for an argument and functor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Template Parameters  
 Arg  
 The type of the argument.  
  
 Fun  
 The type of the functor.  
  
## Function Parameters  
 functor  
 The functor to wrap.  
  
 right  
 The second argument to wrap.  
  
## Remarks  
 The template function returns [binder2nd](../vs140/binder2nd--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You use it as a convenient way to wrap a two-argument functor and its second argument in a one-argument functor that calls it with a first argument.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **4 3**  
 **0 -1**  
 **0 -1**   
## Requirements  
 **Header:** \<cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [binder2nd](../vs140/binder2nd--stl-clr-.md)