---
title: "ref Function"
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
  - "functional/std::tr1::ref"
  - "std::tr1::ref"
  - "std.tr1.ref"
  - "ref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ref function [TR1]"
ms.assetid: 71b722a3-7e81-4773-8122-b59e6bb4da65
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ref Function
Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> from an argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; specifically, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 The following example defines two functions: one bound to a string variable, the other bound to a reference of the string variable computed by a call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. When the value of the variable changes, the first function continues to use the old value and the second function uses the new value.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **tiger cat lion cougar**  
**tiger lion cougar**  
**tiger lion cougar**  
**tiger cougar**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [cref](../vs140/cref-function.md)   
 [reference_wrapper](../vs140/reference_wrapper-class.md)