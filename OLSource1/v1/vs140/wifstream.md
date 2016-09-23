---
title: "wifstream"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - wifstream
  - std::wifstream
  - std.wifstream
dev_langs: 
  - C++
helpviewer_keywords: 
  - wifstream function
ms.assetid: 46ddeed1-5f0b-4a70-affd-188afd059f4b
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# wifstream
A type `basic_ifstream` specialized on `wchar_t` template parameters.  
  
## Syntax  
  
```  
  
typedef basic  
_  
ifstream<wchar  
_  
t, char  
_  
traits<wchar  
_  
t> > wifstream;  
  
```  
  
## Remarks  
 The type is a synonym for template class [basic_ifstream](../vs140/basic_ifstream-class.md), specialized for elements of type `wchar_t` with default character traits.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ifstream Class](../vs140/basic_ifstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)