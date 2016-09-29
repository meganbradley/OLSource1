---
title: "wfilebuf"
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
  - "std::wfilebuf"
  - "std.wfilebuf"
  - "wfilebuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wfilebuf function"
ms.assetid: d3a1c8ad-2408-4c0f-ae10-381bd86dfc7f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wfilebuf
A type `basic_filebuf` specialized on `wchar_t` template parameters.  
  
## Syntax  
  
```  
  
typedef basic  
_  
filebuf<wchar  
_  
t, char  
_  
traits<wchar  
_  
t> > wfilebuf;  
  
```  
  
## Remarks  
 The type is a synonym for template class [basic_filebuf](../vs140/basic_filebuf-class.md), specialized for elements of type `wchar_t` with default character traits.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)