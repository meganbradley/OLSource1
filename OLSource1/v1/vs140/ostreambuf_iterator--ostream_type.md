---
title: "ostreambuf_iterator::ostream_type"
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
  - "ostreambuf_iterator.ostream_type"
  - "std::ostreambuf_iterator::ostream_type"
  - "ostream_type"
  - "ostreambuf_iterator::ostream_type"
  - "std.ostreambuf_iterator.ostream_type"
  - "streambuf/std::ostreambuf_iterator::ostream_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostream_type typedef"
ms.assetid: ec98f627-0f27-4fab-a578-9aaf3c028e3d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostreambuf_iterator::ostream_type
A type that provides for the stream type of the `ostream_iterator`.  
  
## Syntax  
  
```  
  
typedef basic_ostream<CharType, Traits> ostream_type;  
  
```  
  
## Remarks  
 The type is a synonym for `basic_ostream`<**CharType**, **Traits**>  
  
## Example  
 See [ostreambuf_iterator](../vs140/ostreambuf_iterator--ostreambuf_iterator.md) for an example of how to declare and use `ostream_type`.  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [ostreambuf_iterator Class](../vs140/ostreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)