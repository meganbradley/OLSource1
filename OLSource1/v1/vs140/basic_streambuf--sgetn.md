---
title: "basic_streambuf::sgetn"
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
  - "streambuf/std::basic_streambuf::sgetn"
  - "basic_streambuf.sgetn"
  - "std.basic_streambuf.sgetn"
  - "basic_streambuf::sgetn"
  - "sgetn"
  - "std::basic_streambuf::sgetn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sgetn method"
ms.assetid: 24ea6dd1-eeae-4d85-85c4-7f632a14a101
caps.latest.revision: 29
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::sgetn
Extracts up to `_Count` characters from the input buffer and stores them in the provided buffer `_Ptr`.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
## Syntax  
  
```  
streamsize sgetn(  
   char_type *_Ptr,  
   streamsize _Count  
);  
```  
  
#### Parameters  
 `_Ptr`  
 The buffer to contain the extracted characters.  
  
 `_Count`  
 The number of elements to read.  
  
## Return Value  
 The number of elements read. See [streamsize](../vs140/streamsize.md) for more information.  
  
## Remarks  
 The member function returns [xsgetn](../vs140/basic_streambuf--xsgetn.md)(`_Ptr`, `_Count`).  
  
## Example  
  
```  
// basic_streambuf_sgetn.cpp  
// compile with: /EHsc /W3  
#include <iostream>  
#include <fstream>  
  
int main()  
{  
    using namespace std;  
  
    ifstream myfile("basic_streambuf_sgetn.txt", ios::in);  
    char a[10];  
  
    // Extract 3 characters from myfile and store them in a.  
    streamsize i = myfile.rdbuf()->sgetn(&a[0], 3);  // C4996  
    a[i] = myfile.widen('\0');  
  
    // Display the size and contents of the buffer passed to sgetn.  
    cout << i << " " << a << endl;  
  
    // Display the contents of the original input buffer.  
    cout << myfile.rdbuf() << endl;  
}  
```  
  
## Input: basic_streambuf_sgetn.txt  
  
```  
testing  
```  
  
### Output  
  
```  
3 tes  
ting  
```  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)