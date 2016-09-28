---
title: "filebuf"
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
  - "std.filebuf"
  - "filebuf"
  - "std::filebuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "filebuf function"
ms.assetid: ab9a79c5-e178-42a2-8668-fa60cacc9579
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# filebuf
A type `basic_filebuf` specialized on `char` template parameters.  
  
## Syntax  
  
```  
  
typedef basic  
_  
filebuf<char, char  
_  
traits<char> > filebuf;  
  
```  
  
## Remarks  
 The type is a synonym for template class [basic_filebuf](../vs140/basic_filebuf-class.md), specialized for elements of type `char` with default character traits.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)