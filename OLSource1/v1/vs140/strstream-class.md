---
title: "strstream Class"
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
  - "std::strstream"
  - "strstream"
  - "std.strstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strstream class"
ms.assetid: 63f3be31-9e36-42b1-9715-a474a5997e2a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstream Class
Describes an object that controls insertion and extraction of elements and encoded objects using a stream buffer of class [strstreambuf](../vs140/strstreambuf-class.md).  
  
## Syntax  
  
```  
class strstream : public iostream  
  
```  
  
## Remarks  
 The object stores an object of class `strstreambuf`.  
  
> [!NOTE]
>  This class is deprecated. Consider using [stringstream](../vs140/-sstream--typedefs.md#stringstream) or [wstringstream](../vs140/-sstream--typedefs.md#wstringstream) instead.  
  
### Constructors  
  
|||  
|-|-|  
|[strstream](#strstream__strstream)|Constructs an object of type `strstream`.|  
  
### Member Functions  
  
|||  
|-|-|  
|[freeze](#strstream__freeze)|Causes a stream buffer to be unavailable through stream buffer operations.|  
|[pcount](#strstream__pcount)|Returns a count of the number of elements written to the controlled sequence.|  
|[rdbuf](#strstream__rdbuf)|Returns a pointer to the stream's associated `strstreambuf` object.|  
|[str](#strstream__str)|Calls [freeze](../vs140/strstreambuf-class.md#strstreambuf__freeze), and then returns a pointer to the beginning of the controlled sequence.|  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
##  <a name="strstream__freeze"></a>  strstream::freeze  
 Causes a stream buffer to be unavailable through stream buffer operations.  
  
```  
void freeze(    bool  _Freezeit  = true );  
  
```  
  
### Parameters  
 `_Freezeit`  
 A `bool` indicating whether you want the stream to be frozen.  
  
### Remarks  
 The member function calls [rdbuf](#strstream__rdbuf) -> [freeze](../vs140/strstreambuf-class.md#strstreambuf__freeze)(_                        *Freezeit*).  
  
### Example  
  See [strstreambuf::freeze](../vs140/strstreambuf-class.md#strstreambuf__freeze) for an example that uses **freeze**.  
  
##  <a name="strstream__pcount"></a>  strstream::pcount  
 Returns a count of the number of elements written to the controlled sequence.  
  
```  
streamsize pcount( ) const;  
  
```  
  
### Return Value  
 The number of elements written to the controlled sequence.  
  
### Remarks  
 The member function returns [rdbuf](#strstream__rdbuf) -> [pcount](../vs140/strstreambuf-class.md#strstreambuf__pcount).  
  
### Example  
  See [strstreambuf::pcount](../vs140/strstreambuf-class.md#strstreambuf__pcount) for a sample of using pcount.  
  
##  <a name="strstream__rdbuf"></a>  strstream::rdbuf  
 Returns a pointer to the stream's associated strstreambuf object.  
  
```  
strstreambuf *rdbuf( ) const  
  
```  
  
### Return Value  
 A pointer to the stream's associated strstreambuf object.  
  
### Remarks  
 The member function returns the address of the stored stream buffer of type **pointer** to [strstreambuf](../vs140/strstreambuf-class.md).  
  
### Example  
  See [strstreambuf::pcount](../vs140/strstreambuf-class.md#strstreambuf__pcount) for a sample that uses `rdbuf`.  
  
##  <a name="strstream__str"></a>  strstream::str  
 Calls [freeze](../vs140/strstreambuf-class.md#strstreambuf__freeze), and then returns a pointer to the beginning of the controlled sequence.  
  
```  
char *str( );  
  
```  
  
### Return Value  
 A pointer to the beginning of the controlled sequence.  
  
### Remarks  
 The member function returns [rdbuf](#strstream__rdbuf) -> [str](../vs140/strstreambuf-class.md#strstreambuf__str).  
  
### Example  
  See [strstreambuf::str](../vs140/strstreambuf-class.md#strstreambuf__str) for a sample that uses **str**.  
  
##  <a name="strstream__strstream"></a>  strstream::strstream  
 Constructs an object of type `strstream`.  
  
```  
strstream( ); strstream(    char * _Ptr ,     streamsize  _Count ,    ios _ base::openmode  _Mode  = ios _ base::in | ios _ base::out );  
  
```  
  
### Parameters  
 `_Count`  
 The size of the buffer.  
  
 `_Mode`  
 The input and output mode of the buffer. See [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode) for more information.  
  
 `_Ptr`  
 The buffer.  
  
### Remarks  
 Both constructors initialize the base class by calling [streambuf](../vs140/-streambuf--typedefs.md#streambuf)( **sb**), where **sb** is the stored object of class [strstreambuf](../vs140/strstreambuf-class.md). The first constructor also initializes **sb** by calling [strstreambuf](../vs140/strstreambuf-class.md#strstreambuf__strstreambuf). The second constructor initializes the base class one of two ways:  
  
-   If `_Mode` & **ios_base::app**== 0, then `_Ptr` must designate the first element of an array of `_Count` elements, and the constructor calls `strstreambuf`( `_Ptr`, `_Count`, `_Ptr`).  
  
-   Otherwise, `_Ptr` must designate the first element of an array of count elements that contains a C string whose first element is designated by `_Ptr`, and the constructor calls `strstreambuf`( `_Ptr`, `_Count`, `_Ptr` + `strlen`( `_Ptr`) ).  
  
## See Also  
 [iostream](../vs140/-istream--typedefs.md#iostream)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)