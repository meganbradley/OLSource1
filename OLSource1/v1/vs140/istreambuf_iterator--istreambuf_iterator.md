---
title: "istreambuf_iterator::istreambuf_iterator"
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
  - "istreambuf_iterator"
  - "istreambuf_iterator.istreambuf_iterator"
  - "istreambuf_iterator::istreambuf_iterator"
  - "std::istreambuf_iterator::istreambuf_iterator"
  - "streambuf/std::istreambuf_iterator::istreambuf_iterator"
  - "std.istreambuf_iterator.istreambuf_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "istreambuf_iterator class, constructor"
  - "istreambuf_iterator method"
ms.assetid: e9eea9b9-00d9-40c9-9a09-9bc387e0d8d5
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# istreambuf_iterator::istreambuf_iterator
Constructs an istreambuf_iterator that is initialized to read characters from the input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input stream buffer to which the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is being attached.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The input stream to which the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is being attached.  
  
## Remarks  
 The first constructor initializes the input stream-buffer pointer with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The second constructor initializes the input stream-buffer pointer with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and then eventually attempts to extract and store an object of type **CharType**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>(Try the example: 'Oh what a world!'**  
 **then an Enter key to insert into the output,**  
 **& use a ctrl-Z Enter key combination to exit): Oh what a world!**  
**Oh-what-a-world!**  
**^Z**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [istreambuf_iterator Class](../vs140/istreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)