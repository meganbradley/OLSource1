---
title: "basic_streambuf::operator="
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
  - "basic_streambuf::operator="
  - "operator="
  - "std::basic_streambuf::operator="
  - "std.basic_streambuf.operator="
  - "streambuf/std::basic_streambuf::operator="
  - "basic_streambuf.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
  - "operator= operator"
ms.assetid: 76a9224b-14ed-472c-97af-be36f84536bd
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::operator=
Assigns the values of this object from another `basic_streambuf` object.  
  
## Syntax  
  
```  
basic_streambuf& operator=(  
    const basic_streambuf& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 An lvalue reference to the `basic_streambuf` object that is used to assign values to this object.  
  
## Property Value/Return Value  
 Returns *this.  
  
## Remarks  
 The protected member operator copies from `_Right` the pointers that control the input buffer and the output buffer. It also stores `_Right``.`[getloc()](../vs140/basic_streambuf--getloc.md) in the `locale object`. It returns `*this`.  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [\<streambuf>](../vs140/-streambuf-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)