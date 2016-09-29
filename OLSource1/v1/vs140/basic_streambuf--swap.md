---
title: "basic_streambuf::swap"
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
  - "std::basic_streambuf::swap"
  - "std.basic_streambuf.swap"
  - "basic_streambuf::swap"
  - "streambuf/std::basic_streambuf::swap"
  - "basic_streambuf.swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 4834ab5e-eeb1-421c-a40f-893ed77a1501
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::swap
Exchanges the values in this object for the values in the provided `basic_streambuf` object.  
  
## Syntax  
  
```  
void swap(  
    basic_streambuf& _Right  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Right`|An lvalue reference to the `basic_streambuf` object that is used to exchange values.|  
  
## Remarks  
 The protected member function exchanges with `_Right` all the pointers controlling the `input buffer` and the `output buffer`. It also exchanges `_Right``.`[getloc()](../vs140/basic_streambuf--getloc.md) with the `locale` object.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [<streambuf\>](../vs140/-streambuf-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)