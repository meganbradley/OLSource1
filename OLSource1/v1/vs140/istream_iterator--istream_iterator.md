---
title: "istream_iterator::istream_iterator"
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
  - "iterator/std::istream_iterator::istream_iterator"
  - "istream_iterator.istream_iterator"
  - "istream_iterator"
  - "std::istream_iterator::istream_iterator"
  - "std.istream_iterator.istream_iterator"
  - "istream_iterator::istream_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "istream_iterator class, constructor"
  - "istream_iterator method"
ms.assetid: 6150d495-c4da-40c6-aa23-dde98ea1e806
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istream_iterator::istream_iterator
Constructs either an end-of-stream iterator as the default <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> initialized to the iterator's stream type from which it reads.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The input stream to be read use to initialize the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The First constructor initializes the input stream pointer with a null pointer and creates an end-of-stream iterator. The second constructor initializes the input stream pointer with *&_Istr*, then attempts to extract and store an object of type **Type**.  
  
 The end-of-stream iterator can be use to test whether an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> has reached the end of a stream.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>Enter 4 integers separated by spaces & then**  
 **a character ( try example: '2 4 6 8 a' ): 2 4 6 8 a**  
**vec = 2 4 6 8**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [istream_iterator Class](../vs140/istream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)