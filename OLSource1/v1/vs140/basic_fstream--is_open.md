---
title: "basic_fstream::is_open"
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
  - "std.basic_fstream.is_open"
  - "std::basic_fstream::is_open"
  - "is_open"
  - "basic_fstream::is_open"
  - "fstream/std::basic_fstream::is_open"
  - "basic_fstream.is_open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_open method"
ms.assetid: cf2e8486-94ee-4c9b-8f46-414775df40ec
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_fstream::is_open
Determines if a file is open.  
  
## Syntax  
  
```  
bool is_open( ) const;  
```  
  
## Return Value  
 **true** if the file is open, **false** otherwise.  
  
## Remarks  
 The member function returns [rdbuf](../vs140/basic_fstream--rdbuf.md) **->**[is_open](../vs140/basic_filebuf--is_open.md).  
  
## Example  
 See [basic_filebuf::is_open](../vs140/basic_filebuf--is_open.md) for an example of how to use `is_open`.  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_fstream Class](../vs140/basic_fstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)