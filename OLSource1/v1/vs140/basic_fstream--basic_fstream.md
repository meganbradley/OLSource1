---
title: "basic_fstream::basic_fstream"
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
  - "basic_fstream.basic_fstream"
  - "std::basic_fstream::basic_fstream"
  - "basic_fstream"
  - "fstream/std::basic_fstream::basic_fstream"
  - "std.basic_fstream.basic_fstream"
  - "basic_fstream::basic_fstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_fstream method"
  - "basic_fstream class, constructor"
ms.assetid: 9abb928d-ebfa-42ec-a35a-4c3952586548
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_fstream::basic_fstream
Constructs an object of type `basic_fstream`.  
  
## Syntax  
  
```  
basic_fstream( );  
explicit basic_fstream(  
    const char *_Filename,  
    ios_base::openmode _Mode = ios_base::in | ios_base::out,  
    int _Prot = (int)ios_base::_Openprot  
);  
explicit basic_fstream(  
    const wchar_t *_Filename,  
    ios_base::openmode _Mode = ios_base::in | ios_base::out,  
    int _Prot = (int)ios_base::_Openprot  
);  
basic_fstream(basic_fstream&& right);  
```  
  
#### Parameters  
 `_Filename`  
 The name of the file to open.  
  
 `_Mode`  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 `_Prot`  
 The default file opening protection, equivalent to the `shflag` parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
## Remarks  
 The first constructor initializes the base class by calling [basic_iostream](../vs140/basic_iostream-class.md)(**sb**), where **sb** is the stored object of class [basic_filebuf](../vs140/basic_filebuf-class.md)<**Elem**, **Tr**>. It also initializes **sb** by calling `basic_filebuf`<**Elem**, **Tr**>.  
  
 The second and third constructors initializes the base class by calling `basic_iostream`(**sb**). It also initializes **sb** by calling `basic_filebuf`<**Elem**, **Tr**>, and then **sb.**[open](../vs140/basic_filebuf--open.md)(_*Filename*, `_Mode`). If the latter function returns a null pointer, the constructor calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**).  
  
 The fourth constructor initializes the object with the contents of `right`, treated as an rvalue reference.  
  
## Example  
 See [streampos](../vs140/streampos.md) for an example that uses `basic_fstream`.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_fstream Class](../vs140/basic_fstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)