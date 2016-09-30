---
title: "ostrstream Class"
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
  - "std.oststream"
  - "oststream"
  - "std::oststream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostrstream class"
ms.assetid: e2e34679-b266-4728-a8e1-8eda5d400e46
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostrstream Class
Describes an object that controls insertion of elements and encoded objects into a stream buffer of class [strstreambuf](../vs140/strstreambuf-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The object stores an object of class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  This class is deprecated. Consider using [ostringstream](../vs140/-sstream--typedefs.md#ostringstream) or [wostringstream](../vs140/-sstream--typedefs.md#wostringstream) instead.  
  
### Constructors  
  
|||  
|-|-|  
|[ostrstream](#ostrstream__ostrstream)|Constructs an object of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[freeze](#ostrstream__freeze)|Causes a stream buffer to be unavailable through stream buffer operations.|  
|[pcount](#ostrstream__pcount)|Returns a count of the number of elements written to the controlled sequence.|  
|[rdbuf](#ostrstream__rdbuf)|Returns a pointer to the stream's associated <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
|[str](#ostrstream__str)|Calls [freeze](../vs140/strstreambuf-class.md#strstreambuf__freeze), and then returns a pointer to the beginning of the controlled sequence.|  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
##  \<a name="ostrstream__freeze">\</a>  ostrstream::freeze  
 Causes a stream buffer to be unavailable through stream buffer operations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> indicating whether you want the stream to be frozen.  
  
### Remarks  
 The member function calls [rdbuf](#ostrstream__rdbuf) -> [freeze](../vs140/strstreambuf-class.md#strstreambuf__freeze)(_                        *Freezeit*).  
  
### Example  
  See [strstream::freeze](../vs140/strstreambuf-class.md#strstreambuf__freeze) for an example that uses **freeze**.  
  
##  \<a name="ostrstream__ostrstream">\</a>  ostrstream::ostrstream  
 Constructs an object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The buffer.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The size of the buffer in bytes.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The input and output mode of the buffer. See [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode) for more information.  
  
### Remarks  
 Both constructors initialize the base class by calling [ostream](../vs140/-ostream--typedefs.md#ostream)( **sb**), where **sb** is the stored object of class [strstreambuf](../vs140/strstreambuf-class.md). The first constructor also initializes **sb** by calling <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The second constructor initializes the base class one of two ways:  
  
-   If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> & **ios_base::app**== 0, then <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must designate the first element of an array of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> elements, and the constructor calls <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>).  
  
-   Otherwise, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> must designate the first element of an array of count elements that contains a C string whose first element is designated by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and the constructor calls <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) ).  
  
##  \<a name="ostrstream__pcount">\</a>  ostrstream::pcount  
 Returns a count of the number of elements written to the controlled sequence.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements written to the controlled sequence.  
  
### Remarks  
 The member function returns [rdbuf](#ostrstream__rdbuf) -> [pcount](../vs140/strstreambuf-class.md#strstreambuf__pcount).  
  
### Example  
  See [strstream::pcount](../vs140/strstreambuf-class.md#strstreambuf__pcount) for a sample that uses <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
##  \<a name="ostrstream__rdbuf">\</a>  ostrstream::rdbuf  
 Returns a pointer to the stream's associated strstreambuf object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the stream's associated strstreambuf object.  
  
### Remarks  
 The member function returns the address of the stored stream buffer of type **pointer** to [strstreambuf](../vs140/strstreambuf-class.md).  
  
### Example  
  See [strstreambuf::pcount](../vs140/strstreambuf-class.md#strstreambuf__pcount) for a sample that uses <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
##  \<a name="ostrstream__str">\</a>  ostrstream::str  
 Calls [freeze](../vs140/strstreambuf-class.md#strstreambuf__freeze), and then returns a pointer to the beginning of the controlled sequence.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the beginning of the controlled sequence.  
  
### Remarks  
 The member function returns [rdbuf](#ostrstream__rdbuf) -> [str](../vs140/strstreambuf-class.md#strstreambuf__str).  
  
### Example  
  See [strstream::str](../vs140/strstreambuf-class.md#strstreambuf__str) for a sample that uses **str**.  
  
## See Also  
 [ostream](../vs140/-ostream--typedefs.md#ostream)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)