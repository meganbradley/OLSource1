---
title: "istrstream Class"
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
  - "istrstream"
  - "std::istrstream"
  - "std.istrstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "istrstream class"
ms.assetid: c2d41c75-bd2c-4437-bd77-5939ce1b97af
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# istrstream Class
Describes an object that controls extraction of elements and encoded objects from a stream buffer of class [strstreambuf](../vs140/strstreambuf-class.md).  
  
## Syntax  
  
```  
class istrstream : public istream  
  
```  
  
## Remarks  
 The object stores an object of class `strstreambuf`.  
  
> [!NOTE]
>  This class is deprecated. Consider using [istringstream](../vs140/-sstream--typedefs.md#istringstream) or [wistringstream](../vs140/-sstream--typedefs.md#wistringstream) instead.  
  
### Constructors  
  
|||  
|-|-|  
|[istrstream](#istrstream__istrstream)|Constructs an object of type `istrstream`.|  
  
### Member Functions  
  
|||  
|-|-|  
|[rdbuf](#istrstream__rdbuf)|Returns a pointer to the stream's associated `strstreambuf` object.|  
|[str](#istrstream__str)|Calls [freeze](../vs140/strstreambuf-class.md#strstreambuf__freeze), and then returns a pointer to the beginning of the controlled sequence.|  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
##  <a name="istrstream__istrstream"></a>  istrstream::istrstream  
 Constructs an object of type `istrstream`.  
  
```  
explicit istrstream(  
    const char * _Ptr  
);  
explicit istrstream(  
    char * _Ptr  
);  
istrstream(  
    const char * _Ptr,   
    streamsize _Count  
);  
istrstream(  
    char * _Ptr,   
    int _Count  
);  
```  
  
### Parameters  
 `_Count`  
 The length of the buffer ( `_Ptr`).  
  
 `_Ptr`  
 The contents with which the buffer is initialized.  
  
### Remarks  
 All the constructors initialize the base class by calling [istream](../vs140/-istream--typedefs.md#istream)( **sb**), where **sb** is the stored object of class [strstreambuf](../vs140/strstreambuf-class.md). The first two constructors also initialize **sb** by calling `strstreambuf`( ( **const**`char` \*) `_Ptr`, 0 ). The remaining two constructors instead call `strstreambuf`( ( **const**`char` *) `_Ptr`, `_Count` ).  
  
##  <a name="istrstream__rdbuf"></a>  istrstream::rdbuf  
 Returns a pointer to the stream's associated strstreambuf object.  
  
```  
strstreambuf *rdbuf( ) const  
  
```  
  
### Return Value  
 A pointer to the stream's associated strstreambuf object.  
  
### Remarks  
 The member function returns the address of the stored stream buffer, of type pointer to [strstreambuf](../vs140/strstreambuf-class.md).  
  
### Example  
  See [strstreambuf::pcount](../vs140/strstreambuf-class.md#strstreambuf__pcount) for a sample that uses `rdbuf`.  
  
##  <a name="istrstream__str"></a>  istrstream::str  
 Calls [freeze](../vs140/strstreambuf-class.md#strstreambuf__freeze), and then returns a pointer to the beginning of the controlled sequence.  
  
```  
char *str( );  
  
```  
  
### Return Value  
 A pointer to the beginning of the controlled sequence.  
  
### Remarks  
 The member function returns [rdbuf](#istrstream__rdbuf) -> [str](../vs140/strstreambuf-class.md#strstreambuf__str).  
  
### Example  
  See [strstream::str](../vs140/strstreambuf-class.md#strstreambuf__str) for a sample that uses **str**.  
  
## See Also  
 [istream](../vs140/-istream--typedefs.md#istream)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)