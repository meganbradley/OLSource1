---
title: "basic_streambuf::sputbackc"
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
  - "std::basic_streambuf::sputbackc"
  - "sputbackc"
  - "basic_streambuf.sputbackc"
  - "std.basic_streambuf.sputbackc"
  - "streambuf/std::basic_streambuf::sputbackc"
  - "basic_streambuf::sputbackc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sputbackc method"
ms.assetid: 04455fa6-893a-4937-9dcd-b759828f03ef
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::sputbackc
Puts a char_type in the stream.  
  
## Syntax  
  
```  
  
      int  
      _  
      type sputbackc(  
   char_type _Ch  
);  
```  
  
#### Parameters  
 `_Ch`  
 The character.  
  
## Return Value  
 Returns the character or failure.  
  
## Remarks  
 If a putback position is available and `_Ch` compares equal to the character stored in that position, the member function decrements the next pointer for the input buffer and returns **traits_type::**[to_int_type](../vs140/char_traits--to_int_type.md)(`_Ch`). Otherwise, it returns [pbackfail](../vs140/basic_streambuf--pbackfail.md)(`_Ch`).  
  
## Example  
  
```  
// basic_streambuf_sputbackc.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
int main( )  
{  
    using namespace std;  
  
    ifstream myfile("basic_streambuf_sputbackc.txt",  
        ios::in);  
  
    int i = myfile.rdbuf()->sbumpc();  
    cout << (char)i << endl;  
    int j = myfile.rdbuf()->sputbackc('z');  
    if (j == 'z')  
    {  
        cout << "it worked" << endl;  
    }  
    i = myfile.rdbuf()->sgetc();  
    cout << (char)i << endl;  
}  
```  
  
## Input: basic_streambuf_sputbackc.txt  
  
```  
testing  
```  
  
### Output  
  
```  
t  
it worked  
z  
```  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)