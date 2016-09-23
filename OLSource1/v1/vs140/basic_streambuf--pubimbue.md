---
title: "basic_streambuf::pubimbue"
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
  - std::basic_streambuf::pubimbue
  - pubimbue
  - streambuf/std::basic_streambuf::pubimbue
  - basic_streambuf.pubimbue
  - basic_streambuf::pubimbue
  - std.basic_streambuf.pubimbue
dev_langs: 
  - C++
helpviewer_keywords: 
  - pubimbue method
ms.assetid: e63d6086-2891-4104-b14d-5b38fb8cf374
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_streambuf::pubimbue
Sets the basic_streambuf object's locale.  
  
## Syntax  
  
```  
  
      locale pubimbue(  
   const locale& _Loc  
);  
```  
  
#### Parameters  
 `_Loc`  
 A reference to a locale.  
  
## Return Value  
 The previous value stored in the locale object.  
  
## Remarks  
 The member function stores _*Loc* in the locale object and calls [imbue](../vs140/basic_streambuf--imbue.md).  
  
## Example  
 See [basic_ios::imbue](../vs140/basic_ios--imbue.md) for an example that uses `pubimbue`.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)