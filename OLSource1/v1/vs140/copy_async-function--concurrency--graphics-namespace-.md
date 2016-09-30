---
title: "copy_async Function (Concurrency::graphics Namespace)"
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
  - "amp_short_vectors/Concurrency::graphics::copy_async"
dev_langs: 
  - "C++"
ms.assetid: 76cedd5a-bf84-40bd-b0b5-57026a261aad
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copy_async Function (Concurrency::graphics Namespace)
Asynchronously copies a source texture into a destination buffer, or copies a source buffer into a destination buffer, and then returns a [completion_future](../vs140/completion_future-class.md) object that can be waited on. Data can't be copied when code is running on an accelerator. The general form of this function is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The extent of the texture section to be copied.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object to copy to.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of bytes in the destination.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of the destination object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The offset into the destination at which to begin copying.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The type of the input interator.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The type of the output iterator.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 To object to copy.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The number of bytes in the source.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The type of the source object.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The offset into the source from which to begin copying.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A beginning iterator into the source container.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 An ending iterator into the source container.  
  
## Remarks  
 The copy operation always performs a deep copy.  
  
 If the extents of the source and destination objects do not match, a [runtime_exception](../vs140/runtime_exception-class.md) is thrown.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [Concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md)