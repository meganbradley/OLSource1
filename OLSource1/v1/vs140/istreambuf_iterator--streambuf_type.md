---
title: "istreambuf_iterator::streambuf_type"
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
  - "streambuf_type"
  - "streambuf/std::istreambuf_iterator::streambuf_type"
  - "istreambuf_iterator::streambuf_type"
  - "istreambuf_iterator.streambuf_type"
  - "std::istreambuf_iterator::streambuf_type"
  - "std.istreambuf_iterator.streambuf_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "streambuf_type typedef"
ms.assetid: ad44f0f7-17f2-4533-b29b-abf8af9b86d1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istreambuf_iterator::streambuf_type
A type that provides for the stream type of the istreambuf_iterator.  
  
## Syntax  
  
```  
  
typedef basic_streambuf<CharType, Traits> streambuf_type;  
  
```  
  
## Remarks  
 The type is a synonym for `basic_streambuf`\<**CharType**, **Traits**>.  
  
## Example  
 See [istreambuf_iterator](../vs140/istreambuf_iterator--istreambuf_iterator.md) for an example of how to declare and use **istreambuf_type**.  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [istreambuf_iterator Class](../vs140/istreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)