---
title: "reverse_iterator::reference"
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
  - "std::reverse_iterator::reference"
  - "Reference"
  - "reverse_iterator.reference"
  - "xutility/std::reverse_iterator::reference"
  - "std.reverse_iterator.reference"
  - "reference"
  - "reverse_iterator::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference method"
  - "reference typedef"
ms.assetid: 6ad778be-e405-4e00-bcc3-df01cd982e58
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::reference
A type that provides a reference to an element addressed by a reverse_iterator.  
  
## Syntax  
  
```  
typedef typename iterator_traits<RandomIterator>::reference reference;  
```  
  
## Remarks  
 The type is a synonym for the iterator trait typename `iterator_traits`\<*RandomIterator*>**::reference**.  
  
## Example  
 See [reverse_iterator::operator&#91;&#93;](../vs140/reverse_iterator--operator.md) or [reverse_iterator::operator*](../vs140/reverse_iterator--operator-.md) for examples of how to declare and use **reference**.  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)