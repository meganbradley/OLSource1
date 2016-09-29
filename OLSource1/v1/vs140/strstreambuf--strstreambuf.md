---
title: "strstreambuf::strstreambuf"
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
  - "strstreambuf.strstreambuf"
  - "std::strstreambuf::strstreambuf"
  - "strstreambuf"
  - "strstreambuf::strstreambuf"
  - "std.strstreambuf.strstreambuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strstreambuf class, constructor"
  - "strstreambuf method"
ms.assetid: 6a14fd53-744d-4a4b-b9bd-e6dd33a44619
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstreambuf::strstreambuf
Constructs an object of type `strstreambuf`.  
  
## Syntax  
  
```  
  
      explicit strstreambuf(  
   streamsize _Count = 0  
);  
strstreambuf(  
   void ( *_Allocfunc )( size_t ),  
   void ( *_Freefunc )( void * )  
);  
strstreambuf(  
   char *_Getptr,   
   streamsize _Count,  
   char *_Putptr = 0  
);  
strstreambuf(  
   signed char *_Getptr,   
   streamsize _Count,  
   signed char *_Putptr = 0  
);  
strstreambuf(  
   unsigned char *_Getptr,  
   streamsize _Count,  
   unsigned char *_Putptr = 0  
);  
strstreambuf(  
   const char *_Getptr,   
   streamsize _Count  
);  
strstreambuf(  
   const signed char *_Getptr,   
   streamsize _Count  
);  
strstreambuf(  
   const unsigned char *_Getptr,   
   streamsize _Count  
);  
```  
  
#### Parameters  
 *_Allocfunc*  
 The function used to allocate buffer memory.  
  
 `_Count`  
 Determines the length of the buffer pointed to by `_Getptr`. If `_Getptr` is not an argument (first constructor form), a suggested allocation size for the buffers.  
  
 *_Freefunc*  
 The function used to free buffer memory.  
  
 `_Getptr`  
 A buffer used for input.  
  
 `_Putptr`  
 A buffer used for output.  
  
## Remarks  
 The first constructor stores a null pointer in all the pointers controlling the input buffer, the output buffer, and strstreambuf allocation. It sets the stored strstreambuf mode to make the controlled sequence modifiable and extendable. It also accepts `_Count` as a suggested initial allocation size.  
  
 The second constructor behaves like the first, except that it stores _*Allocfunc* as the pointer to the function to call to allocate storage and \_*Freefunc* as the pointer to the function to call to free that storage.  
  
 The three constructors:  
  
```  
  
      strstreambuf(char *_Getptr, streamsize count,  
    char *putptr = 0);  
strstreambuf(signed char *_Getptr, streamsize count,  
    signed char *putptr = 0);  
strstreambuf(unsigned char *_Getptr, streamsize count,  
    unsigned char *putptr = 0);  
```  
  
 also behave like the first, except that `_Getptr` designates the array object used to hold the controlled sequence. (Hence, it must not be a null pointer.) The number of elements *N* in the array is determined as follows:  
  
-   If (`_Count` > 0), then *N* is **count**.  
  
-   If `(``_Count` == 0), then *N* is `strlen`( (**const** `char` *)`_Getptr` ).  
  
-   If (`_Count` < 0), then *N* is **INT_MAX**.  
  
 If `_Putptr` is a null pointer, the function establishes just an input buffer by executing:  
  
```  
setg(_Getptr, _Getptr, _Getptr + N);  
```  
  
 Otherwise, it establishes both input and output buffers by executing:  
  
```  
setg(_Getptr, _Getptr, _Putptr);  
setp(_Putptr, _Getptr + N);  
```  
  
 In this case, `_Putptr` must be in the interval [`_Getptr`, `_Getptr` + *N*].  
  
 Finally, the three constructors:  
  
```  
  
      strstreambuf(const char *_Getptr, streamsize _Count);  
strstreambuf(const signed char *_Getptr, streamsize _Count);  
strstreambuf(const unsigned char *_Getptr, streamsize _Count);  
```  
  
 all behave the same as:  
  
```  
streambuf( (char *)_Getptr, _Count );  
```  
  
 except that the stored mode makes the controlled sequence neither modifiable nor extendable.  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)