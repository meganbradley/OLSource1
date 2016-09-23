---
title: "strstreambuf::freeze"
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
  - Freeze
  - strstreambuf::freeze
  - std.strstreambuf.freeze
  - strstreambuf.freeze
  - std::strstreambuf::freeze
dev_langs: 
  - C++
helpviewer_keywords: 
  - freeze method
ms.assetid: 8497fe86-f52d-4c01-a26b-aa8ea33c6aea
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# strstreambuf::freeze
Causes a stream buffer to be unavailable through stream buffer operations.  
  
## Syntax  
  
```  
  
      void freeze(  
   bool _Freezeit = true  
);  
```  
  
#### Parameters  
 `_Freezeit`  
 A `bool` indicating whether you want the stream to be frozen.  
  
## Remarks  
 If `_Freezeit` is true, the function alters the stored `strstreambuf` mode to make the controlled sequence frozen. Otherwise, it makes the controlled sequence not frozen.  
  
 [str](../vs140/strstreambuf--str.md) implies `freeze`.  
  
> [!NOTE]
>  A frozen buffer will not be freed during `strstreambuf` destruction. You must unfreeze the buffer before it is freed to avoid a memory leak.  
  
## Example  
  
```  
// strstreambuf_freeze.cpp  
// compile with: /EHsc  
  
#include <iostream>  
#include <strstream>  
  
using namespace std;  
  
void report(strstream &x)  
{  
    if (!x.good())  
        cout << "stream bad" << endl;  
    else  
        cout << "stream good" << endl;  
}  
  
int main()  
{  
    strstream x;  
  
    x << "test1";  
    cout << "before freeze: ";  
    report(x);  
  
    // Calling str freezes stream.  
    cout.write(x.rdbuf()->str(), 5) << endl;  
    cout << "after freeze: ";  
    report(x);  
  
    // Stream is bad now, wrote on frozen stream  
    x << "test1.5";  
    cout << "after write to frozen stream: ";  
    report(x);  
  
    // Unfreeze stream, but it is still bad  
    x.rdbuf()->freeze(false);  
    cout << "after unfreezing stream: ";  
    report(x);  
  
    // Clear stream  
    x.clear();  
    cout << "after clearing stream: ";  
    report(x);  
  
    x << "test3";  
    cout.write(x.rdbuf()->str(), 10) << endl;  
  
    // Clean up.  Failure to unfreeze stream will cause a  
    // memory leak.  
    x.rdbuf()->freeze(false);  
}  
```  
  
 **before freeze: stream good**  
**test1**  
**after freeze: stream good**  
**after write to frozen stream: stream bad**  
**after unfreezing stream: stream bad**  
**after clearing stream: stream good**  
**test1test3**   
## Requirements  
 **Header:** <strstream\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)