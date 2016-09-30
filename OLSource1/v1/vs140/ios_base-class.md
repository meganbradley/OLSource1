---
title: "ios_base Class"
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
  - "ios_base"
  - "std.ios_base"
  - "std::ios_base"
  - "xiosbase/std::ios_base"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ios_base class"
ms.assetid: 0f9e0abc-f70f-49bc-aa1f-003859f56cfe
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base Class
The class describes the storage and member functions common to both input and output streams that do not depend on the template parameters. (The template class [basic_ios](../vs140/basic_ios-class.md) describes what is common and is dependent on template parameters.)  
  
 An object of class ios_base stores formatting information, which consists of:  
  
-   Format flags in an object of type [fmtflags](#ios_base__fmtflags).  
  
-   An exception mask in an object of type [iostate](#ios_base__iostate).  
  
-   A field width in an object of type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>*.*  
  
-   A display precision in an object of type <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
-   A locale object in an object of type **locale**.  
  
-   Two extensible arrays, with elements of type **long** and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> pointer.  
  
 An object of class ios_base also stores stream state information, in an object of type [iostate](#ios_base__iostate), and a callback stack.  
  
### Constructors  
  
|||  
|-|-|  
|[ios_base](#ios_base__ios_base)|Constructs <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> objects.|  
  
### Typedefs  
  
|||  
|-|-|  
|[event_callback](#ios_base__event_callback)|Describes a function passed to [register_call](#ios_base__register_callback).|  
|[fmtflags](#ios_base__fmtflags)|Constants to specify the appearance of output.|  
|[iostate](#ios_base__iostate)|Defines constants describing the state of a stream.|  
|[openmode](#ios_base__openmode)|Describes how to interact with a stream.|  
|[seekdir](#ios_base__seekdir)|Specifies starting point for offset operations.|  
  
### Enums  
  
|||  
|-|-|  
|[event](#ios_base__event)|Specifies event types.|  
  
### Constants  
  
|||  
|-|-|  
|[adjustfield](#ios_base__fmtflags)|A bitmask defined as <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.|  
|[app](#ios_base__openmode)|Specifies seeking to the end of a stream before each insertion.|  
|[ate](#ios_base__openmode)|Specifies seeking to the end of a stream when its controlling object is first created.|  
|[badbit](#ios_base__iostate)|Records a loss of integrity of the stream buffer.|  
|[basefield](#ios_base__fmtflags)|A bitmask defined as <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.|  
|[beg](#ios_base__seekdir)|Specifies seeking relative to the beginning of a sequence.|  
|[binary](#ios_base__openmode)|Specifies that a file should be read as a binary stream, rather than as a text stream.|  
|[boolalpha](#ios_base__fmtflags)|Specifies insertion or extraction of objects of type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> as names (such as <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>) rather than as numeric values.|  
|[cur](#ios_base__seekdir)|Specifies seeking relative to the current position within a sequence.|  
|[dec](#ios_base__fmtflags)|Specifies insertion or extraction of integer values in decimal format.|  
|[end](#ios_base__seekdir)|Specifies seeking relative to the end of a sequence.|  
|[eofbit](#ios_base__iostate)|Records end-of-file while extracting from a stream.|  
|[failbit](#ios_base__iostate)|Records a failure to extract a valid field from a stream.|  
|[fixed](#ios_base__fmtflags)|Specifies insertion of floating-point values in fixed-point format (with no exponent field).|  
|[floatfield](#ios_base__fmtflags)|A bitmask defined as <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|[goodbit](#ios_base__iostate)|All state bits clear.|  
|[hex](#ios_base__fmtflags)|Specifies insertion or extraction of integer values in hexadecimal format.|  
|[in](#ios_base__openmode)|Specifies extraction from a stream.|  
|[internal](#ios_base__fmtflags)|Pads to a field width by inserting fill characters at a point internal to a generated numeric field.|  
|[left](#ios_base__fmtflags)|Specifies left justification.|  
|[oct](#ios_base__fmtflags)|Specifies insertion or extraction of integer values in octal format.|  
|[out](#ios_base__openmode)|Specifies insertion to a stream.|  
|[right](#ios_base__fmtflags)|Specifies right justification.|  
|[scientific](#ios_base__fmtflags)|Specifies insertion of floating-point values in scientific format (with an exponent field).|  
|[showbase](#ios_base__fmtflags)|Specifies insertion of a prefix that reveals the base of a generated integer field.|  
|[showpoint](#ios_base__fmtflags)|Specifies unconditional insertion of a decimal point in a generated floating-point field.|  
|[showpos](#ios_base__fmtflags)|Specifies insertion of a plus sign in a nonnegative generated numeric field.|  
|[skipws](#ios_base__fmtflags)|Specifies skipping leading white space before certain extractions.|  
|[trunc](#ios_base__openmode)|Specifies deleting contents of an existing file when its controlling object is created.|  
|[unitbuf](#ios_base__fmtflags)|Causes output to be flushed after each insertion.|  
|[uppercase](#ios_base__fmtflags)|Specifies insertion of uppercase equivalents of lowercase letters in certain insertions.|  
  
### Member Functions  
  
|||  
|-|-|  
|[failure](#ios_base__failure)|The member class serves as the base class for all exceptions thrown by the member function [clear](../vs140/basic_ios-class.md#basic_ios__clear) in template class [basic_ios](../vs140/basic_ios-class.md).|  
|[flags](#ios_base__flags)|Sets or returns the current flag settings.|  
|[getloc](#ios_base__getloc)|Returns the stored locale object.|  
|[imbue](#ios_base__imbue)|Changes the locale.|  
|[Init](#ios_base__init)|Creates the standard iostream objects when constructed.|  
|[iword](#ios_base__iword)|Assigns a value to be stored as an <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.|  
|[precision](#ios_base__precision)|Specifies the number of digits to display in a floating-point number.|  
|[pword](#ios_base__pword)|Assigns a value to be stored as a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.|  
|[register_callback](#ios_base__register_callback)|Specifies a callback function.|  
|[setf](#ios_base__setf)|Sets the specified flags.|  
|[sync_with_stdio](#ios_base__sync_with_stdio)|Ensures that iostream and C run-time library operations occur in the order that they appear in source code.|  
|[unsetf](#ios_base__unsetf)|Causes the specified flags to be off.|  
|[width](#ios_base__width)|Sets the length of the output stream.|  
|[xalloc](#ios_base__xalloc)|Specifies that a variable shall be part of the stream.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#ios_base__operator_eq)|The assignment operator for <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> objects.|  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
##  \<a name="ios_base__event">\</a>  ios_base::event  
 Specifies event types.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 The type is an enumerated type that describes an object that can store the callback event used as an argument to a function registered with [register_callback](#ios_base__register_callback). The distinct event values are:  
  
-   **copyfmt_event**, to identify a callback that occurs near the end of a call to [copyfmt](../vs140/basic_ios-class.md#basic_ios__copyfmt), just before the [exception mask](../vs140/ios_base-class.md) is copied.  
  
-   **erase_event**, to identify a callback that occurs at the beginning of a call to [copyfmt](../vs140/basic_ios-class.md#basic_ios__copyfmt), or at the beginning of a call to the destructor for **\*this**.  
  
-   **imbue_event**, to identify a callback that occurs at the end of a call to [imbue](#ios_base__imbue), just before the function returns.  
  
### Example  
  See [register_callback](#ios_base__register_callback) for an example.  
  
##  \<a name="ios_base__event_callback">\</a>  ios_base::event_callback  
 Describes a function passed to [register_call](#ios_base__register_callback).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *_E*  
 The [event](#ios_base__event).  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The stream in which the event was called.  
  
 *_I*  
 A user-defined number.  
  
### Remarks  
 The type describes a pointer to a function that can be registered with [register_callback](#ios_base__register_callback). This type of function must not throw an exception.  
  
### Example  
  See [register_call](#ios_base__register_callback) for an example that uses <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
##  \<a name="ios_base__failure">\</a>  ios_base::failure  
 The class <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> defines the base class for the types of all objects thrown as exceptions, by functions in the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> library, to report errors detected during stream buffer operations.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The value returned by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is a copy of <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, possibly augmented with a test based on <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is not specified, the default value is <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **Caught an exception: ios_base::failbit set**    
##  \<a name="ios_base__flags">\</a>  ios_base::flags  
 Sets or returns the current flag settings.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The new <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> setting.  
  
### Return Value  
 The previous or current <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> setting.  
  
### Remarks  
 See [ios_base::fmtflags](#ios_base__fmtflags) for a list of the flags.  
  
 The first member function returns the stored format flags. The second member function stores <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> in the format flags and returns its previous stored value.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
   **513**  
 **16896**    
##  \<a name="ios_base__fmtflags">\</a>  ios_base::fmtflags  
 Constants to specify the appearance of output.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 Supports the manipulators in [ios](../vs140/-ios-.md).  
  
 The type is a bitmask type that describes an object that can store format flags. The distinct flag values (elements) are:  
  
-   <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, to insert or extract integer values in decimal format.  
  
-   <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, to insert or extract integer values in hexadecimal format.  
  
-   <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, to insert or extract integer values in octal format.  
  
-   <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, to insert a prefix that reveals the base of a generated integer field.  
  
-   <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, to pad to a field width as needed by inserting fill characters at a point internal to a generated numeric field. (For information on setting the field width, see [setw](../vs140/-iomanip--functions.md#setw)).  
  
-   <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, to pad to a field width as needed by inserting fill characters at the end of a generated field (left justification).  
  
-   <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, to pad to a field width as needed by inserting fill characters at the beginning of a generated field (right justification).  
  
-   <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, to insert or extract objects of type <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> as names (such as <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>) rather than as numeric values.  
  
-   <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, to insert floating-point values in fixed-point format (with no exponent field).  
  
-   <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, to insert floating-point values in scientific format (with an exponent field).  
  
-   <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, to insert a decimal point unconditionally in a generated floating-point field.  
  
-   <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, to insert a plus sign in a nonnegative generated numeric field.  
  
-   <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, to skip leading white space before certain extractions.  
  
-   <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, to flush output after each insertion.  
  
-   <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, to insert uppercase equivalents of lowercase letters in certain insertions.  
  
 In addition, several useful values are:  
  
-   <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, a bitmask defined as <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, defined as <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, defined as <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
 For examples of functions that modify these format flags, see [\<iomanip>](../vs140/-iomanip-.md).  
  
##  \<a name="ios_base__getloc">\</a>  ios_base::getloc  
 Returns the stored locale object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The stored locale object.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **C**    
##  \<a name="ios_base__imbue">\</a>  ios_base::imbue  
 Changes the locale.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The new locale setting.  
  
### Return Value  
 The previous locale.  
  
### Remarks  
 The member function stores <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> in the locale object and then reports the callback event and <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>. It returns the previous stored value.  
  
### Example  
  See [basic_ios::imbue](../vs140/basic_ios-class.md#basic_ios__imbue) for a sample.  
  
##  \<a name="ios_base__init">\</a>  ios_base::Init  
 Creates the standard iostream objects when constructed.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 The nested class describes an object whose construction ensures that the standard iostreams objects are properly constructed, even before the execution of a constructor for an arbitrary static object.  
  
##  \<a name="ios_base__ios_base">\</a>  ios_base::ios_base  
 Constructs ios_base objects.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The (protected) constructor does nothing. A later call to **basic_ios::**[init](../vs140/basic_ios-class.md#basic_ios__init) must initialize the object before it can be safely destroyed. Thus, the only safe use for class ios_base is as a base class for template class [basic_ios](../vs140/basic_ios-class.md).  
  
##  \<a name="ios_base__iostate">\</a>  ios_base::iostate  
 The type of constants that describe the state of a stream.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 The type is a bitmask type that describes an object that can store stream state information. The distinct flag values (elements) are:  
  
-   <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, to record a loss of integrity of the stream buffer.  
  
-   <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>, to record end-of-file while extracting from a stream.  
  
-   <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, to record a failure to extract a valid field from a stream.  
  
 In addition, a useful value is <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, where none of the previously mentioned bits are set ( <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> is guaranteed to be zero).  
  
##  \<a name="ios_base__iword">\</a>  ios_base::iword  
 Assigns a value to be stored as an <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The index of the value to store as an <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member function returns a reference to element <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> of the extensible array with elements of type **long**. All elements are effectively present and initially store the value zero. The returned reference is invalid after the next call to <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> for the object, after the object is altered by a call to **basic_ios::**[copyfmt](../vs140/basic_ios-class.md#basic_ios__copyfmt), or after the object is destroyed.  
  
 If <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is negative or if unique storage is unavailable for the element, the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)**(badbit)** and returns a reference that might not be unique.  
  
 To obtain a unique index, for use across all objects of type <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, call [xalloc](#ios_base__xalloc).  
  
### Example  
  See [xalloc](#ios_base__xalloc) for a sample of how to use <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
##  \<a name="ios_base__openmode">\</a>  ios_base::openmode  
 Describes how to interact with a stream.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 The type is a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> that describes an object that can store the opening mode for several iostreams objects. The distinct flag values (elements) are:  
  
-   **app**, to seek to the end of a stream before each insertion.  
  
-   **ate**, to seek to the end of a stream when its controlling object is first created.  
  
-   **binary**, to read a file as a binary stream, rather than as a text stream.  
  
-   **in**, to permit extraction from a stream.  
  
-   **out**, to permit insertion to a stream.  
  
-   **trunc**, to delete contents of an existing file when its controlling object is created.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="ios_base__operator_eq">\</a>  ios_base::operator=  
 The assignment operator for ios_base objects.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.  
  
### Return Value  
 The object being assigned to.  
  
### Remarks  
 The operator copies the stored formatting information, making a new copy of any extensible arrays. It then returns **\*this**. Note that the callback stack is not copied.  
  
 This operator is only used by classes derived from <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
##  \<a name="ios_base__precision">\</a>  ios_base::precision  
 Specifies the number of digits to display in a floating-point number.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The number of significant digits to display, or the number of digits after the decimal point in fixed notation.  
  
### Return Value  
 The first member function returns the stored [display precision](../vs140/ios_base-class.md). The second member function stores <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> in the display precision and returns its previous stored value.  
  
### Remarks  
 Floating-point numbers are displayed in fixed notation with [fixed](../vs140/-ios--functions.md#fixed).  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
   **31.3**  
 **31.312**    
##  \<a name="ios_base__pword">\</a>  ios_base::pword  
 Assigns a value to be stored as a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 The index of the value to store as a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member function returns a reference to element _                        *Idx* of the extensible array with elements of type <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> pointer. All elements are effectively present and initially store the null pointer. The returned reference is invalid after the next call to <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> for the object, after the object is altered by a call to **basic_ios::**[copyfmt](../vs140/basic_ios-class.md#basic_ios__copyfmt), or after the object is destroyed.  
  
 If _                        *Idx* is negative, or if unique storage is unavailable for the element, the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)**(badbit)** and returns a reference that might not be unique.  
  
 To obtain a unique index, for use across all objects of type <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>, call [xalloc](#ios_base__xalloc).  
  
### Example  
  See [xalloc](#ios_base__xalloc) for an example of using <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
##  \<a name="ios_base__register_callback">\</a>  ios_base::register_callback  
 Specifies a callback function.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Pointer to the callback function.  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 A user-defined number.  
  
### Remarks  
 The member function pushes the pair <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> onto the stored callback stack [callback stack](../vs140/ios_base-class.md). When a callback event **ev** is reported, the functions are called, in reverse order of registry, by the expression ( **\***<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>)( **ev**, <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
   **in callback1**  
 **an imbue event**  
 **in callback1**  
 **an erase event**  
 **in callback2**  
 **an copyfmt event**  
 **in callback2**  
 **an erase event**  
 **in callback2**  
 **an erase event**    
##  \<a name="ios_base__seekdir">\</a>  ios_base::seekdir  
 Specifies starting point for offset operations.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 The type is an enumerated type that describes an object that can store the seek mode used as an argument to the member functions of several iostream classes. The distinct flag values are:  
  
-   **beg**, to seek (alter the current read or write position) relative to the beginning of a sequence (array, stream, or file).  
  
-   **cur**, to seek relative to the current position within a sequence.  
  
-   **end**, to seek relative to the end of a sequence.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
##  \<a name="ios_base__setf">\</a>  ios_base::setf  
 Sets the specified flags.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The flags to turn on.  
  
 *_Unset*  
 The flags to turn off.  
  
### Return Value  
 The previous format flags  
  
### Remarks  
 The first member function effectively calls [flags](#ios_base__flags)(_                        *Mask* &#124; \_                        *Flags*) (set selected bits) and then returns the previous format flags. The second member function effectively calls **flags**(\_                        *Mask* **& fmtfl, flags & ~**<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>) (replace selected bits under a mask) and then returns the previous format flags.  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
##  \<a name="ios_base__sync_with_stdio">\</a>  ios_base::sync_with_stdio  
 Ensures that iostream and C run-time library operations occur in the order that they appear in source code.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 Whether all streams are in sync with **stdio**.  
  
### Return Value  
 Previous setting for this function.  
  
### Remarks  
 The static member function stores a **stdio** sync flag, which is initially **true**. When **true**, this flag ensures that operations on the same file are properly synchronized between the [iostreams](../vs140/iostreams-conventions.md) functions and those defined in the Standard C++ Library. Otherwise, synchronization may or may not be guaranteed, but performance may be improved. The function stores <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> in the **stdio** sync flag and returns its previous stored value. You can call it reliably only before performing any operations on the standard streams.  
  
##  \<a name="ios_base__unsetf">\</a>  ios_base::unsetf  
 Causes the specified flags to be off.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The flags that you want off.  
  
### Remarks  
 The member function effectively calls [flags](#ios_base__flags)( <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>*_Mask* **& flags**) (clear selected bits).  
  
### Example  
  See [ios_base::setf](#ios_base__setf) for a sample of using <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.  
  
##  \<a name="ios_base__width">\</a>  ios_base::width  
 Sets the length of the output stream.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The desired size of the output stream.  
  
### Return Value  
 The current width setting.  
  
### Remarks  
 The first member function returns the stored field width. The second member function stores <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> in the field width and returns its previous stored value.  
  
### Example  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
   **20**  
 **0**    
##  \<a name="ios_base__xalloc">\</a>  ios_base::xalloc  
 Specifies that a variable is part of the stream.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 The static member function returns a stored static value, which it increments on each call.  
  
### Remarks  
 You can use the return value as a unique index argument when calling the member functions [iword](#ios_base__iword) or [pword](#ios_base__pword).  
  
### Example  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
   **11**  
 **13**  
 **testing**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)