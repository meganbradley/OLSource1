---
title: "not1 (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "not1 (STL/CLR)"
f1_keywords: 
  - "cliext::not1"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "not1 function [STL/CLR]"
ms.assetid: a50cd819-10de-4d81-84da-8a34c5414a43
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# not1 (STL-CLR)
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
 The template function returns [unary_negate](../vs140/unary_negate--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You use it as a convenient way to wrap a one-argument functor in a functor that delivers its logical NOT.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **4 0**  
 **1 0**  
 **1 0**   
## Requirements  
 **Header:** \<cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [unary_negate](../vs140/unary_negate--stl-clr-.md)