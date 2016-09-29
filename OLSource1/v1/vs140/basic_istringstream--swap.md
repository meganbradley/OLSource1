---
title: "basic_istringstream::swap"
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
  - "basic_istringstream.swap"
  - "basic_istringstream::swap"
  - "std::basic_istringstream::swap"
  - "std.basic_istringstream.swap"
  - "sstream/std::basic_istringstream::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 06bfb2bd-a633-4484-809d-26b6f94b7891
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istringstream::swap
Exchanges the values of two `basic_istringstream` objects.  
  
## Syntax  
  
```  
void swap(  
    basic_istringstream& _Right  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Right`|An `lvalue` reference to a `basic_istringstream` object.|  
  
## Remarks  
 The member function exchanges the values of this object and the values of `_Right`.  
  
## Requirements  
 **Header:** <sstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istringstream Class](../vs140/basic_istringstream-class.md)   
 [<sstream\>](../vs140/-sstream-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)