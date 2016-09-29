---
title: "basic_ofstream::open"
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
  - "basic_ofstream.open"
  - "fstream/std::basic_ofstream::open"
  - "Open"
  - "open"
  - "std.basic_ofstream.open"
  - "std::basic_ofstream::open"
  - "basic_ofstream::open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "open method"
ms.assetid: beb5b59b-2357-4088-a894-b56a0e06c1df
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_ofstream::open
Opens a file.  
  
## Syntax  
  
```  
void open(  
    const char *_Filename,  
    ios_base::openmode _Mode = ios_base::out,  
    int _Prot = (int)ios_base::_Openprot  
);  
void open(  
    const char *_Filename,  
    ios_base::openmode _Mode  
);  
void open(  
    const wchar_t *_Filename,  
    ios_base::openmode _Mode = ios_base::out,  
    int _Prot = (int)ios_base::_Openprot  
);  
void open(  
    const wchar_t *_Filename,  
    ios_base::openmode _Mode  
);  
```  
  
#### Parameters  
 `_Filename`  
 The name of the file to open.  
  
 `_Mode`  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 `_Prot`  
 The default file opening protection, equivalent to the `shflag` parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
## Remarks  
 The member function calls [rdbuf](../vs140/basic_ofstream--rdbuf.md) **->** [open](../vs140/basic_filebuf--open.md)(_*Filename*, `_Mode` &#124; `ios_base::out`). If that function returns a null pointer, the function calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**).  
  
## Example  
 See [basic_filebuf::open](../vs140/basic_filebuf--open.md) for an example that uses **open**.  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ofstream Class](../vs140/basic_ofstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)