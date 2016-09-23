---
title: "basic_ostream::operator="
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
  - std::basic_ostream::operator=
  - operator=
  - basic_ostream.operator=
  - std.basic_ostream.operator=
  - ostream/std::basic_ostream::operator=
  - basic_ostream::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator=
  - operator= operator
ms.assetid: 2a51b41c-c247-4676-a625-d4492cb9f649
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_ostream::operator=
Assigns values for the provided `basic_ostream` object parameter to this object.  
  
## Syntax  
  
```  
basic_ostream& operator=(  
    basic_ostream&& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 An `rvalue` reference to a `basic_ostream` object.  
  
## Property Value/Return Value  
 Returns a `basic_ostream` object reference.  
  
## Remarks  
 The member operator calls `(``_Right``)`.  
  
## Requirements  
 **Header:** <ostream\>  
  
 **Namespace:** std  
  
## See Also  
 [<ostream\>](../vs140/-ostream-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)