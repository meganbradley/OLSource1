---
title: "multimap::value_type"
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
  - "multimap.value_type"
  - "std.multimap.value_type"
  - "multimap::value_type"
  - "map/std::multimap::value_type"
  - "std::multimap::value_type"
  - "value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef"
ms.assetid: 57b6ae00-9e6c-4131-9e58-418212735c18
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::value_type
A type that represents the type of object stored as an element in a map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remark  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is declared to be <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> *\<***const** [key_type](../vs140/multimap--key_type.md), [mapped_type](../vs140/multimap--mapped_type.md)*>* and not <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> *<*<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>*>*, because the keys of an associative container may not be changed using a nonconstant iterator or reference.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The key of first element in the multimap is 1.**  
**The data value of first element in the multimap is 10.**  
**The keys of the mapped elements are: 1 2.**  
**The values of the mapped elements are: 10 20.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)