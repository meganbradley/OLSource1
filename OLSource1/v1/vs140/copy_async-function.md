---
title: "copy_async Function"
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
  - "amp/Concurrency::copy_async"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy_async function"
ms.assetid: 6f06115b-1b85-43f4-a3b7-019af90748ec
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copy_async Function
Copies a C++ AMP object and returns a [completion_future](../vs140/completion_future-class.md) object that can be waited on. You can't copy data when running code on an accelerator.  The general form of this function is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object to copy to.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An output iterator to the beginning position at destination.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of the input interator.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of the output iterator.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The rank of the object to copy from or the object to copy to.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 To object to copy.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A beginning iterator into the source container.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 An ending iterator into the source container.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The data type of the elements that are copied.  
  
## Return Value  
 A <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that can be waited on.  
  
## Remarks  
 The copy operation always performs a deep copy.  
  
 If the extents of the source and destination objects do not match, a [runtime_exception](../vs140/runtime_exception-class.md) is thrown.  
  
 You can copy to [array](../vs140/array-class.md) and [array_view](../vs140/array_view-class.md) objects from the following sources:  
  
-   An <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that has the same rank and element type as the destination <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
-   A standard container whose element type is the same as the destination <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Containers that expose <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> members perform more efficiently.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)