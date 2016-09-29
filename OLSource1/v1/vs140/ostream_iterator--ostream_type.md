---
title: "ostream_iterator::ostream_type"
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
  - "ostream_iterator.ostream_type"
  - "std.ostream_iterator.ostream_type"
  - "ostream_type"
  - "ostream_iterator::ostream_type"
  - "iterator/std::ostream_iterator::ostream_type"
  - "std::ostream_iterator::ostream_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostream_type typedef"
ms.assetid: 1b102a99-85bc-4ede-9c0c-b13e1c1fd819
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostream_iterator::ostream_type
A type that provides for the stream type of the iterator.  
  
## Syntax  
  
```  
typedef basic_ostream<CharType, Traits> ostream_type;  
```  
  
## Remarks  
 The type is a synonym for [basic_ostream](../vs140/basic_ostream-class.md)<`CharType`, `Traits`>, a stream class of the iostream hierarchy that defines objects that can be used for writing.  
  
## Example  
 See [ostream_iterator](../vs140/ostream_iterator--ostream_iterator.md) for an example of how to declare and use `ostream_type`.  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [ostream_iterator Class](../vs140/ostream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)