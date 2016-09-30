---
title: "basic_filebuf Class"
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
  - "std.basic_filebuf"
  - "fstream/std::basic_filebuf"
  - "std::basic_filebuf"
  - "basic_filebuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_filebuf class"
ms.assetid: 3196ba5c-bf38-41bd-9a95-70323ddfca1a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_filebuf Class
Describes a stream buffer that controls the transmission of elements of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, whose character traits are determined by the class <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, to and from a sequence of elements stored in an external file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The basic element of the file buffer.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The traits of the basic element of the file buffer (usually <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>>).  
  
## Remarks  
 The template class describes a stream buffer that controls the transmission of elements of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, whose character traits are determined by the class <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, to and from a sequence of elements stored in an external file.  
  
> [!NOTE]
>  Objects of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> are created with an internal buffer of type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> regardless of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> specified by the type parameter <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. This means that a Unicode string (containing <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> characters) will be converted to an ANSI string (containing <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> characters) before it is written to the internal buffer. To store Unicode strings in the buffer, create a new buffer of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and set it using the [basic_streambuf::pubsetbuf](../vs140/basic_streambuf-class.md#basic_streambuf__pubsetbuf)<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method. To see an example that demonstrates this behavior, see below.  
  
 An object of class <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>> stores a file pointer, which designates the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object that controls the stream associated with an open file. It also stores pointers to two file conversion facets for use by the protected member functions [overflow](#basic_filebuf__overflow) and [underflow](#basic_filebuf__underflow). For more information, see [basic_filebuf::open](#basic_filebuf__open).  
  
## Example  
 The following example demonstrates how to force an object of type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to store Unicode characters in its internal buffer by calling the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **Hex Dump of wcHello.txt - note that output is ANSI chars:**  
**48 65 6c 6c 6f 20 57 6f 72 6c 64 00 00 00 00 00   Hello World.....**  
**Hex Dump of wwHello.txt - note that output is wchar_t chars:**  
**48 00 65 00 6c 00 6c 00 6f 00 20 00 57 00 6f 00   H.e.l.l.o. .W.o.**  
**72 00 6c 00 64 00 00 00 00 00 00 00 00 00 00 00   r.l.d...........**    
### Constructors  
  
|||  
|-|-|  
|[basic_filebuf](#basic_filebuf__basic_filebuf)|Constructs an object of type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#basic_filebuf__char_type)|Associates a type name with the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> template parameter.|  
|[int_type](#basic_filebuf__int_type)|Makes this type within <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>'s scope equivalent to the type of the same name in the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> scope.|  
|[off_type](#basic_filebuf__off_type)|Makes this type within <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>'s scope equivalent to the type of the same name in the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> scope.|  
|[pos_type](#basic_filebuf__pos_type)|Makes this type within <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>'s scope equivalent to the type of the same name in the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> scope.|  
|[traits_type](#basic_filebuf__traits_type)|Associates a type name with the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> template parameter.|  
  
### Member Functions  
  
|||  
|-|-|  
|[close](#basic_filebuf__close)|Closes a file.|  
|[is_open](#basic_filebuf__is_open)|Indicates whether a file is open.|  
|[open](#basic_filebuf__open)|Opens a file.|  
|[overflow](#basic_filebuf__overflow)|A protected virtual function that can be called when a new character is inserted into a full buffer.|  
|[pbackfail](#basic_filebuf__pbackfail)|The protected virtual member function tries to put back an element into the input stream, then make it the current element (pointed to by the next pointer).|  
|[seekoff](#basic_filebuf__seekoff)|The protected virtual member function tries to alter the current positions for the controlled streams.|  
|[seekpos](#basic_filebuf__seekpos)|The protected virtual member function tries to alter the current positions for the controlled streams.|  
|[setbuf](#basic_filebuf__setbuf)|The protected virtual member function performs an operation particular to each derived stream buffer.|  
|[Swap](#basic_filebuf__swap)|Exchanges the content of this <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> for the content of the provided <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> parameter.|  
|[sync](#basic_filebuf__sync)|Protected, virtual function tries to synchronize the controlled streams with any associated external streams.|  
|[uflow](../vs140/basic_streambuf-class.md#basic_streambuf__uflow)|Protected, virtual function to extract the current element from the input stream.|  
|[underflow](#basic_filebuf__underflow)|Protected, virtual function to extract the current element from the input stream.|  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
##  \<a name="basic_filebuf__basic_filebuf">\</a>  basic_filebuf::basic_filebuf  
 Constructs an object of type <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The first constructor stores a null pointer in all the pointers controlling the input buffer and the output buffer. It also stores a null pointer in the file pointer.  
  
 The second constructor initializes the object with the contents of <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, treated as an rvalue reference.  
  
##  \<a name="basic_filebuf__char_type">\</a>  basic_filebuf::char_type  
 Associates a type name with the **Elem** template parameter.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="basic_filebuf__close">\</a>  basic_filebuf::close  
 Closes a file.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The member function returns a null pointer if the file pointer is a null pointer.  
  
### Remarks  
 **close** calls <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>( **fp**). If that function returns a nonzero value, the function returns a null pointer. Otherwise, it returns **this** to indicate that the file was successfully closed.  
  
 For a wide stream, if any insertions have occurred since the stream was opened, or since the last call to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, the function calls [overflow](#basic_filebuf__overflow). It also inserts any sequence needed to restore the initial conversion state, by using the file conversion facet **fac** to call **fac.unshift** as needed. Each element **byte** of type <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> thus produced is written to the associated stream designated by the file pointer **fp** as if by successive calls of the form <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>( **byte**, **fp**). If the call to **fac.unshift** or any write fails, the function does not succeed.  
  
### Example  
  The following sample assumes two files in the current directory: basic_filebuf_close.txt (contents is "testing") and iotest.txt (contents is "ssss").  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **t**  
**s**  
**0**  
**1**    
##  \<a name="basic_filebuf__int_type">\</a>  basic_filebuf::int_type  
 Makes this type within basic_filebuf's scope equivalent to the type of the same name in the **Tr** scope.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="basic_filebuf__is_open">\</a>  basic_filebuf::is_open  
 Indicates whether a file is open.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the file pointer is not a null pointer.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **false**  
**true**    
##  \<a name="basic_filebuf__off_type">\</a>  basic_filebuf::off_type  
 Makes this type within basic_filebuf's scope equivalent to the type of the same name in the **Tr** scope.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="basic_filebuf__open">\</a>  basic_filebuf::open  
 Opens a file.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The name of the file to open.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The default file opening protection, equivalent to the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
### Return Value  
 If the file pointer is a null pointer, the function returns a null pointer. Otherwise, it returns **this**.  
  
### Remarks  
 The member function opens the file with filename                         *filename*, by calling [fopen](../vs140/fopen--_wfopen.md)(                        *filename*, **strmode**). **strmode** is determined from **mode &**~( [ate](../vs140/ios_base-class.md#ios_base__openmode) & &#124; [binary](../vs140/ios_base-class.md#ios_base__openmode)):  
  
-   **ios_base::in** becomes **"r"** (open existing file for reading).  
  
-   [ios_base::out](../vs140/ios_base-class.md#ios_base__fmtflags) or **ios_base::out &#124; ios_base::trunc** becomes **"w"** (truncate existing file or create for writing).  
  
-   **ios_base::out &#124; app** becomes **"a"** (open existing file for appending all writes).  
  
-   **ios_base::in &#124; ios_base::out** becomes **"r+"** (open existing file for reading and writing).  
  
-   **ios_base::in &#124; ios_base::out &#124; ios_base::trunc** becomes **"w+"** (truncate existing file or create for reading and writing).  
  
-   **ios_base::in &#124; ios_base::out &#124; ios_base::app** becomes **"a+"** (open existing file for reading and for appending all writes).  
  
 If **mode & ios_base::binary** is nonzero, the function appends **b** to **strmode** to open a binary stream instead of a text stream. It then stores the value returned by <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> in the file pointer **fp**. If **mode & ios_base::ate** is nonzero and the file pointer is not a null pointer, the function calls <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>( **fp**, 0, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>) to position the stream at end of file. If that positioning operation fails, the function calls [close](#basic_filebuf__close)( **fp**) and stores a null pointer in the file pointer.  
  
 If the file pointer is not a null pointer, the function determines the file conversion facet: <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>< **Elem**, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, **traits_type::**[state_type](../vs140/char_traits-struct.md#char_traits__state_type)> >( [getloc](../vs140/basic_streambuf-class.md#basic_streambuf__getloc)), for use by [underflow](#basic_filebuf__underflow) and [overflow](#basic_filebuf__overflow).  
  
 If the file pointer is a null pointer, the function returns a null pointer. Otherwise, it returns **this**.  
  
### Example  
  See [basic_filebuf::close](#basic_filebuf__close) for an example that uses **open**.  
  
##  \<a name="basic_filebuf__operator_eq">\</a>  basic_filebuf::operator=  
 Assign the content of this stream buffer object. This is a move assignment involving an rvalue that does not leave a copy behind.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 An rvalue reference to a [basic_filebuf](../vs140/basic_filebuf-class.md) object.  
  
### Return Value  
 Returns *this.  
  
### Remarks  
 The member operator replaces the contents of the object by using the contents of <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, treated as an rvalue reference. For more information, see [Rvalue Reference Declarator: &&](../vs140/rvalue-reference-declarator----.md).  
  
##  \<a name="basic_filebuf__overflow">\</a>  basic_filebuf::overflow  
 Called when a new character is inserted into a full buffer.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The character to insert into the buffer or **traits_type::eof**.  
  
### Return Value  
 If the function cannot succeed, it returns **traits_type::eof**. Otherwise, it returns **traits_type::**[not_eof](../vs140/char_traits-struct.md#char_traits__not_eof)(_                        *Meta*).  
  
### Remarks  
 If _                        *Meta***!= traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof), the protected virtual member function endeavors to insert the element **ch = traits_type::**[to_char_type](../vs140/char_traits-struct.md#char_traits__to_char_type)(\_                        *Meta*) into the output buffer. It can do so in various ways:  
  
-   If a write position is available, it can store the element into the write position and increment the next pointer for the output buffer.  
  
-   It can make a write position available by allocating new or additional storage for the output buffer.  
  
-   It can convert any pending output in the output buffer, followed by **ch**, by using the file conversion facet **fac** to call **fac.out** as needed. Each element <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> of type                                 *char* thus produced is written to the associated stream designated by the file pointer **fp** as if by successive calls of the form <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>( **ch**, **fp**). If any conversion or write fails, the function does not succeed.  
  
##  \<a name="basic_filebuf__pbackfail">\</a>  basic_filebuf::pbackfail  
 Tries to put back an element into the input stream, then make it the current element (pointed to by the next pointer).  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or **traits_type::eof**.  
  
### Return Value  
 If the function cannot succeed, it returns **traits_type::eof**. Otherwise, it returns **traits_type::**[not_eof](../vs140/char_traits-struct.md#char_traits__not_eof)(_                        *Meta*).  
  
### Remarks  
 The protected virtual member function puts back an element into the input buffer and then makes it the current element (pointed to by the next pointer). If _                        *Meta* **== traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof), the element to push back is effectively the one already in the stream before the current element. Otherwise, that element is replaced by **ch = traits_type::**[to_char_type](../vs140/char_traits-struct.md#char_traits__to_char_type)(\_                        *Meta*). The function can put back an element in various ways:  
  
-   If a putback position is available, and the element stored there compares equal to **ch**, it can decrement the next pointer for the input buffer.  
  
-   If the function can make a <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> position available, it can do so, set the next pointer to point at that position, and store **ch** in that position.  
  
-   If the function can push back an element onto the input stream, it can do so, such as by calling <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> for an element of type <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>*.*  
  
##  \<a name="basic_filebuf__pos_type">\</a>  basic_filebuf::pos_type  
 Makes this type within basic_filebuf's scope equivalent to the type of the same name in the **Tr** scope.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="basic_filebuf__seekoff">\</a>  basic_filebuf::seekoff  
 Tries to alter the current positions for the controlled streams.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The position to seek for relative to <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The starting point for offset operations. See [seekdir](../vs140/ios_base-class.md#ios_base__seekdir) for possible values.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
### Return Value  
 Returns the new position or an invalid stream position.  
  
### Remarks  
 The protected virtual member function endeavors to alter the current positions for the controlled streams. For an object of class [basic_filebuf](../vs140/basic_filebuf-class.md)< <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>>, a stream position can be represented by an object of type <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, which stores an offset and any state information needed to parse a wide stream. Offset zero designates the first element of the stream. (An object of type [pos_type](../vs140/basic_streambuf-class.md#basic_streambuf__pos_type) stores at least an <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object.)  
  
 For a file opened for both reading and writing, both the input and output streams are positioned in tandem. To switch between inserting and extracting, you must call either [pubseekoff](../vs140/basic_streambuf-class.md#basic_streambuf__pubseekoff) or [pubseekpos](../vs140/basic_streambuf-class.md#basic_streambuf__pubseekpos). Calls to <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> (and hence to <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>) have various limitations for [text streams](../vs140/text-and-binary-streams.md), [binary streams](../vs140/text-and-binary-streams.md), and [wide streams](../vs140/byte-and-wide-streams.md).  
  
 If the file pointer **fp** is a null pointer, the function fails. Otherwise, it endeavors to alter the stream position by calling <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>( **fp**, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>). If that function succeeds and the resulting position **fposn** can be determined by calling <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>( **fp**, **&fposn**), the function succeeds. If the function succeeds, it returns a value of type **pos_type** containing **fposn**. Otherwise, it returns an invalid stream position.  
  
##  \<a name="basic_filebuf__seekpos">\</a>  basic_filebuf::seekpos  
 Tries to alter the current positions for the controlled streams.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The position to seek for.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
### Return Value  
 If the file pointer **fp** is a null pointer, the function fails. Otherwise, it endeavors to alter the stream position by calling <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>( **fp**, **&fposn**), where **fposn** is the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object stored in <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>. If that function succeeds, the function returns <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>. Otherwise, it returns an invalid stream position. To determine if the stream position is invalid, compare the return value with <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
### Remarks  
 The protected virtual member function endeavors to alter the current positions for the controlled streams. For an object of class [basic_filebuf](../vs140/basic_filebuf-class.md)\< **Elem**, **Tr**>, a stream position can be represented by an object of type <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, which stores an offset and any state information needed to parse a wide stream. Offset zero designates the first element of the stream. (An object of type <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> stores at least an <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object.)  
  
 For a file opened for both reading and writing, both the input and output streams are positioned in tandem. To switch between inserting and extracting, you must call either [pubseekoff](../vs140/basic_streambuf-class.md#basic_streambuf__pubseekoff) or [pubseekpos](../vs140/basic_streambuf-class.md#basic_streambuf__pubseekpos). Calls to <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> (and hence to <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>) have various limitations for text streams, binary streams, and wide streams.  
  
 For a wide stream, if any insertions have occurred since the stream was opened, or since the last call to <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, the function calls [overflow](#basic_filebuf__overflow). It also inserts any sequence needed to restore the initial conversion state, by using the file conversion facet **fac** to call **fac**<CodeContentPlaceHolder>107\</CodeContentPlaceHolder> as needed. Each element **byte** of type <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> thus produced is written to the associated stream designated by the file pointer **fp** as if by successive calls of the form <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>( **byte**, **fp**). If the call to **fac.unshift** or any write fails, the function does not succeed.  
  
##  \<a name="basic_filebuf__setbuf">\</a>  basic_filebuf::setbuf  
 Performs an operation particular to each derived stream buffer.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Pointer to a buffer.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Size of the buffer.  
  
### Return Value  
 The protected member function returns zero if the file pointer <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> is a null pointer.  
  
### Remarks  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>( **fp**, ( <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> \*) <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> \* <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> ( **Elem**) ) to offer the array of <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> elements beginning at _                        *Buffer* as a buffer for the stream. If that function returns a nonzero value, the function returns a null pointer. Otherwise, it returns **this** to signal success.  
  
##  \<a name="basic_filebuf__swap">\</a>  basic_filebuf::swap  
 Exchanges the contents of this <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> for the contents of the provided <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> reference to another <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_filebuf__sync">\</a>  basic_filebuf::sync  
 Tries to synchronize the controlled streams with any associated external streams.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Returns zero if the file pointer **fp** is a null pointer. Otherwise, it returns zero only if calls to both [overflow](#basic_filebuf__overflow) and <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>( **fp**) succeed in flushing any pending output to the stream.  
  
##  \<a name="basic_filebuf__traits_type">\</a>  basic_filebuf::traits_type  
 Associates a type name with the **Tr** template parameter.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="basic_filebuf__underflow">\</a>  basic_filebuf::underflow  
 Extracts the current element from the input stream.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 If the function cannot succeed, it returns **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof). Otherwise, it returns **ch**, converted as described in the Remarks section.  
  
### Remarks  
 The protected virtual member function endeavors to extract the current element **ch** from the input stream, and return the element as **traits_type::**[to_int_type](../vs140/char_traits-struct.md#char_traits__to_int_type)( **ch**). It can do so in various ways:  
  
-   If a read position is available, it takes **ch** as the element stored in the read position and advances the next pointer for the input buffer.  
  
-   It can read one or more elements of type <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>*,* as if by successive calls of the form <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>( **fp**), and convert them to an element **ch** of type **Elem** by using the file conversion facet fac to call **fac.in** as needed. If any read or conversion fails, the function does not succeed.  
  
## See Also  
 [\<fstream>](../vs140/-fstream-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)