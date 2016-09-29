---
title: "basic_ofstream::basic_ofstream"
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
  - "basic_ofstream::basic_ofstream"
  - "basic_ofstream"
  - "basic_ofstream.basic_ofstream"
  - "fstream/std::basic_ofstream::basic_ofstream"
  - "std::basic_ofstream::basic_ofstream"
  - "std.basic_ofstream.basic_ofstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ofstream method"
  - "basic_ofstream class, constructor"
ms.assetid: 06b702e7-428c-497e-996a-351f38c5347c
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ofstream::basic_ofstream
Creates an object of type `basic_ofstream`.  
  
## Syntax  
  
```  
basic_ofstream( );  
explicit basic_ofstream(  
    const char *_Filename,  
    ios_base::openmode _Mode = ios_base::out,  
    int _Prot = (int)ios_base::_Openprot  
);  
explicit basic_ofstream(  
    const wchar_t *_Filename,  
    ios_base::openmode _Mode = ios_base::out,  
    int _Prot = (int)ios_base::_Openprot  
);  
basic_ofstream(  
    basic_ofstream&& _Right  
);  
```  
  
#### Parameters  
 `_Filename`  
 The name of the file to open.  
  
 `_Mode`  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 `_Prot`  
 The default file opening protection, equivalent to the `shflag` parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
 `_Right`  
 The rvalue reference to the `basic_ofstream` object being used to initialize this `basic_ofstream` object.  
  
## Remarks  
 The first constructor initializes the base class by calling [basic_ostream](../vs140/basic_ostream-class.md)(**sb**), where **sb** is the stored object of class [basic_filebuf](../vs140/basic_filebuf-class.md)<`Elem`, `Tr`>. It also initializes **sb** by calling `basic_filebuf`<`Elem`, `Tr`>.  
  
 The second and third constructors initializes the base class by calling `basic_ostream`(**sb**). It also initializes **sb** by calling `basic_filebuf`<`Elem`, `Tr`> and then **sb**.[open](../vs140/basic_filebuf--open.md)(`_Filename`, `_Mode` &#124; `ios_base::out`). If the latter function returns a null pointer, the constructor calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**).  
  
 The fourth constructor is a copy function. It initializes the object with the contents of `right`, treated as an rvalue reference.  
  
## Example  
 The following example shows how to create a `basic_ofstream` object and write text to it.  
  
```  
// basic_ofstream_ctor.cpp  
// compile with: /EHsc  
#include <fstream>  
  
using namespace std;  
  
int main(int argc, char **argv)  
{  
    ofstream ofs("C:\\ofstream.txt");  
    if (!ofs.bad())  
    {  
        ofs << "Writing to a basic_ofstream object..." << endl;  
        ofs.close();  
    }  
}  
```  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ofstream Class](../vs140/basic_ofstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)