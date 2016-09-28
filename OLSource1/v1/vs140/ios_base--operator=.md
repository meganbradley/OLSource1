---
title: "ios_base::operator="
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
  - "ios_base::operator="
  - "="
  - "operator="
  - "std.ios_base.operator="
  - "xiosbase/std::ios_base::operator="
  - "ios_base.operator="
  - "std::ios_base::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, streams"
  - "= operator, with specific standard C++ library objects"
  - "operator =, streams"
ms.assetid: fc6883b5-4330-41a1-b28e-aa3597c3b731
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::operator=
The assignment operator for ios_base objects.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& operator=(  
   const ios_base& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 An object of type `ios_base`.  
  
## Return Value  
 The object being assigned to.  
  
## Remarks  
 The operator copies the stored formatting information, making a new copy of any extensible arrays. It then returns **\*this**. Note that the callback stack is not copied.  
  
 This operator is only used by classes derived from `ios_base`.  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)