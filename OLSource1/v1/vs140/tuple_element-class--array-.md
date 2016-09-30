---
title: "tuple_element Class &lt;array&gt;"
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
  - "tuple_element Class <array> (TR1)"
ms.assetid: 99201ca4-190a-4d9e-9013-de95ddfe5901
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# tuple_element Class &lt;array&gt;
Wraps the type of an array element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The element position.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of an element.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size of the array.  
  
## Remarks  
 This template class is a specialization of the template class [tuple_element](../vs140/tuple_element-class--tuple-.md) for arrays. This class provides an interface to an array as a tuple of N elements, each of which has the same type. Each specialization has a nested typedef <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that is a synonym for the type of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, with any const-volatile qualifications preserved.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
## See Also  
 [\<array>](../vs140/-array-.md)   
 [\<tuple>](../vs140/-tuple-.md)   
 [tuple_element](../vs140/tuple_element-class--tuple-.md)