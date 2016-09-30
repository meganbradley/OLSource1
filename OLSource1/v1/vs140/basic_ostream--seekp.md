---
title: "basic_ostream::seekp"
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
  - "seekp"
  - "basic_ostream.seekp"
  - "basic_ostream::seekp"
  - "std.basic_ostream.seekp"
  - "ostream/std::basic_ostream::seekp"
  - "std::basic_ostream::seekp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekp method"
ms.assetid: 033c5238-a5cd-4cec-bbdb-7b10b1297fd0
caps.latest.revision: 26
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostream::seekp
Reset position in output stream.  
  
## Syntax  
  
```  
basic_ostream<_Elem, _Tr>& seekp(  
    pos_type _Pos  
);  
basic_ostream<_Elem, _Tr>& seekp(  
    off_type _Off,  
    ios_base::seekdir _Way  
);  
```  
  
#### Parameters  
 `_Pos`  
 The position in the stream.  
  
 `_Off`  
 The offset relative to `_Way`.  
  
 `_Way`  
 One of the [ios_base::seekdir](../vs140/ios_base--seekdir.md) enumerations.  
  
## Return Value  
 A reference to the basic_ostream object.  
  
## Remarks  
 If [fail](../vs140/basic_ios--fail.md) is **false**, the first member function calls **newpos =** [rdbuf](../vs140/basic_ios--rdbuf.md)**->** [pubseekpos](../vs140/basic_streambuf--pubseekpos.md)(_*Pos*), for some `pos_type` temporary object **newpos**. If **fail** is false, the second function calls **newpos = rdbuf->** [pubseekoff](../vs140/basic_streambuf--pubseekoff.md)(*_Off, _Way*). In either case, if (`off_type`)**newpos ==** (`off_type`)(-1) (the positioning operation fails), then the function calls **istr.**[setstate](../vs140/basic_ios--setstate.md)(**failbit**). Both functions return **\*this**.  
  
## Example  
  
```  
// basic_ostream_seekp.cpp  
// compile with: /EHsc  
#include <fstream>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    ofstream x("basic_ostream_seekp.txt");  
    streamoff i = x.tellp();  
    cout << i << endl;  
    x << "testing";  
    i = x.tellp();  
    cout << i << endl;  
    x.seekp(2);   // Put char in third char position in file  
    x << " ";  
  
    x.seekp(2, ios::end);   // Put char two after end of file  
    x << "z";  
}  
```  
  
 **0**  
**7**   
## Requirements  
 **Header:** \<ostream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostream Class](../vs140/basic_ostream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)