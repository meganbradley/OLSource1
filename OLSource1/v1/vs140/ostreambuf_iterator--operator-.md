---
title: "ostreambuf_iterator::operator*"
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
  - "ostreambuf_iterator.operator*"
  - "ostreambuf_iterator::operator*"
  - "operator*"
  - "streambuf/std::ostreambuf_iterator::operator*"
  - "std::ostreambuf_iterator::operator*"
  - "std.ostreambuf_iterator.operator*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "* operator"
  - "operator*"
  - "* operator, with specific iterator expressions"
  - "multiplication operator, iterator expressions"
ms.assetid: 54b8073b-7071-4825-8c83-f7a0b7a7f1a4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostreambuf_iterator::operator*
A nonfunctional dereferencing operator used to implement the output iterator expression \**i* = *x*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The ostreambuf iterator object.  
  
## Remarks  
 This operator functions only in the output iterator expression \**i* = *x* to output characters to stream buffer. Applied to an ostreambuf iterator, it returns the iterator; **\*iter** returns **iter**,  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Elements written to output stream:**  
**OUT**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [ostreambuf_iterator Class](../vs140/ostreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)