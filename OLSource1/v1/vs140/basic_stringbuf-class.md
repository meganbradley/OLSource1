---
title: "basic_stringbuf Class"
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
  - "basic_stringbuf"
  - "sstream/std::basic_stringbuf"
  - "std.basic_stringbuf"
  - "std::basic_stringbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_stringbuf class"
ms.assetid: 40c85f9e-42a5-4a65-af5c-23c8e3bf8113
caps.latest.revision: 29
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_stringbuf Class
Describes a stream buffer that controls the transmission of elements of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, whose character traits are determined by the class <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, to and from a sequence of elements stored in an array object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The type of the basic element of the string.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The character traits specialized on the basic element of the string.  
  
## Remarks  
 The object is allocated, extended, and freed as necessary to accommodate changes in the sequence.  
  
 An object of class basic_stringbuf< <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>> stores a copy of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>[openmode](../vs140/ios_base-class.md#ios_base__openmode) argument from its constructor as its <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> mode **mode**:  
  
-   If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is nonzero, the input buffer is accessible. For more information, see [basic_streambuf Class](../vs140/basic_streambuf-class.md).  
  
-   If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is nonzero, the output buffer is accessible.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_stringbuf](#basic_stringbuf__basic_stringbuf)|Constructs an object of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#basic_stringbuf__allocator_type)|The type is a synonym for the template parameter <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.|  
|[char_type](#basic_stringbuf__char_type)|Associates a type name with the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> template parameter.|  
|[int_type](#basic_stringbuf__int_type)|Makes this type within <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>'s scope equivalent to the type of the same name in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> scope.|  
|[off_type](#basic_stringbuf__off_type)|Makes this type within <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>'s scope equivalent to the type of the same name in the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> scope.|  
|[pos_type](#basic_stringbuf__pos_type)|Makes this type within <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>'s scope equivalent to the type of the same name in the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> scope.|  
|[traits_type](#basic_stringbuf__traits_type)|Associates a type name with the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> template parameter.|  
  
### Member Functions  
  
|||  
|-|-|  
|[overflow](#basic_stringbuf__overflow)|A protected, virtual function that can be called when a new character is inserted into a full buffer.|  
|[pbackfail](#basic_stringbuf__pbackfail)|The protected virtual member function tries to put back an element into the input buffer, then makes it the current element (pointed to by the next pointer).|  
|[seekoff](#basic_stringbuf__seekoff)|The protected virtual member function tries to alter the current positions for the controlled streams.|  
|[seekpos](#basic_stringbuf__seekpos)|The protected virtual member function tries to alter the current positions for the controlled streams.|  
|[str](#basic_stringbuf__str)|Sets or gets the text in a string buffer without changing the write position.|  
|swap||  
|[underflow](#basic_stringbuf__underflow)|The protected virtual member function to extract the current element from the input stream.|  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
##  \<a name="basic_stringbuf__allocator_type">\</a>  basic_stringbuf::allocator_type  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="basic_stringbuf__basic_stringbuf">\</a>  basic_stringbuf::basic_stringbuf  
 Constructs an object of type <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 An object of type [basic_string](../vs140/basic_string-class.md).  
  
### Remarks  
 The first constructor stores a null pointer in all the pointers controlling the input buffer and the output buffer. For more information, see the Remarks section of the [basic_streambuf Class](../vs140/basic_streambuf-class.md). It also stores <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> as the stringbuf mode. For more information, see the Remarks section of the [basic_stringbuf Class](../vs140/basic_stringbuf-class.md).  
  
 The second constructor allocates a copy of the sequence controlled by the string object <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is nonzero, it sets the input buffer to start reading at the start of the sequence. If <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is nonzero, it sets the output buffer to begin writing at the start of the sequence. It also stores <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> as the stringbuf mode. For more information, see the Remarks section of the [basic_stringbuf Class](../vs140/basic_stringbuf-class.md).  
  
##  \<a name="basic_stringbuf__char_type">\</a>  basic_stringbuf::char_type  
 Associates a type name with the **Elem** template parameter.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="basic_stringbuf__int_type">\</a>  basic_stringbuf::int_type  
 Makes this type within basic_filebuf's scope equivalent to the type of the same name in the **Tr** scope.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="basic_stringbuf__off_type">\</a>  basic_stringbuf::off_type  
 Makes this type within basic_filebuf's scope equivalent to the type of the same name in the **Tr** scope.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="basic_stringbuf__overflow">\</a>  basic_stringbuf::overflow  
 A protected virtual function that can be called when a new character is inserted into a full buffer.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or **traits_type::eof**.  
  
### Return Value  
 If the function cannot succeed, it returns **traits_type::eof**. Otherwise, it returns **traits_type::**[not_eof](../vs140/char_traits-struct.md#char_traits__not_eof)(_                        *Meta*).  
  
### Remarks  
 If _                        *Meta* does not compare equal to **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof), the protected virtual member function tries to insert the element **traits_type::**[to_char_type](../vs140/char_traits-struct.md#char_traits__to_char_type)(\_                        *Meta*) into the output buffer. It can do so in various ways:  
  
-   If a write position is available, it can store the element into the write position and increment the next pointer for the output buffer.  
  
-   It can make a write position available by allocating new or additional storage for the output buffer. Extending the output buffer this way also extends any associated input buffer.  
  
##  \<a name="basic_stringbuf__pbackfail">\</a>  basic_stringbuf::pbackfail  
 The protected virtual member function tries to put back an element into the input buffer, and then make it the current element (pointed to by the next pointer).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or **traits_type::eof**.  
  
### Return Value  
 If the function cannot succeed, it returns **traits_type::eof**. Otherwise, it returns **traits_type::**[not_eof](../vs140/char_traits-struct.md#char_traits__not_eof)(_                        *Meta*).  
  
### Remarks  
 If <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> compares equal to **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof), the element to push back is effectively the one already in the stream before the current element. Otherwise, that element is replaced by **byte** = **traits_type::**[to_char_type](../vs140/char_traits-struct.md#char_traits__to_char_type)(_                        *Meta*). The function can put back an element in various ways:  
  
-   If a putback position is available, and the element stored there compares equal to byte, it can decrement the next pointer for the input buffer.  
  
-   If a putback position is available, and if the stringbuf mode permits the sequence to be altered ( **mode & ios_base::out** is nonzero), it can store byte into the putback position and decrement the next pointer for the input buffer.  
  
##  \<a name="basic_stringbuf__pos_type">\</a>  basic_stringbuf::pos_type  
 Makes this type within basic_filebuf's scope equivalent to the type of the same name in the **Tr** scope.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="basic_stringbuf__seekoff">\</a>  basic_stringbuf::seekoff  
 The protected virtual member function tries to alter the current positions for the controlled streams.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The position to seek for relative to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. For more information, see [basic_stringbuf::off_type](#basic_stringbuf__off_type).  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The starting point for offset operations. See [ios_base::seekdir](../vs140/ios_base-class.md#ios_base__seekdir) for possible values.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions. For more information, see [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
### Return Value  
 Returns the new position or an invalid stream position.  
  
### Remarks  
 For an object of class <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, a stream position consists purely of a stream offset. Offset zero designates the first element of the controlled sequence.  
  
 The new position is determined as follows:  
  
-   If <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, the new position is the beginning of the stream plus <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
-   If <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, the new position is the current stream position plus <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
-   If <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, the new position is the end of the stream plus <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is nonzero, the function alters the next position to read in the input buffer. If <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is nonzero, the function alters the next position to write in the output buffer. For a stream to be affected, its buffer must exist. For a positioning operation to succeed, the resulting stream position must lie within the controlled sequence. If the function affects both stream positions, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> and both streams are positioned at the same element. Otherwise (or if neither position is affected), the positioning operation fails.  
  
 If the function succeeds in altering either or both of the stream positions, it returns the resultant stream position. Otherwise, it fails and returns an invalid stream position.  
  
##  \<a name="basic_stringbuf__seekpos">\</a>  basic_stringbuf::seekpos  
 The protected virtual member function tries to alter the current positions for the controlled streams.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The position to seek for.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
### Return Value  
 If the function succeeds in altering either or both of the stream positions, it returns the resultant stream position. Otherwise, it fails and returns an invalid stream position. To determine if the stream position is invalid, compare the return value with <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
### Remarks  
 For an object of class basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>>, a stream position consists purely of a stream offset. Offset zero designates the first element of the controlled sequence. The new position is determined by _                        *Sp*.  
  
 If **mode & ios_base::in** is nonzero, the function alters the next position to read in the input buffer. If **mode & ios_base::out** is nonzero, the function alters the next position to write in the output buffer. For a stream to be affected, its buffer must exist. For a positioning operation to succeed, the resulting stream position must lie within the controlled sequence. Otherwise (or if neither position is affected), the positioning operation fails.  
  
##  \<a name="basic_stringbuf__str">\</a>  basic_stringbuf::str  
 Sets or gets the text in a string buffer without changing the write position.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The new string.  
  
### Return Value  
 Returns an object of class [basic_string](../vs140/basic_string-class.md)\< **Elem**, **Tr**, Alloc **>,** whose controlled sequence is a copy of the sequence controlled by **\*this**.  
  
### Remarks  
 The first member function returns an object of class basic_string< **Elem**, **Tr**, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>>, whose controlled sequence is a copy of the sequence controlled by **\*this**. The sequence copied depends on the stored stringbuf mode:  
  
-   If **mode & ios_base::out** is nonzero and an output buffer exists, the sequence is the entire output buffer ( [epptr](../vs140/basic_streambuf-class.md#basic_streambuf__epptr) - [pbase](../vs140/basic_streambuf-class.md#basic_streambuf__pbase) elements beginning with <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>).  
  
-   If **mode & ios_base::in** is nonzero and an input buffer exists, the sequence is the entire input buffer ( [egptr](../vs140/basic_streambuf-class.md#basic_streambuf__egptr) - [eback](../vs140/basic_streambuf-class.md#basic_streambuf__eback) elements beginning with <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>).  
  
-   Otherwise, the copied sequence is empty.  
  
 The second member function deallocates any sequence currently controlled by **\*this**. It then allocates a copy of the sequence controlled by <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. If **mode & ios_base::in** is nonzero, it sets the input buffer to start reading at the beginning of the sequence. If **mode & ios_base::out** is nonzero, it sets the output buffer to start writing at the beginning of the sequence.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **test**  
**zest**  
**be**    
##  \<a name="basic_stringbuf__traits_type">\</a>  basic_stringbuf::traits_type  
 Associates a type name with the **Tr** template parameter.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Tr**.  
  
##  \<a name="basic_stringbuf__underflow">\</a>  basic_stringbuf::underflow  
 Protected, virtual function to extract the current element from the input stream.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 If the function cannot succeed, it returns **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof). Otherwise, it returns the current element in the input stream, which are converted.  
  
### Remarks  
 The protected virtual member function tries to extract the current element **byte** from the input buffer, advance the current stream position, and return the element as **traits_type::**[to_int_type](../vs140/char_traits-struct.md#char_traits__to_int_type)( **byte**). It can do so in one way: If a read position is available, it takes **byte** as the element stored in the read position and advances the next pointer for the input buffer.  
  
##  \<a name="basic_streambuf__swap">\</a>  basic_streambuf::swap  
 Swaps the contents of this string buffer with another string buffer.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The basic_stringbuf whose contents will be swapped with this basic_stringbuf.  
  
### Remarks  
  
##  \<a name="basic_stringbuf__operator_eq">\</a>  basic_stringbuf::operator=  
 Assigns the contents of the basic_stringbuf on the right side of the operator to the basic_stringbuf on the left side..  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A basic_stringbuf whose contents, including locale traits, will be assigned to the stringbuf on the left side of the operator.  
  
### Remarks  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)