---
title: "ostreambuf_iterator::ostreambuf_iterator"
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
  - "std.ostreambuf_iterator.ostreambuf_iterator"
  - "ostreambuf_iterator::ostreambuf_iterator"
  - "std::ostreambuf_iterator::ostreambuf_iterator"
  - "streambuf/std::ostreambuf_iterator::ostreambuf_iterator"
  - "ostreambuf_iterator.ostreambuf_iterator"
  - "ostreambuf_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostreambuf_iterator method"
  - "ostreambuf_iterator class, constructor"
ms.assetid: 2d66302f-0ee4-4e52-9817-731e6f410845
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostreambuf_iterator::ostreambuf_iterator
Constructs an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that is initialized to write characters to the output stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The output streambuf object used to initialize the output stream-buffer pointer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The output stream object used to initialize the output stream-buffer pointer.  
  
## Remarks  
 The first constructor initializes the output stream-buffer pointer with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The second constructor initializes the output stream-buffer pointer with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The stored pointer must not be a null pointer.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **OUT are characters output individually.**  
**These characters are being written to the output stream.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [ostreambuf_iterator Class](../vs140/ostreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)