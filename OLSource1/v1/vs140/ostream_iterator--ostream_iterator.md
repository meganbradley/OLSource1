---
title: "ostream_iterator::ostream_iterator"
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
  - "ostream_iterator"
  - "ostream_iterator::ostream_iterator"
  - "std.ostream_iterator.ostream_iterator"
  - "ostream_iterator.ostream_iterator"
  - "iterator/std::ostream_iterator::ostream_iterator"
  - "std::ostream_iterator::ostream_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostream_iterator class, constructor"
  - "ostream_iterator method"
ms.assetid: ebbd7573-50b8-46dd-8345-0cad6bae6d86
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostream_iterator::ostream_iterator
Constructs an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that is initialized and delimited to write to the output stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The output stream of type [ostream_iterator::ostream_type](../vs140/ostream_iterator--ostream_type.md) to be iterated over.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The delimiter that is inserted into the output stream between values.  
  
## Remarks  
 The first constructor initializes the output stream pointer with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The delimiter string pointer designates an empty string.  
  
 The second constructor initializes the output stream pointer with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and the delimiter string pointer with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **10**  
**20**  
**Elements output without delimiter: 123456**  
**Elements output with delimiter: 1 : 2 : 3 : 4 : 5 : 6 :**    
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [ostream_iterator Class](../vs140/ostream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)