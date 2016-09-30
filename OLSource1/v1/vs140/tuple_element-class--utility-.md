---
title: "tuple_element Class &lt;utility&gt;"
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
  - "std.tr1.tuple_element"
  - "tuple_element"
  - "std::tr1::tuple_element"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tuple_element Class <utility> (TR1)"
ms.assetid: f9db79e8-685c-49e3-97ee-81763e516ce3
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# tuple_element Class &lt;utility&gt;
Wraps the type of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Index  
 The position of the element; for pair this value is either 0 or 1.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the first pair element.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of the second pair element.  
  
 type  
  
## Remarks  
 The templates are specializations of the template class [tuple_element](../vs140/tuple_element-class--tuple-.md). Each has a single member typedef, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which is a synonym for the type of the element at the specified position in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, with any const and/or volatile qualifications preserved. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a convenient alias for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Use the [get Function \<utility>](../vs140/-utility--functions.md#get_function__lt_utility_gt_) to return the element at a specified position or (in C++14 / Visual Studio 2015) of a specified type.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<utility>  
  
 **Namespace:** std  
  
## See Also  
 [\<utility>](../vs140/-utility-.md)   
 [get](../vs140/-utility--functions.md#get_function__lt_utility_gt_)   
 [tuple_size](../vs140/tuple_size-class--utility-.md)