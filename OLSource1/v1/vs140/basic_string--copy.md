---
title: "basic_string::copy"
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
  - "std::basic_string::copy"
  - "basic_string::copy"
  - "xstring/std::basic_string::copy"
  - "std.basic_string.copy"
  - "basic_string.copy"
  - "copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy method"
ms.assetid: 0099269b-fc6c-44ad-a0cb-4d42d0ffee13
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::copy
Copies at most a specified number of characters from an indexed position in a source string to a target character array.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct. Consider using [basic_string::_Copy_s](../vs140/basic_string--_copy_s.md) instead.  
  
## Syntax  
  
```  
size_type copy(  
    value_type* _Ptr,   
    size_type _Count,  
    size_type _Off = 0  
) const;  
```  
  
#### Parameters  
 `_Ptr`  
 The target character array to which the elements are to be copied.  
  
 _ `Count`  
 The number of characters to be copied, at most, from the source string.  
  
 `_Off`  
 The beginning position in the source string from which copies are to be made.  
  
## Return Value  
 The number of characters actually copied.  
  
## Remarks  
 A null character is not appended to the end of the copy.  
  
## Example  
  
```  
// basic_string_copy.cpp  
// compile with: /EHsc /W3  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   string str1 ( "Hello World" );  
   basic_string <char>::iterator str_Iter;  
   char array1 [ 20 ] = { 0 };  
   char array2 [ 10 ] = { 0 };  
   basic_string <char>:: pointer array1Ptr = array1;  
   basic_string <char>:: value_type *array2Ptr = array2;  
  
   cout << "The original string str1 is: ";  
   for ( str_Iter = str1.begin( ); str_Iter != str1.end( ); str_Iter++ )  
      cout << *str_Iter;  
   cout << endl;  
  
   basic_string <char>:: size_type nArray1;  
   // Note: string::copy is potentially unsafe, consider  
   // using string::_Copy_s instead.  
   nArray1 = str1.copy ( array1Ptr , 12 );  // C4996  
   cout << "The number of copied characters in array1 is: "  
        << nArray1 << endl;  
   cout << "The copied characters array1 is: " << array1 << endl;  
  
   basic_string <char>:: size_type nArray2;  
   // Note: string::copy is potentially unsafe, consider  
   // using string::_Copy_s instead.  
   nArray2 = str1.copy ( array2Ptr , 5 , 6  );  // C4996  
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