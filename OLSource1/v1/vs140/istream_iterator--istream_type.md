---
title: "istream_iterator::istream_type"
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
  - "istream_iterator::istream_type"
  - "iterator/std::istream_iterator::istream_type"
  - "istream_iterator.istream_type"
  - "std.istream_iterator.istream_type"
  - "std::istream_iterator::istream_type"
  - "istream_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "istream_type typedef"
ms.assetid: 0bc44f44-f5d2-4e09-91b3-0a75042f9c2c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istream_iterator::istream_type
A type that provides for the stream type of the `istream_iterator`.  
  
## Syntax  
  
```  
  
typedef basic_istream<CharType, Traits> istream_type;  
  
```  
  
## Remarks  
 The type is a synonym for `basic_istream`<**CharType**, **Traits**>.  
  
## Example  
 See [istream_iterator](../vs140/istream_iterator--istream_iterator.md) for an example of how to declare and use `istream_type`.  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [istream_iterator Class](../vs140/istream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)