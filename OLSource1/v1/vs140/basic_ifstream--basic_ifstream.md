---
title: "basic_ifstream::basic_ifstream"
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
  - "fstream/std::basic_ifstream::basic_ifstream"
  - "basic_ifstream"
  - "std.basic_ifstream.basic_ifstream"
  - "basic_ifstream.basic_ifstream"
  - "basic_ifstream::basic_ifstream"
  - "std::basic_ifstream::basic_ifstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ifstream class, constructor"
  - "basic_ifstream method"
ms.assetid: f2915c41-838e-4a72-a94b-dec9cd8aa9e2
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_ifstream::basic_ifstream
Constructs an object of type `basic_ifstream`.  
  
## Syntax  
  
```  
basic_ifstream( );  
explicit basic_ifstream(  
    const char *_Filename,  
    ios_base::openmode _Mode = ios_base::in,  
    int _Prot = (int)ios_base::_Openprot  
);  
explicit basic_ifstream(  
    const wchar_t *_Filename,  
    ios_base::openmode _Mode = ios_base::in,  
    int _Prot = (int)ios_base::_Openprot  
);  
basic_ifstream(basic_ifstream&& right);  
```  
  
#### Parameters  
 `_Filename`  
 The name of the file to open.  
  
 `_Mode`  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 `_Prot`  
 The default file opening protection, equivalent to the `shflag` parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
## Remarks  
 The first constructor initializes the base class by calling [basic_istream](../vs140/basic_istream-class.md)(`sb`), where `sb` is the stored object of class [basic_filebuf](../vs140/basic_filebuf-class.md)<`Elem`, `Tr`>. It also initializes `sb` by calling `basic_filebuf`<`Elem`, `Tr`>.  
  
 The second and third constructors initializes the base class by calling `basic_istream`(`sb`). It also initializes `sb` by calling [basic_filebuf](../vs140/basic_filebuf--basic_filebuf.md)<`Elem`, `Tr`>, then `sb`.[open](../vs140/basic_filebuf--open.md)(`_Filename`, `_Mode` &#124; `ios_base::in`). If the latter function returns a null pointer, the constructor calls [setstate](../vs140/basic_ios--setstate.md)(`failbit`).  
  
 The fourth constructor initializes the object with the contents of `right`, treated as an rvalue reference.  
  
## Example  
 The following example shows how to read in text from a file. To create the file, see the example for [basic_ofstream::basic_ofstream](../vs140/basic_ofstream--basic_ofstream.md).  
  
```  
// basic_ifstream_ctor.cpp  
// compile with: /EHsc  
  
#include <fstream>  
#include <iostream>  
  
using namespace std;  
  
int main(int argc, char **argv)  
{  
    ifstream ifs("basic_ifstream_ctor.txt");  
    if (!ifs.bad())  
    {  
        // Dump the contents of the file to cout.  
        cout << ifs.rdbuf();  
        ifs.close();  
    }  
}  
```  
  
## Input: basic_ifstream_ctor.txt  
  
```  
This is the contents of basic_ifstream_ctor.txt.  
```  
  
## Output  
  
```  
This is the contents of basic_ifstream_ctor.txt.  
```  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ifstream Class](../vs140/basic_ifstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)