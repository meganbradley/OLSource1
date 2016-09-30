---
title: "basic_fstream Class"
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
  - "std::basic_fstream"
  - "basic_fstream"
  - "fstream/std::basic_fstream"
  - "std.basic_fstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_fstream class"
ms.assetid: 8473817e-42a4-430b-82b8-b476c86bcf8a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_fstream Class
Describes an object that controls insertion and extraction of elements and encoded objects using a stream buffer of class [basic_filebuf](../vs140/basic_filebuf-class.md)< <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>>, with elements of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, whose character traits are determined by the class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The basic element of the file buffer.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The traits of the basic element of the file buffer (usually <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>>).  
  
## Remarks  
 The object stores an object of class <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>>.  
  
> [!NOTE]
>  The get pointer and put pointer of an fstream object are **NOT** independent of each other. If the get pointer moves, so does the put pointer.  
  
## Example  
 The following example demonstrates how to create a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object that can be read from and written to.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **Writing to a basic_fstream object...**    
### Constructors  
  
|||  
|-|-|  
|[basic_fstream](#basic_fstream__basic_fstream)|Constructs an object of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[close](#basic_fstream__close)|Closes a file.|  
|[is_open](#basic_fstream__is_open)|Determines if a file is open.|  
|[open](#basic_fstream__open)|Opens a file.|  
|[rdbuf](#basic_fstream__rdbuf)|Returns the address of the stored stream buffer, of type pointer to [basic_filebuf](../vs140/basic_filebuf-class.md)< <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>>.|  
|[swap](#basic_fstream__swap)|Exchanges the content of this object with the content of another <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.|  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
##  \<a name="basic_fstream__basic_fstream">\</a>  basic_fstream::basic_fstream  
 Constructs an object of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The name of the file to open.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The default file opening protection, equivalent to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
### Remarks  
 The first constructor initializes the base class by calling [basic_iostream](../vs140/basic_iostream-class.md)( **sb**), where **sb** is the stored object of class [basic_filebuf](../vs140/basic_filebuf-class.md)\< **Elem**, **Tr**>. It also initializes **sb** by calling <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>\< **Elem**, **Tr**>.  
  
 The second and third constructors initializes the base class by calling <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>( **sb**). It also initializes **sb** by calling <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>\< **Elem**, **Tr**>, and then **sb.**[open](../vs140/basic_filebuf-class.md#basic_filebuf__open)(_                        *Filename*, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>). If the latter function returns a null pointer, the constructor calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**).  
  
 The fourth constructor initializes the object with the contents of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, treated as an rvalue reference.  
  
### Example  
  See [streampos](../vs140/-ios--typedefs.md#streampos) for an example that uses <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_fstream__close">\</a>  basic_fstream::close  
 Closes a file.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The member function calls [rdbuf](#basic_fstream__rdbuf)**->** [close](../vs140/basic_filebuf-class.md#basic_filebuf__close).  
  
### Example  
  See [basic_filebuf::close](../vs140/basic_filebuf-class.md#basic_filebuf__close) for an example of how to use **close**.  
  
##  \<a name="basic_fstream__is_open">\</a>  basic_fstream::is_open  
 Determines if a file is open.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the file is open, **false** otherwise.  
  
### Remarks  
 The member function returns [rdbuf](#basic_fstream__rdbuf)**->**[is_open](../vs140/basic_filebuf-class.md#basic_filebuf__is_open).  
  
### Example  
  See [basic_filebuf::is_open](../vs140/basic_filebuf-class.md#basic_filebuf__is_open) for an example of how to use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_fstream__open">\</a>  basic_fstream::open  
 Opens a file.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The name of the file to open.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The default file opening protection, equivalent to the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
### Remarks  
 The member function calls [rdbuf](#basic_fstream__rdbuf) **->** [open](../vs140/basic_filebuf-class.md#basic_filebuf__open)(_                        *Filename*, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>). If that function returns a null pointer, the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**).  
  
### Example  
  See [basic_filebuf::open](../vs140/basic_filebuf-class.md#basic_filebuf__open) for an example of how to use **open**.  
  
##  \<a name="basic_fstream__operator_eq">\</a>  basic_fstream::operator=  
 Assigns to this object the content from a specified stream object. This is a move assignment that involves an rvalue that does not leave a copy behind.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 An lvalue reference to a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member operator replaces the contents of the object by using the contents of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, treated as an rvalue reference.  
  
##  \<a name="basic_fstream__rdbuf">\</a>  basic_fstream::rdbuf  
 Returns the address of the stored stream buffer, of type pointer to [basic_filebuf](../vs140/basic_filebuf-class.md)\< **Elem**, **Tr**>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The address of the stored stream buffer.  
  
### Example  
  See [basic_filebuf::close](../vs140/basic_filebuf-class.md#basic_filebuf__close) for an example of how to use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_fstream__swap">\</a>  basic_fstream::swap  
 Exchanges the contents of two <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> reference to a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The member function exchanges the contents of this object and the contents of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)