---
title: "Concurrency::graphics namespace functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: ace01cd5-29d3-4356-930e-c81a61c5f934
caps.latest.revision: 10
---
# Concurrency::graphics namespace functions
|||  
|-|-|  
|[copy Function (Concurrency::graphics Namespace)](#copy_function__concurrency__graphics_namespace_)|[copy_async Function (Concurrency::graphics Namespace)](#copy_async_function__concurrency__graphics_namespace_)|  
  
##  \<a name="copy_function__concurrency__graphics_namespace_">\</a>  copy Function (Concurrency::graphics Namespace)  
 Copies a source texture into a destination buffer, or copies a source buffer into a destination buffer. The general form of this function is                 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The extent of the texture section to be copied.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The object to copy to.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of bytes in the destination.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type of the destination object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The offset into the destination at which to begin copying.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The type of the input interator.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The type of the output iterator.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 To object to copy.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The number of bytes in the source.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The type of the source object.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The offset into the source from which to begin copying.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A beginning iterator into the source container.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 An ending iterator into the source container.  
  
##  \<a name="copy_async_function__concurrency__graphics_namespace_">\</a>  copy_async Function (Concurrency::graphics Namespace)  
 Asynchronously copies a source texture into a destination buffer, or copies a source buffer into a destination buffer, and then returns a                 [completion_future](../vs140/completion_future-class.md) object that can be waited on. Data can't be copied when code is running on an accelerator. The general form of this function is                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The extent of the texture section to be copied.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The object to copy to.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The number of bytes in the destination.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The type of the destination object.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The offset into the destination at which to begin copying.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The type of the input interator.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The type of the output iterator.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 To object to copy.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The number of bytes in the source.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The type of the source object.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The offset into the source from which to begin copying.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A beginning iterator into the source container.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 An ending iterator into the source container.  
  
## See Also  
 [Concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md)