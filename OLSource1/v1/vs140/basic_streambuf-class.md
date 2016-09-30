---
title: "basic_streambuf Class"
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
  - "basic_streambuf"
  - "streambuf/std::basic_streambuf"
  - "std.basic_streambuf"
  - "std::basic_streambuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_streambuf class"
ms.assetid: 136af6c3-13bf-4501-9288-b93da26efac7
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf Class
Describes an abstract base class for deriving a stream buffer, which controls the transmission of elements to and from a specific representation of a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A [char_type](#basic_streambuf__char_type).  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The character [traits_type](#basic_streambuf__traits_type).  
  
## Remarks  
 The template class describes an abstract base class for deriving a stream buffer, which controls the transmission of elements to and from a specific representation of a stream. An object of class <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> helps control a stream with elements of type <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, also known as [char_type](#basic_streambuf__char_type), whose character traits are determined by the class [char_traits](../vs140/char_traits-struct.md), also known as [traits_type](#basic_streambuf__traits_type).  
  
 Every stream buffer conceptually controls two independent streams: one for extractions (input) and one for insertions (output). A specific representation may, however, make either or both of these streams inaccessible. It typically maintains some relationship between the two streams. What you insert into the output stream of a [basic_stringbuf](../vs140/basic_stringbuf-class.md)< <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>> object, for example, is what you later extract from its input stream. When you position one stream of a [basic_filebuf](../vs140/basic_filebuf-class.md)< <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>> object, you position the other stream in tandem.  
  
 The public interface to template class <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> supplies the operations that are common to all stream buffers, however specialized. The protected interface supplies the operations needed for a specific representation of a stream to do its work. The protected virtual member functions let you tailor the behavior of a derived stream buffer for a specific representation of a stream. Each derived stream buffer in this library describes how it specializes the behavior of its protected virtual member functions. The default behavior for the base class, which is often to do nothing, is described in this topic.  
  
 The remaining protected member functions control copying to and from any storage supplied to buffer transmissions to and from streams. An input buffer, for example, is characterized by:  
  
-   [eback](#basic_streambuf__eback), a pointer to the beginning of the buffer.  
  
-   [gptr](#basic_streambuf__gptr), a pointer to the next element to read.  
  
-   [egptr](#basic_streambuf__egptr), a pointer just past the end of the buffer.  
  
 Similarly, an output buffer is characterized by:  
  
-   [pbase](#basic_streambuf__pbase), a pointer to the beginning of the buffer.  
  
-   [pptr](#basic_streambuf__pptr), a pointer to the next element to write.  
  
-   [epptr](#basic_streambuf__epptr), a pointer just past the end of the buffer.  
  
 For any buffer, the following protocol is used:  
  
-   If the next pointer is null, no buffer exists. Otherwise, all three pointers point into the same sequence. They can be safely compared for order.  
  
-   For an output buffer, if the next pointer compares less than the end pointer, you can store an element at the write position designated by the next pointer.  
  
-   For an input buffer, if the next pointer compares less than the end pointer, you can read an element at the read position designated by the next pointer.  
  
-   For an input buffer, if the beginning pointer compares less than the next pointer, you can put back an element at the putback position designated by the decremented next pointer.  
  
 Any protected virtual member functions you write for a class derived from <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>> must cooperate in maintaining this protocol.  
  
 An object of class <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>> stores the six pointers previously described. It also stores a locale object in an object of type [locale](../vs140/locale-class.md) for potential use by a derived stream buffer.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_streambuf](#basic_streambuf__basic_streambuf)|Constructs an object of type <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#basic_streambuf__char_type)|Associates a type name with the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> template parameter.|  
|[int_type](#basic_streambuf__int_type)|Associates a type name within <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> scope with the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> template parameter.|  
|[off_type](#basic_streambuf__off_type)|Associates a type name within <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> scope with the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> template parameter.|  
|[pos_type](#basic_streambuf__pos_type)|Associates a type name within <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> scope with the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> template parameter.|  
|[traits_type](#basic_streambuf__traits_type)|Associates a type name with the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> template parameter.|  
  
### Member Functions  
  
|||  
|-|-|  
|[eback](#basic_streambuf__eback)|A protected function that returns a pointer to the beginning of the input buffer.|  
|[egptr](#basic_streambuf__egptr)|A protected function that returns a pointer just past the end of the input buffer.|  
|[epptr](#basic_streambuf__epptr)|A protected function that returns a pointer just past the end of the output buffer.|  
|[gbump](#basic_streambuf__gbump)|A protected function that adds <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> to the next pointer for the input buffer.|  
|[getloc](#basic_streambuf__getloc)|Gets the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object's locale.|  
|[gptr](#basic_streambuf__gptr)|A protected function that returns a pointer to the next element of the input buffer.|  
|[imbue](#basic_streambuf__imbue)|A protected, virtual function called by [pubimbue](#basic_streambuf__pubimbue).|  
|[in_avail](#basic_streambuf__in_avail)|Returns the number of elements that are ready to be read from the buffer.|  
|[overflow](#basic_streambuf__overflow)|A protected virtual function that can be called when a new character is inserted into a full buffer.|  
|[pbackfail](#basic_streambuf__pbackfail)|A protected virtual member function that tries to put back an element into the input stream, then make it the current element (pointed to by the next pointer).|  
|[pbase](#basic_streambuf__pbase)|A protected function that returns a pointer to the beginning of the output buffer.|  
|[pbump](#basic_streambuf__pbump)|A protected function that adds <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> to the next pointer for the output buffer.|  
|[pptr](#basic_streambuf__pptr)|A protected function that returns a pointer to the next element of the output buffer.|  
|[pubimbue](#basic_streambuf__pubimbue)|Sets the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object's locale.|  
|[pubseekoff](#basic_streambuf__pubseekoff)|Calls [seekoff](#basic_streambuf__seekoff), a protected virtual function that is overridden in a derived class.|  
|[pubseekpos](#basic_streambuf__pubseekpos)|Calls [seekpos](#basic_streambuf__seekpos), a protected virtual function that is overridden in a derived class and resets the current pointer position.|  
|[pubsetbuf](#basic_streambuf__pubsetbuf)|Calls [setbuf](#basic_streambuf__setbuf), a protected virtual function that is overridden in a derived class.|  
|[pubsync](#basic_streambuf__pubsync)|Calls [sync](#basic_streambuf__sync), a protected virtual function that is overridden in a derived class and updates the external stream associated with this buffer.|  
|[sbumpc](#basic_streambuf__sbumpc)|Reads and returns the current element, moving the stream pointer.|  
|[seekoff](#basic_streambuf__seekoff)|The protected virtual member function tries to alter the current positions for the controlled streams.|  
|[seekpos](#basic_streambuf__seekpos)|The protected virtual member function tries to alter the current positions for the controlled streams.|  
|[setbuf](#basic_streambuf__setbuf)|The protected virtual member function performs an operation particular to each derived stream buffer.|  
|[setg](#basic_streambuf__setg)|A protected function that stores <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> in the beginning pointer, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> in the next pointer, and <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> in the end pointer for the input buffer.|  
|[setp](#basic_streambuf__setp)|A protected function that stores <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> in the beginning pointer and <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> in the end pointer for the output buffer.|  
|[sgetc](#basic_streambuf__sgetc)|Returns current element without changing position in the stream.|  
|[sgetn](#basic_streambuf__sgetn)|Returns the number of elements read.|  
|[showmanyc](#basic_streambuf__showmanyc)|Protected virtual member function that returns a count of the number of characters that can be extracted from the input stream and ensure that the program will not be subject to an indefinite wait.|  
|[snextc](#basic_streambuf__snextc)|Reads the current element and returns the following element.|  
|[sputbackc](#basic_streambuf__sputbackc)|Puts a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> in the stream.|  
|[sputc](#basic_streambuf__sputc)|Puts a character into the stream.|  
|[sputn](#basic_streambuf__sputn)|Puts a character string into the stream.|  
|[stossc](#basic_streambuf__stossc)|Move past the current element in the stream.|  
|[sungetc](#basic_streambuf__sungetc)|Gets a character from the stream.|  
|[swap](#basic_streambuf__swap)|Exchanges the values in this object for the values in the provided <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object parameter.|  
|[sync](#basic_streambuf__sync)|A protected virtual function that tries to synchronize the controlled streams with any associated external streams.|  
|[uflow](#basic_streambuf__uflow)|A protected virtual function that extracts the current element from the input stream.|  
|[underflow](#basic_streambuf__underflow)|A protected virtual function that extracts the current element from the input stream.|  
|[xsgetn](#basic_streambuf__xsgetn)|A protected virtual function that extracts elements from the input stream.|  
|[xsputn](#basic_streambuf__xsputn)|A protected virtual function that inserts elements into the output stream.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#basic_streambuf__operator_eq)|Assigns the values of this object from another <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object.|  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
##  \<a name="basic_streambuf__basic_streambuf">\</a>  basic_streambuf::basic_streambuf  
 Constructs an object of type <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 An lvalue reference to the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object that is used to set the values for this <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The first protected constructor stores a null pointer in all pointers controlling the input buffer and the output buffer. It also stores <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> in the locale object. For more information, see [locale::classic](../vs140/locale-class.md#locale__classic).  
  
 The second protected constructor copies the pointers and locale from <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_streambuf__char_type">\</a>  basic_streambuf::char_type  
 Associates a type name with the **Elem** template parameter.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__eback">\</a>  basic_streambuf::eback  
 A protected function that returns a pointer to the beginning of the input buffer.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the beginning of the input buffer.  
  
##  \<a name="basic_streambuf__egptr">\</a>  basic_streambuf::egptr  
 A protected function that returns a pointer just past the end of the input buffer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer just past the end of the input buffer.  
  
##  \<a name="basic_streambuf__epptr">\</a>  basic_streambuf::epptr  
 A protected function that returns a pointer just past the end of the output buffer.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A pointer just past the end of the output buffer.  
  
##  \<a name="basic_streambuf__gbump">\</a>  basic_streambuf::gbump  
 A protected function that adds <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> to the next pointer for the input buffer.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The amount by which to advance the pointer.  
  
##  \<a name="basic_streambuf__getloc">\</a>  basic_streambuf::getloc  
 Gets the basic_streambuf object's locale.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The stored locale object.  
  
### Remarks  
 For related information, see [ios_base::getloc](../vs140/ios_base-class.md#ios_base__getloc).  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **C**    
##  \<a name="basic_streambuf__gptr">\</a>  basic_streambuf::gptr  
 A protected function that returns a pointer to the next element of the input buffer.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the next element of the input buffer.  
  
##  \<a name="basic_streambuf__imbue">\</a>  basic_streambuf::imbue  
 A protected virtual function called by [pubimbue](#basic_streambuf__pubimbue).  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A reference to a locale.  
  
### Remarks  
 The default behavior is to do nothing.  
  
##  \<a name="basic_streambuf__in_avail">\</a>  basic_streambuf::in_avail  
 Returns the number of elements that are ready to be read from the buffer.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements that are ready to be read from the buffer.  
  
### Remarks  
 If a [read position](../vs140/basic_streambuf-class.md) is available, the member function returns [egptr](#basic_streambuf__egptr) – [gptr](#basic_streambuf__gptr). Otherwise, it returns [showmanyc](#basic_streambuf__showmanyc).  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__int_type">\</a>  basic_streambuf::int_type  
 Associates a type name within basic_streambuf scope with one of the types in a template parameter.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__off_type">\</a>  basic_streambuf::off_type  
 Associates a type name within basic_streambuf scope with one of the types in a template parameter.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__operator_eq">\</a>  basic_streambuf::operator=  
 Assigns the values of this object from another <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 An lvalue reference to the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object that is used to assign values to this object.  
  
### Remarks  
 The protected member operator copies from <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> the pointers that control the input buffer and the output buffer. It also stores <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>[getloc()](#basic_streambuf__getloc) in the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>. It returns <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_streambuf__overflow">\</a>  basic_streambuf::overflow  
 A protected virtual function that can be called when a new character is inserted into a full buffer.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof).  
  
### Return Value  
 If the function cannot succeed, it returns **traits_type::eof** or throws an exception. Otherwise, it returns **traits_type::**[not_eof](../vs140/char_traits-struct.md#char_traits__not_eof)(_                        *Meta*). The default behavior is to return **traits_type::eof**.  
  
### Remarks  
 If _                        *Meta* does not compare equal to **traits_type::eof**, the protected virtual member function endeavors to insert the element **traits_type::**[to_char_type](../vs140/char_traits-struct.md#char_traits__to_char_type)(\_                        *Meta*) into the output stream. It can do so in various ways:  
  
-   If a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> is available, it can store the element into the write position and increment the next pointer for the output buffer.  
  
-   It can make a write position available by allocating new or additional storage for the output buffer.  
  
-   It can make a write position available by writing out, to some external destination, some or all of the elements between the beginning and next pointers for the output buffer.  
  
 The virtual overflow function, together with the [sync](#basic_streambuf__sync) and [underflow](#basic_streambuf__underflow) functions, defines the characteristics of the streambuf-derived class. Each derived class might implement overflow differently, but the interface with the calling stream class is the same.  
  
 The <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> function is most frequently called by public <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> functions like <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> when the put area is full, but other classes, including the stream classes, can call <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> anytime.  
  
 The function consumes the characters in the put area between the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> pointers and then reinitializes the put area. The <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> function must also consume <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> (if <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>), or it might choose to put that character in the new put area so that it will be consumed on the next call.  
  
 The definition of consume varies among derived classes. For example, the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> class writes its characters to a file, while the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> class keeps them in its buffer and (if the buffer is designated as dynamic) expands the buffer in response to a call to overflow. This expansion is achieved by freeing the old buffer and replacing it with a new, larger one. The pointers are adjusted as necessary.  
  
##  \<a name="basic_streambuf__pbackfail">\</a>  basic_streambuf::pbackfail  
 A protected virtual member function that tries to put back an element into the input stream, then make it the current element (pointed to by the next pointer).  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof).  
  
### Return Value  
 If the function cannot succeed, it returns **traits_type::eof** or throws an exception. Otherwise, it returns some other value. The default behavior is to return **traits_type::eof**.  
  
### Remarks  
 If _                        *Meta* compares equal to **traits_type::eof**, the element to push back is effectively the one already in the stream before the current element. Otherwise, that element is replaced by **traits_type::**[to_char_type](../vs140/char_traits-struct.md#char_traits__to_char_type)(\_                        *Meta*). The function can put back an element in various ways:  
  
-   If a putback position is available, it can store the element into the putback position and decrement the next pointer for the input buffer.  
  
-   It can make a putback position available by allocating new or additional storage for the input buffer.  
  
-   For a stream buffer with common input and output streams, it can make a putback position available by writing out, to some external destination, some or all of the elements between the beginning and next pointers for the output buffer.  
  
##  \<a name="basic_streambuf__pbase">\</a>  basic_streambuf::pbase  
 A protected function that returns a pointer to the beginning of the output buffer.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the beginning of the output buffer.  
  
##  \<a name="basic_streambuf__pbump">\</a>  basic_streambuf::pbump  
 A protected function that adds <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> to the next pointer for the output buffer.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The number of characters by which to move the write position forward.  
  
##  \<a name="basic_streambuf__pos_type">\</a>  basic_streambuf::pos_type  
 Associates a type name within basic_streambuf scope with one of the types in a template parameter.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__pptr">\</a>  basic_streambuf::pptr  
 A protected function that returns a pointer to the next element of the output buffer.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the next element of the output buffer.  
  
##  \<a name="basic_streambuf__pubimbue">\</a>  basic_streambuf::pubimbue  
 Sets the basic_streambuf object's locale.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 A reference to a locale.  
  
### Return Value  
 The previous value stored in the locale object.  
  
### Remarks  
 The member function stores _                        *Loc* in the locale object and calls [imbue](#basic_streambuf__imbue).  
  
### Example  
  See [basic_ios::imbue](../vs140/basic_ios-class.md#basic_ios__imbue) for an example that uses <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_streambuf__pubseekoff">\</a>  basic_streambuf::pubseekoff  
 Calls [seekoff](#basic_streambuf__seekoff), a protected virtual function that is overridden in a derived class.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 The position to seek for relative to <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The starting point for offset operations. See [seekdir](../vs140/ios_base-class.md#ios_base__seekdir) for possible values.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
### Return Value  
 Returns the new position or an invalid stream position ( [seekoff](#basic_streambuf__seekoff)(_                        *Off*, <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>) ).  
  
### Remarks  
 Moves the pointer relative to <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_streambuf__pubseekpos">\</a>  basic_streambuf::pubseekpos  
 Calls [seekpos](#basic_streambuf__seekpos), a protected virtual function that is overridden in a derived class, and resets the current pointer position.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The position to seek for.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
### Return Value  
 The new position or an invalid stream position. To determine if the stream position is invalid, compare the return value with <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member function returns [seekpos](#basic_streambuf__seekpos)(_                        *Sp*, <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>).  
  
##  \<a name="basic_streambuf__pubsetbuf">\</a>  basic_streambuf::pubsetbuf  
 Calls [setbuf](#basic_streambuf__setbuf), a protected virtual function that is overridden in a derived class.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 A pointer to <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> for this instantiation.  
  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 The size of the buffer.  
  
### Return Value  
 Returns [setbuf](#basic_streambuf__setbuf)( <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>).  
  
##  \<a name="basic_streambuf__pubsync">\</a>  basic_streambuf::pubsync  
 Calls [sync](#basic_streambuf__sync), a protected virtual function that is overridden in a derived class, and updates the external stream associated with this buffer.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 Returns [sync](#basic_streambuf__sync) or –1 if failure.  
  
##  \<a name="basic_streambuf__sbumpc">\</a>  basic_streambuf::sbumpc  
 Reads and returns the current element, moving the stream pointer.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 The current element.  
  
### Remarks  
 If a read position is available, the member function returns **traits_type::**[to_int_type](../vs140/char_traits-struct.md#char_traits__to_int_type)( **\***[gptr](#basic_streambuf__gptr)) and increments the next pointer for the input buffer. Otherwise, it returns [uflow](#basic_streambuf__uflow).  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>146\</CodeContentPlaceHolder> <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>3**  
**51**    
##  \<a name="basic_streambuf__seekoff">\</a>  basic_streambuf::seekoff  
 A protected virtual member function that tries to alter the current positions for the controlled streams.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 The position to seek for relative to <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 The starting point for offset operations. See [seekdir](../vs140/ios_base-class.md#ios_base__seekdir) for possible values.  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
### Return Value  
 Returns the new position or an invalid stream position ( <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> (_                        *Off*, <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>) ).  
  
### Remarks  
 The new position is determined as follows:  
  
-   If <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>, the new position is the beginning of the stream plus _                                *Off*.  
  
-   If <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>, the new position is the current stream position plus _                                *Off*.  
  
-   If <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>, the new position is the end of the stream plus _                                *Off*.  
  
 Typically, if **which & ios_base::in** is nonzero, the input stream is affected, and if **which & ios_base::out** is nonzero, the output stream is affected. Actual use of this parameter varies among derived stream buffers, however.  
  
 If the function succeeds in altering the stream position or positions, it returns the resulting stream position or one of the resulting stream positions. Otherwise, it returns an invalid stream position. The default behavior is to return an invalid stream position.  
  
##  \<a name="basic_streambuf__seekpos">\</a>  basic_streambuf::seekpos  
 A protected virtual member function that tries to alter the current positions for the controlled streams.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 The position to seek for.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
### Return Value  
 The new position, or an invalid stream position. To determine if the stream position is invalid, compare the return value with <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>.  
  
### Remarks  
 The new position is _                        *Sp*.  
  
 Typically, if **which & ios_base::in** is nonzero, the input stream is affected, and if **which & ios_base::out** is nonzero, the output stream is affected. Actual use of this parameter varies among derived stream buffers, however.  
  
 If the function succeeds in altering the stream position or positions, it returns the resulting stream position or one of the resulting stream positions. Otherwise, it returns an invalid stream position (-1). The default behavior is to return an invalid stream position.  
  
##  \<a name="basic_streambuf__setbuf">\</a>  basic_streambuf::setbuf  
 A protected virtual member function that performs an operation particular to each derived stream buffer.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Pointer to a buffer.  
  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 Size of the buffer.  
  
### Return Value  
 The default behavior is to return **this**.  
  
### Remarks  
 See [basic_filebuf](../vs140/basic_filebuf-class.md). <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> provides an area of memory for the <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> object to use. How the buffer is used in defined in the derived classes.  
  
##  \<a name="basic_streambuf__setg">\</a>  basic_streambuf::setg  
 A protected function that stores _                *Gbeg* in the beginning pointer, <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> in the next pointer, and <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> in the end pointer for the input buffer.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 *_Gbeg*  
 A pointer to the beginning of the buffer.  
  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 A pointer to somewhere in the middle of the buffer.  
  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 A pointer to the end of the buffer.  
  
##  \<a name="basic_streambuf__setp">\</a>  basic_streambuf::setp  
 A protected function that stores <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> in the beginning pointer and <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> in the end pointer for the output buffer.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 A pointer to the beginning of the buffer.  
  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 A pointer to the end of the buffer.  
  
##  \<a name="basic_streambuf__sgetc">\</a>  basic_streambuf::sgetc  
 Returns current element without changing position in the stream.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 The current element.  
  
### Remarks  
 If a read position is available, the member function returns **traits_type::**[to_int_type](../vs140/char_traits-struct.md#char_traits__to_int_type)( <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>[gptr](#basic_streambuf__gptr)). Otherwise, it returns [underflow](#basic_streambuf__underflow).  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__sgetn">\</a>  basic_streambuf::sgetn  
 Extracts up to <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> characters from the input buffer and stores them in the provided buffer <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The buffer to contain the extracted characters.  
  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 The number of elements to read.  
  
### Return Value  
 The number of elements read. See [streamsize](../vs140/-ios--typedefs.md#streamsize) for more information.  
  
### Remarks  
 The member function returns [xsgetn](#basic_streambuf__xsgetn)( <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__showmanyc">\</a>  basic_streambuf::showmanyc  
 A protected virtual member function that returns a count of the number of characters that can be extracted from the input stream and ensure that the program will not be subject to an indefinite wait.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
 The default behavior is to return zero.  
  
##  \<a name="basic_streambuf__snextc">\</a>  basic_streambuf::snextc  
 Reads the current element and returns the following element.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 The next element in the stream.  
  
### Remarks  
 The member function calls [sbumpc](#basic_streambuf__sbumpc) and, if that function returns **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof), returns **traits_type::eof**. Otherwise, it returns [sgetc](#basic_streambuf__sgetc).  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>183\</CodeContentPlaceHolder> <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>97**    
##  \<a name="basic_streambuf__sputbackc">\</a>  basic_streambuf::sputbackc  
 Puts a char_type in the stream.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 The character.  
  
### Return Value  
 Returns the character or failure.  
  
### Remarks  
 If a putback position is available and <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> compares equal to the character stored in that position, the member function decrements the next pointer for the input buffer and returns **traits_type::**[to_int_type](../vs140/char_traits-struct.md#char_traits__to_int_type)( <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>). Otherwise, it returns [pbackfail](#basic_streambuf__pbackfail)( <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__sputc">\</a>  basic_streambuf::sputc  
 Puts a character into the stream.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 The character.  
  
### Return Value  
 Returns the character, if successful.  
  
### Remarks  
 If a <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> is available, the member function stores <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> in the write position, increments the next pointer for the output buffer, and returns **traits_type::**[to_int_type](../vs140/char_traits-struct.md#char_traits__to_int_type)( <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>). Otherwise, it returns [overflow](#basic_streambuf__overflow)( <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  **a**  
**a**    
##  \<a name="basic_streambuf__sputn">\</a>  basic_streambuf::sputn  
 Puts a character string into the stream.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 The character string.  
  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The count of characters.  
  
### Return Value  
 The number of characters actually inserted into the stream.  
  
### Remarks  
 The member function returns [xsputn](#basic_streambuf__xsputn)( <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>). See the Remarks section of this member for more information.  
  
### Example  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  **test**  
**4**    
##  \<a name="basic_streambuf__stossc">\</a>  basic_streambuf::stossc  
 Move past the current element in the stream.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Remarks  
 The member function calls [sbumpc](#basic_streambuf__sbumpc). Note that an implementation is not required to supply this member function.  
  
### Example  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__sungetc">\</a>  basic_streambuf::sungetc  
 Gets a character from the stream.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
 Returns either the character or failure.  
  
### Remarks  
 If a putback position is available, the member function decrements the next pointer for the input buffer and returns <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>[to_int_type](../vs140/char_traits-struct.md#char_traits__to_int_type)( <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>[gptr](#basic_streambuf__gptr)). However, it is not always possible to determine the last character read so that it can be captured in the state of the current buffer. If this is true, then the function returns [pbackfail](#basic_streambuf__pbackfail). To avoid this situation, keep track of the character to put back and call <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>, which will not fail provided you don't call it at the beginning of the stream and you don't try to put back more than one character.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__swap">\</a>  basic_streambuf::swap  
 Exchanges the values in this object for the values in the provided <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>202\</CodeContentPlaceHolder>|An lvalue reference to the <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> object that is used to exchange values.|  
  
### Remarks  
 The protected member function exchanges with <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> all the pointers controlling the <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>. It also exchanges <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>[getloc()](#basic_streambuf__getloc) with the <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> object.  
  
##  \<a name="basic_streambuf__sync">\</a>  basic_streambuf::sync  
 A protected virtual function that tries to synchronize the controlled streams with any associated external streams.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 If the function cannot succeed, it returns -1. The default behavior is to return zero.  
  
### Remarks  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> involves writing out any elements between the beginning and next pointers for the output buffer. It does not involve putting back any elements between the next and end pointers for the input buffer.  
  
##  \<a name="basic_streambuf__traits_type">\</a>  basic_streambuf::traits_type  
 Associates a type name with the **Tr** template parameter.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
##  \<a name="basic_streambuf__uflow">\</a>  basic_streambuf::uflow  
 A protected virtual function that extracts the current element from the input stream.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 The current element.  
  
### Remarks  
 The protected virtual member function tries to extract the current element **ch** from the input stream, then advance the current stream position, and return the element as **traits_type::**[to_int_type](../vs140/char_traits-struct.md#char_traits__to_int_type)( **ch**). It can do so in various ways:  
  
-   If a read position is available, it takes **ch** as the element stored in the read position and advances the next pointer for the input buffer.  
  
-   It can read an element directly, from some external source, and deliver it as the value **ch**.  
  
-   For a stream buffer with common input and output streams, it can make a read position available by writing out, to some external destination, some or all of the elements between the beginning and next pointers for the output buffer. Or it can allocate new or additional storage for the input buffer. The function then reads in, from some external source, one or more elements.  
  
 If the function cannot succeed, it returns **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof), or throws an exception. Otherwise, it returns the current element <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> in the input stream, converted as described above, and advances the next pointer for the input buffer. The default behavior is to call [underflow](#basic_streambuf__underflow) and, if that function returns **traits_type::eof**, to return **traits_type::eof**. Otherwise, the function returns the current element **ch** in the input stream, converted as previously described, and advances the next pointer for the input buffer.  
  
##  \<a name="basic_streambuf__underflow">\</a>  basic_streambuf::underflow  
 Protected, virtual function to extract the current element from the input stream.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Return Value  
 The current element.  
  
### Remarks  
 The protected virtual member function endeavors to extract the current element **ch** from the input stream, without advancing the current stream position, and return it as <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>[to_int_type](../vs140/char_traits-struct.md#char_traits__to_int_type)( **ch**). It can do so in various ways:  
  
-   If a read position is available, **ch** is the element stored in the read position. For more information on this, see the Remarks section of the [basic_streambuf Class](../vs140/basic_streambuf-class.md).  
  
-   It can make a read position available by allocating new or additional storage for the input buffer, then reading in, from some external source, one or more elements. For more information on this, see the Remarks section of the [basic_streambuf Class](../vs140/basic_streambuf-class.md).  
  
 If the function cannot succeed, it returns <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>[eof](../vs140/char_traits-struct.md#char_traits__eof)<CodeContentPlaceHolder>213\</CodeContentPlaceHolder> or throws an exception. Otherwise, it returns the current element in the input stream, converted as previously described. The default behavior is to return <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>.  
  
 The virtual <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> function, with the [sync](#basic_streambuf__sync) and [overflow](#basic_streambuf__overflow) functions, defines the characteristics of the <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>-derived class. Each derived class might implement <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> differently, but the interface with the calling stream class is the same.  
  
 The <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> function is most frequently called by public <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> functions like [sgetc](#basic_streambuf__sgetc) and [sgetn](#basic_streambuf__sgetn) when the get area is empty, but other classes, including the stream classes, can call <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> anytime.  
  
 The <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> function supplies the get area with characters from the input source. If the get area contains characters, <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> returns the first character. If the get area is empty, it fills the get area and returns the next character (which it leaves in the get area). If there are no more characters available, then <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> and leaves the get area empty.  
  
 In the <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> class, <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> adjusts the [egptr](#basic_streambuf__egptr) pointer to access storage that was dynamically allocated by a call to <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_streambuf__xsgetn">\</a>  basic_streambuf::xsgetn  
 Protected, virtual function to extract elements from the input stream.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
 The buffer to contain the extracted characters.  
  
 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
 The number of elements to extract.  
  
### Return Value  
 The number of elements extracted.  
  
### Remarks  
 The protected virtual member function extracts up to <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> elements from the input stream, as if by repeated calls to [sbumpc](#basic_streambuf__sbumpc), and stores them in the array beginning at <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>. It returns the number of elements actually extracted.  
  
##  \<a name="basic_streambuf__xsputn">\</a>  basic_streambuf::xsputn  
 Protected, virtual function to insert elements into the output stream.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 Pointer to elements to insert.  
  
 <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 Number of elements to insert.  
  
### Return Value  
 The number of elements actually inserted into the stream.  
  
### Remarks  
 The protected virtual member function inserts up to <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> elements into the output stream, as if by repeated calls to [sputc](#basic_streambuf__sputc), from the array beginning at <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>. The insertion of characters into the output stream stops once all <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> characters have been written, or if calling <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> would return <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>. It returns the number of elements actually inserted.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)