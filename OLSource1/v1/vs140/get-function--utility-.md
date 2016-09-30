---
title: "get Function &lt;utility&gt;"
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
  - "get"
  - "std::tr1::get"
  - "std.tr1.get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get function [TR1]"
ms.assetid: 2426d22e-f6d6-4c22-ba90-4de5fd0ea4e7
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# get Function &lt;utility&gt;
Gets an element from a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object by index position, or by type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The 0-based index of the designated element.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of the first pair element.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of the second pair element.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The pair to select from.  
  
## Remarks  
 The template functions each return a reference to an element of its <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> argument.  
  
 For the indexed overloads, if the value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is 0 the functions return <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and if the value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is 1 the functions return <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the type of the returned element.  
  
 For the overloads that do not have an Index parameter, the element to return is deduced by the type argument. Calling <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> will produce a compiler error if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> contains more or less than one element of type T.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<utility>  
  
 **Namespace:** std  
  
## See Also  
 [\<utility>](../vs140/-utility-.md)   
 [tuple_element](../vs140/tuple_element-class--utility-.md)   
 [tuple_size](../vs140/tuple_size-class--utility-.md)