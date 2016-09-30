---
title: "time_get_byname Class"
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
  - "std.time_get_byname"
  - "time_get_byname"
  - "xloctime/std::time_get_byname"
  - "std::time_get_byname"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "time_get_byname class"
ms.assetid: 6e54153e-da40-4bb9-a942-1a6ce57b30c9
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get_byname Class
The derived template class describes an object that can serve as a locale facet of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>\<CharType, InputIterator>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A named locale.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An initial reference count.  
  
## Requirements  
 Its behavior is determined by the named locale <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Each constructor initializes its base object with [time_get](../vs140/time_get-class.md#time_get__time_get)\<CharType, InputIterator>( <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)