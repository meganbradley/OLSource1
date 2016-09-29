---
title: "basic_string::_Copy_s"
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
  - "std::basic_string::_Copy_s"
  - "basic_string::_Copy_s"
  - "xstring/std::basic_string::_Copy_s"
  - "basic_string._Copy_s"
  - "std.basic_string._Copy_s"
  - "_Copy_s"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_Copy_s method"
ms.assetid: 79eaafb6-bf5b-4e5b-9956-944603166091
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::_Copy_s
Copies at most a specified number of characters from an indexed position in a source string to a target character array.  
  
## Syntax  
  
```  
size_type _Copy_s(  
    value_type *_Dest,  
    size_type _Dest_size,  
    size_type _Count,  
    size_type _Off = 0  
) const;  
```  
  
#### Parameters  
 `_Dest`  
 The target character array to which the elements are to be copied.  
  
 `_Dest_size`  
 The size of `_Dest`.  
  
 _`Count`  
 The number of characters to be copied, at most, from the source string.  
  
 `_Off`  
 The beginning position in the source string from which copies are to be made.  
  
## Return Value  
 The number of characters actually copied.  
  
## Remarks  
 A null character is not appended to the end of the copy.  
  
## Example  
  
```  
// basic_string__Copy_s.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
    using namespace std;  
    string str1("Hello World");  
    basic_string<char>::iterator str_Iter;  
    const int array1_size = 20;  
    char array1[array1_size] = { 0 };  
    const int array2_size = 10;  
    char array2[array2_size] = { 0 };  
    basic_string<char>:: pointer array1Ptr = array1;  
    basic_string<char>:: value_type *array2Ptr = array2;  
  
    cout << "The original string str1 is: ";  
    for (str_Iter = str1.begin(); str_Iter != str1.end(); str_Iter++)  
        cout << *str_Iter;  
    cout << endl;  
  
    basic_string<char>::size_type nArray1;  
    nArray1 = str1._Copy_s(array1Ptr, array1_size, 12);  
    cout << "The number of copied characters in array1 is: "  
         << nArray1 << endl;  
    cout << "The copied characters array1 is: " << array1 << endl;  
  
    basic_string<char>:: size_type nArray2;  
    nArray2 = str1._Copy_s(array2Ptr, array2_size, 5, 6);  
    cout << "The number of copied characters in array2 is: "  
         << nArray2 << endl;  
    cout << "The copied characters array2 is: " << array2Ptr << endl;  
}  
```  
  
 **The original string str1 is: Hello World**  
**The number of copied characters in array1 is: 11**  
**The copied characters array1 is: Hello World**  
**The number of copied characters in array2 is: 5**  
**The copied characters array2 is: World**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [Safe Standard C++ Library](../vs140/safe-libraries--c---standard-library.md)