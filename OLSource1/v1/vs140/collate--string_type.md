---
title: "collate::string_type"
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
  - "locale/std::collate::string_type"
  - "std.collate.string_type"
  - "string_type"
  - "collate.string_type"
  - "collate::string_type"
  - "std::collate::string_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "string_type typedef"
ms.assetid: 405af874-dbfd-4db7-9094-217c7f689663
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collate::string_type
A type that describes a string of type `basic_string` containing characters of type **CharType**.  
  
## Syntax  
  
```  
  
typedef basic  
_  
string<CharType> string  
_  
type;  
  
```  
  
## Remarks  
 The type describes a specialization of template class [basic_string](../vs140/basic_string-class.md) whose objects can store copies of the source sequence.  
  
## Example  
 For an example of how to declare and use `string_type`, see [transform](../vs140/collate--transform.md).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [collate Class](../vs140/collate-class.md)