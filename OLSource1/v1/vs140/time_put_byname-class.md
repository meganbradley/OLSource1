---
title: "time_put_byname Class"
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
  - "time_put_byname"
  - "xloctime/std::time_put_byname"
  - "std.time_put_byname"
  - "std::time_put_byname"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "time_put_byname class"
ms.assetid: e08c2348-64d2-4ace-98b1-1496e14c7b1a
caps.latest.revision: 27
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# time_put_byname Class
The derived template class describes an object that can serve as a locale facet of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>\< CharType, OutputIterator >.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A locale name.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An initial reference count.  
  
## Remarks  
 Its behavior is determined by the [named](../vs140/locale-class.md#locale__name) locale <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Each constructor initializes its base object with [time_put](../vs140/time_put-class.md#time_put__time_put)\<CharType, OutputIterator>( <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)