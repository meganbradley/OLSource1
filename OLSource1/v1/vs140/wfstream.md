---
title: "wfstream"
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
  - "std.wfstream"
  - "std::wfstream"
  - "wfstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wfstream function"
ms.assetid: c2a1cdf6-7ed3-45f1-a16b-d86a8c8b771e
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wfstream
A type `basic_fstream` specialized on `wchar_t` template parameters.  
  
## Syntax  
  
```  
  
typedef basic  
_  
fstream<wchar  
_  
t, char  
_  
traits<wchar  
_  
t> > wfstream;  
  
```  
  
## Remarks  
 The type is a synonym for template class [basic_fstream](../vs140/basic_fstream-class.md), specialized for elements of type `wchar_t` with default character traits.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_fstream Class](../vs140/basic_fstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)