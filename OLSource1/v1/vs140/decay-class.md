---
title: "decay Class"
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
  - "decay"
  - "std.tr1.decay"
  - "std::tr1::decay"
  - "std.decay"
  - "std::decay"
  - "type_traits/std::decay"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "decay class[TR1]"
ms.assetid: 96baa2fd-c8e0-49af-be91-ba375ba7f9dc
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# decay Class
Produces the type as passed by value. Makes the type non-reference, non-const, non-volatile, or makes a pointer to the type from a function or an array type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type to modify.  
  
## Remarks  
 Use the decay template to produce the resulting type as if the type was passed by value as an argument. The template class member typedef <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> holds a modified type that is defined in the following stages:  
  
-   The type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is defined as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
-   If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is true, the modified type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
-   Otherwise, if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is true, the modified type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
-   Otherwise, the modified type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)