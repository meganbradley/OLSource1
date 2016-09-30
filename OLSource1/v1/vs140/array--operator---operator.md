---
title: "array::operator() Operator"
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
  - "amp/Concurrency::array::operator()"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator()"
ms.assetid: aea59605-4038-4826-9dfb-99babc971ac3
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::operator() Operator
Returns the element value that is specified by the parameters.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The location of the element.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The most significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The least significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The location of the element.  
  
## Return Value  
 The element value specified by the parameters.  
  
## Remarks  
 The overloads that have <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameters enable you to retrieve references to values in the [array](../vs140/array-class.md) without having to create an [index](../vs140/index-class.md) object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)