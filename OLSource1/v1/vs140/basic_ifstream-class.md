---
title: "basic_ifstream Class"
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
  - "basic_ifstream"
  - "fstream/std::basic_ifstream"
  - "std::basic_ifstream"
  - "std.basic_ifstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ifstream class"
ms.assetid: 366cd9a7-efc4-4b7f-ba10-c8271e47ffcf
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ifstream Class
Describes an object that controls extraction of elements and encoded objects from a stream buffer of class [basic_filebuf](../vs140/basic_filebuf-class.md)< <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>>, with elements of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, whose character traits are determined by the class <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The basic element of the file buffer.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The traits of the basic element of the file buffer (usually <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>>).  
  
## Remarks  
 The object stores an object of class <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>>.  
  
## Example  
 The following example shows how to read in text from a file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: basic_ifstream_class.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Constructors  
  
|||  
|-|-|  
|[basic_ifstream](#basic_ifstream__basic_ifstream)|Initializes a new instance of a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
  
### Member Functions  
  
|||  
|-|-|  
|[close](#basic_ifstream__close)|Closes a file.|  
|[is_open](#basic_ifstream__is_open)|Determines if a file is open.|  
|[open](#basic_ifstream__open)|Opens a file.|  
|[rdbuf](#basic_ifstream__rdbuf)|Returns the address of the stored stream buffer.|  
|[swap](#basic_ifstream__swap)|Exchanges the content of this <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> for the content of the provided <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#basic_ifstream__operator_eq)|Assigns the content of this stream object. This is a move assignment involving an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> that does not leave a copy behind.|  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
##  \<a name="basic_ifstream__basic_ifstream">\</a>  basic_ifstream::basic_ifstream  
 Constructs an object of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The name of the file to open.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The default file opening protection, equivalent to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
### Remarks  
 The first constructor initializes the base class by calling [basic_istream](../vs140/basic_istream-class.md)( <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>), where <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is the stored object of class [basic_filebuf](../vs140/basic_filebuf-class.md)< <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>>. It also initializes <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>>.  
  
 The second and third constructors initializes the base class by calling <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>). It also initializes <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> by calling [basic_filebuf](../vs140/basic_filebuf-class.md#basic_filebuf__basic_filebuf)< <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>>, then <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. [open](../vs140/basic_filebuf-class.md#basic_filebuf__open)( <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>). If the latter function returns a null pointer, the constructor calls [setstate](b4fdcd8e1-62d2-4611-8a70-1e4f58434007)( <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>).  
  
 The fourth constructor initializes the object with the contents of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, treated as an rvalue reference.  
  
### Example  
  The following example shows how to read in text from a file. To create the file, see the example for [basic_ofstream::basic_ofstream](../vs140/basic_ofstream-class.md#basic_ofstream__basic_ofstream).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="basic_ifstream__close">\</a>  basic_ifstream::close  
 Closes a file.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 The member function calls [rdbuf](#basic_ifstream__rdbuf) **->** [close](../vs140/basic_filebuf-class.md#basic_filebuf__close).  
  
### Example  
  See [basic_filebuf::close](../vs140/basic_filebuf-class.md#basic_filebuf__close) for an example that uses **close**.  
  
##  \<a name="basic_ifstream__is_open">\</a>  basic_ifstream::is_open  
 Determines if a file is open.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the file is open, **false** otherwise.  
  
### Remarks  
 The member function returns [rdbuf](#basic_ifstream__rdbuf) **->** [is_open](../vs140/basic_filebuf-class.md#basic_filebuf__is_open).  
  
### Example  
  See [basic_filebuf::is_open](../vs140/basic_filebuf-class.md#basic_filebuf__is_open) for an example that uses <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_ifstream__open">\</a>  basic_ifstream::open  
 Opens a file.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The name of the file to open.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The default file opening protection, equivalent to the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
### Remarks  
 The member function calls [rdbuf](#basic_ifstream__rdbuf) **->** [open](../vs140/basic_filebuf-class.md#basic_filebuf__open)(_                        *Filename*, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> &#124; **ios_base::in**). If open fails, the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**), which may throw an ios_base::failure exception.  
  
### Example  
  See [basic_filebuf::open](../vs140/basic_filebuf-class.md#basic_filebuf__open) for an example that uses **open**.  
  
##  \<a name="basic_ifstream__operator_eq">\</a>  basic_ifstream::operator=  
 Assigns the content of this stream object. This is a move assignment involving an rvalue that does not leave a copy behind.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 An rvalue reference to a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member operator replaces the contents of the object by using the contents of <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, treated as an rvalue reference. For more information, see [Lvalues and Rvalues](../vs140/lvalues-and-rvalues--visual-c---.md).  
  
##  \<a name="basic_ifstream__rdbuf">\</a>  basic_ifstream::rdbuf  
 Returns the address of the stored stream buffer.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a [basic_filebuf](../vs140/basic_filebuf-class.md) object representing the stored stream buffer.  
  
### Example  
  See [basic_filebuf::close](../vs140/basic_filebuf-class.md#basic_filebuf__close) for an example that uses <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_ifstream__swap">\</a>  basic_ifstream::swap  
 Exchanges the contents of two <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A reference to another stream buffer.  
  
### Remarks  
 The member function exchanges the contents of this object for the contents of <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)