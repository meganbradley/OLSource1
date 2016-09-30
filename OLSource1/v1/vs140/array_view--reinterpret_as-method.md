---
title: "array_view::reinterpret_as Method"
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
  - "amp/Concurrency::array_view::reinterpret_as"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reinterpret_as method"
ms.assetid: e57f2045-127d-4bca-9ae5-f38635a857a0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array_view::reinterpret_as Method
Reinterprets the array_view through a one-dimensional array_view, which as an option can have a different value type than the source array_view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The data type of the new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Return Value  
 An <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object or a const <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that is based on this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, with the element type converted from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and the rank reduced from *N* to 1.  
  
## Remarks  
 Sometimes it is convenient to view a multi-dimensional array as a linear, one-dimensional array, which may have a different value type than the source array. You can achieve this on an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> by using this method.  
  
> [!WARNING]
>  Reinterpeting an array_view object by using a different value type is a potentially unsafe operation. This functionality should be used with care.  
  
 Here's an example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array_view Class](../vs140/array_view-class.md)