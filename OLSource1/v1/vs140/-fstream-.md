---
title: "&lt;fstream&gt;"
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
  - "std::<fstream>"
  - "<fstream>"
  - "std.<fstream>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fstream header"
ms.assetid: 660de351-0489-41df-b239-40e0cdcab46b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;fstream&gt;
Defines several classes that support iostreams operations on sequences stored in external files.  
  
## Syntax  
  
```  
#include <fstream>  
  
```  
  
### Typedefs  
  
|||  
|-|-|  
|[filebuf](../vs140/-fstream--typedefs.md#filebuf)|A type `basic_filebuf` specialized on `char` template parameters.|  
|[fstream](../vs140/-fstream--typedefs.md#fstream)|A type `basic_fstream` specialized on `char` template parameters.|  
|[ifstream](../vs140/-fstream--typedefs.md#ifstream)|A type `basic_ifstream` specialized on `char` template parameters.|  
|[ofstream](../vs140/-fstream--typedefs.md#ofstream)|A type `basic_ofstream` specialized on `char` template parameters.|  
|[wfstream](../vs140/-fstream--typedefs.md#wfstream)|A type `basic_fstream` specialized on `wchar_t` template parameters.|  
|[wifstream](../vs140/-fstream--typedefs.md#wifstream)|A type `basic_ifstream` specialized on `wchar_t` template parameters.|  
|[wofstream](../vs140/-fstream--typedefs.md#wofstream)|A type `basic_ofstream` specialized on `wchar_t` template parameters.|  
|[wfilebuf](../vs140/-fstream--typedefs.md#wfilebuf)|A type `basic_filebuf` specialized on `wchar_t` template parameters.|  
  
### Classes  
  
|||  
|-|-|  
|[basic_filebuf](../vs140/basic_filebuf-class.md)|The template class describes a stream buffer that controls the transmission of elements of type **Elem**, whose character traits are determined by the class **Tr**, to and from a sequence of elements stored in an external file.|  
|[basic_fstream](../vs140/basic_fstream-class.md)|The template class describes an object that controls insertion and extraction of elements and encoded objects using a stream buffer of class [basic_filebuf](../vs140/basic_filebuf-class.md)<**Elem**, **Tr**>, with elements of type **Elem**, whose character traits are determined by the class **Tr**.|  
|[basic_ifstream](../vs140/basic_ifstream-class.md)|The template class describes an object that controls extraction of elements and encoded objects from a stream buffer of class [basic_filebuf](../vs140/basic_filebuf-class.md)<**Elem**, **Tr**>, with elements of type **Elem**, whose character traits are determined by the class **Tr**.|  
|[basic_ofstream](../vs140/basic_ofstream-class.md)|The template class describes an object that controls insertion of elements and encoded objects into a stream buffer of class [basic_filebuf](../vs140/basic_filebuf-class.md)<**Elem**, **Tr**>, with elements of type **Elem**, whose character traits are determined by the class **Tr**.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)