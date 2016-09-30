---
title: "basic_ofstream Class"
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
  - "std::basic_ofstream"
  - "basic_ofstream"
  - "std.basic_ofstream"
  - "fstream/std::basic_ofstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ofstream class"
ms.assetid: 3bcc9c51-6dfc-4844-8fcc-22ef57c9dff1
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ofstream Class
Describes an object that controls insertion of elements and encoded objects into a stream buffer of class [basic_filebuf](../vs140/basic_filebuf-class.md)< <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>>, with elements of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, whose character traits are determined by the class <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The basic element of the file buffer.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The traits of the basic element of the file buffer (usually <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>>).  
  
## Remarks  
 When the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> specialization of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> writes to the file, if the file is opened in text mode it will write a MBCS sequence. The internal representation will use a buffer of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> characters.  
  
 The object stores an object of class <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>>.  
  
## Example  
 The following example shows how to create a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object and write text to it.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Constructors  
  
|||  
|-|-|  
|[basic_ofstream](#basic_ofstream__basic_ofstream)|Creates an object of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[close](#basic_ofstream__close)|Closes a file.|  
|[is_open](#basic_ofstream__is_open)|Determines if a file is open.|  
|[open](#basic_ofstream__open)|Opens a file.|  
|[rdbuf](#basic_ofstream__rdbuf)|Returns the address of the stored stream buffer.|  
|[swap](#basic_ofstream__swap)|Exchange the contents of this <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> for the contents of the provided <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#basic_ofstream__operator_eq)|Assigns the content of this stream object. This is a move assignment involving an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> that does not leave a copy behind.|  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
##  \<a name="basic_ofstream__basic_ofstream">\</a>  basic_ofstream::basic_ofstream  
 Creates an object of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The name of the file to open.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The default file opening protection, equivalent to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The rvalue reference to the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object being used to initialize this <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The first constructor initializes the base class by calling [basic_ostream](../vs140/basic_ostream-class.md)( **sb**), where **sb** is the stored object of class [basic_filebuf](../vs140/basic_filebuf-class.md)< <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>>. It also initializes **sb** by calling <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>>.  
  
 The second and third constructors initializes the base class by calling <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>( **sb**). It also initializes **sb** by calling <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>> and then **sb**. [open](../vs140/basic_filebuf-class.md#basic_filebuf__open)( <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>). If the latter function returns a null pointer, the constructor calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**).  
  
 The fourth constructor is a copy function. It initializes the object with the contents of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, treated as an rvalue reference.  
  
### Example  
  The following example shows how to create a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object and write text to it.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="basic_ofstream__close">\</a>  basic_ofstream::close  
 Closes a file.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The member function calls [rdbuf](../vs140/basic_ifstream-class.md#basic_ifstream__rdbuf)**->**[close](../vs140/basic_filebuf-class.md#basic_filebuf__close).  
  
### Example  
  See [basic_filebuf::close](../vs140/basic_filebuf-class.md#basic_filebuf__close) for an example that uses **close**.  
  
##  \<a name="basic_ofstream__is_open">\</a>  basic_ofstream::is_open  
 Indicates whether a file is open.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> if the file is open, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 The member function returns [rdbuf](#basic_ofstream__rdbuf) **->** [is_open](../vs140/basic_filebuf-class.md#basic_filebuf__is_open).  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="basic_ofstream__open">\</a>  basic_ofstream::open  
 Opens a file.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The name of the file to open.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The default file opening protection, equivalent to the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
### Remarks  
 The member function calls [rdbuf](#basic_ofstream__rdbuf) **->** [open](../vs140/basic_filebuf-class.md#basic_filebuf__open)(_                        *Filename*, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>). If that function returns a null pointer, the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**).  
  
### Example  
  See [basic_filebuf::open](../vs140/basic_filebuf-class.md#basic_filebuf__open) for an example that uses **open**.  
  
##  \<a name="basic_ofstream__operator_eq">\</a>  basic_ofstream::operator=  
 Assigns the content of this stream object. This is a move assignment involving an <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> that does not leave a copy behind.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 An rvalue reference to a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member operator replaces the contents of the object by using the contents of <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, treated as an rvalue reference.  
  
##  \<a name="basic_ofstream__rdbuf">\</a>  basic_ofstream::rdbuf  
 Returns the address of the stored stream buffer.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns the address of the stored stream buffer.  
  
### Example  
  See [basic_filebuf::close](../vs140/basic_filebuf-class.md#basic_filebuf__close) for an example that uses <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_ofstream__swap">\</a>  basic_ofstream::swap  
 Exchanges the contents of two <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> reference to another <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The member function exchanges the contents of this object for the contents of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
## See Also  
 [basic_ostream Class](../vs140/basic_ostream-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)