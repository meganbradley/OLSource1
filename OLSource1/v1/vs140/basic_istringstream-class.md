---
title: "basic_istringstream Class"
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
  - "std::basic_istringstream"
  - "sstream/std::basic_istringstream"
  - "basic_istringstream"
  - "std.basic_istringstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_istringstream class"
ms.assetid: 1d5bb4b5-793d-4833-98e5-14676c451915
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istringstream Class
Describes an object that controls extraction of elements and encoded objects from a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The type of the basic element of the string.  
  
 *Tr*  
 The character traits specialized on the basic element of the string.  
  
## Remarks  
 The template class describes an object that controls extraction of elements and encoded objects from a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>>, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The object stores an object of class basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>>.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_istringstream](#basic_istringstream__basic_istringstream)|Constructs an object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#basic_istringstream__allocator_type)|The type is a synonym for the template parameter <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[rdbuf](#basic_istringstream__rdbuf)|Returns the address of the stored stream buffer of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to [basic_stringbuf](../vs140/basic_stringbuf-class.md)< <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>>.|  
|[str](#basic_istringstream__str)|Sets or gets the text in a string buffer without changing the write position.|  
|[swap](#basic_istringstream__swap)|Exchanges the values in this <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object for those of the provided object.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#basic_istringstream__operator_eq)|Assigns the values to this <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object from the object parameter.|  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
##  \<a name="basic_istringstream__allocator_type">\</a>  basic_istringstream::allocator_type  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="basic_istringstream__basic_istringstream">\</a>  basic_istringstream::basic_istringstream  
 Constructs an object of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 An rvalue reference of a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The first constructor initializes the base class by calling [basic_istream](../vs140/basic_istream-class.md)( <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>), where <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is the stored object of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)< <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>>. It also initializes <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>>( <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>).  
  
 The second constructor initializes the base class by calling <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. It also initializes <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>>( <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>).  
  
 The third constructor initializes the object with the contents of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, treated as an rvalue reference.  
  
##  \<a name="basic_istringstream__operator_eq">\</a>  basic_istringstream::operator=  
 Assigns the values to this <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object from the object parameter.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 An rvalue reference to a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The member operator replaces the contents of the object with the contents of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, treated as an rvalue reference move assignment.  
  
##  \<a name="basic_istringstream__rdbuf">\</a>  basic_istringstream::rdbuf  
 Returns the address of the stored stream buffer of type **pointer** to [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The address of the stored stream buffer of type **pointer** to basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>>.  
  
### Example  
  See [basic_filebuf::close](../vs140/basic_filebuf-class.md#basic_filebuf__close) for an example that uses <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_istringstream__str">\</a>  basic_istringstream::str  
 Sets or gets the text in a string buffer without changing the write position.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The new string.  
  
### Return Value  
 Returns an object of class [basic_string](../vs140/basic_string-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>>, whose controlled sequence is a copy of the sequence controlled by **\*this**.  
  
### Remarks  
 The first member function returns [rdbuf](#basic_istringstream__rdbuf) -> [str](../vs140/basic_stringbuf-class.md#basic_stringbuf__str). The second member function calls <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> -> **str**( <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>).  
  
### Example  
  See [basic_stringbuf::str](../vs140/basic_stringbuf-class.md#basic_stringbuf__str) for an example that uses **str**.  
  
##  \<a name="basic_istringstream__swap">\</a>  basic_istringstream::swap  
 Exchanges the values of two <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> reference to a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.|  
  
### Remarks  
 The member function exchanges the values of this object and the values of <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)