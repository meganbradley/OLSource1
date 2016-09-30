---
title: "not2 (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "not2 (STL/CLR)"
f1_keywords: 
  - "cliext::not2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "not2 function [STL/CLR]"
ms.assetid: f8aedcca-e4d1-4430-93b4-83dd55579d04
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# not2 (STL-CLR)
Generates a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for a functor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Template Parameters  
 Fun  
 The type of the functor.  
  
## Function Parameters  
 functor  
 The functor to wrap.  
  
## Remarks  
 The template function returns [binary_negate](../vs140/binary_negate--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You use it as a convenient way to wrap a two-argument functor in a functor that delivers its logical NOT.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **4 3**  
 **4 4**  
 **1 0**  
 **1 0**   
## Requirements  
 **Header:** \<cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [binary_negate](../vs140/binary_negate--stl-clr-.md)