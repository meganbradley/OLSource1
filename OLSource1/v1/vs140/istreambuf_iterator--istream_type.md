---
title: "istreambuf_iterator::istream_type"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.istreambuf_iterator.istream_type
  - istreambuf_iterator.istream_type
  - streambuf/std::istreambuf_iterator::istream_type
  - istreambuf_iterator::istream_type
  - std::istreambuf_iterator::istream_type
  - istream_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - istream_type typedef
ms.assetid: 0db489dc-48f8-44a4-b769-72f5d45780b3
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# istreambuf_iterator::istream_type
A type that provides for the stream type of the `istreambuf_iterator`.  
  
## Syntax  
  
```  
  
typedef basic_istream<CharType, Traits> istream_type;  
  
```  
  
## Remarks  
 The type is a synonym for `basic_istream`<**CharType**, **Traits**>.  
  
## Example  
 See [istreambuf_iterator](../vs140/istreambuf_iterator--istreambuf_iterator.md) for an example of how to declare and use `istream_type`.  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [istreambuf_iterator Class](../vs140/istreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)