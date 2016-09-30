---
title: "basic_ios Class"
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
  - "std.basic_ios"
  - "ios/std::basic_ios"
  - "basic_ios"
  - "std::basic_ios"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ios class"
ms.assetid: 4fdcd8e1-62d2-4611-8a70-1e4f58434007
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios Class
The template class describes the storage and member functions common to both input streams (of template class [basic_istream](../vs140/basic_istream-class.md)) and output streams (of template class [basic_ostream](../vs140/basic_ostream-class.md)) that depend on the template parameters. (The class [ios_base](../vs140/ios_base-class.md) describes what is common and not dependent on template parameters.) An object of class **basic_ios\<class Elem, class Traits>** helps control a stream with elements of type **Elem**, whose character traits are determined by the class **Traits**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A type.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A variable of type <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
## Remarks  
 An object of class **basic_ios\<class Elem, class Traits>** stores:  
  
-   A tie pointer to an object of type [basic_istream](../vs140/basic_istream-class.md)**\<Elem, Traits>**.  
  
-   A stream buffer pointer to an object of type [basic_streambuf](../vs140/basic_streambuf-class.md)**\<Elem, Traits >**.  
  
-   [Formatting information](../vs140/ios_base-class.md).  
  
-   [Stream state information](../vs140/ios_base-class.md) in a base object of type [ios_base](../vs140/ios_base-class.md).  
  
-   A fill character in an object of type <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_ios](#basic_ios__basic_ios)|Constructs the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> class.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#basic_ios__char_type)|A synonym for the template parameter <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.|  
|[int_type](#basic_ios__int_type)|A synonym for <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.|  
|[off_type](#basic_ios__off_type)|A synonym for <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.|  
|[pos_type](#basic_ios__pos_type)|A synonym for <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.|  
|[traits_type](#basic_ios__traits_type)|A synonym for the template parameter <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[bad](#basic_ios__bad)|Indicates a loss of integrity of the stream buffer.|  
|[clear](#basic_ios__clear)|Clears all error flags.|  
|[copyfmt](#basic_ios__copyfmt)|Copies flags from one stream to another.|  
|[eof](#basic_ios__eof)|Indicates if the end of a stream has been reached.|  
|[exceptions](#basic_ios__exceptions)|Indicates which exceptions will be thrown by the stream.|  
|[fail](#basic_ios__fail)|Indicates failure to extract a valid field from a stream.|  
|[fill](#basic_ios__fill)|Specifies or returns the character that will be used when the text is not as wide as the stream.|  
|[good](#basic_ios__good)|Indicates the stream is in good condition.|  
|[imbue](#basic_ios__imbue)|Changes the locale.|  
|[init](#basic_ios__init)|Called by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> constructors.|  
|[move](#basic_ios__move)|Moves all values, except the pointer to the stream buffer, from the parameter to the current object.|  
|[narrow](#basic_ios__narrow)|Finds the equivalent char to a given <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.|  
|[rdbuf](#basic_ios__rdbuf)|Routes stream to specified buffer.|  
|[rdstate](#basic_ios__rdstate)|Reads the state of bits for flags.|  
|[set_rdbuf](#basic_ios__set_rdbuf)|Assigns a stream buffer to be the read buffer for this stream object.|  
|[setstate](#basic_ios__setstate)|Sets additional flags.|  
|[swap](#basic_ios__swap)|Exchanges the values in this <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object for those of another <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object. The pointers to the stream buffers are not swapped.|  
|[tie](#basic_ios__tie)|Ensures that one stream is processed before another stream.|  
|[widen](#basic_ios__widen)|Finds the equivalent <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to a given char.|  
  
### Operators  
  
|||  
|-|-|  
|[explicit operator bool](#basic_ios__operator_bool)|Allows use of a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object as a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. Automatic type conversion is disabled to prevent common, unintended side effects.|  
|[operator void *](#basic_ios__operator_void_star)|Indicates if the stream is still good.|  
|[operator!](#basic_ios__operator_not)|Indicates if the stream is not bad.|  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
##  \<a name="basic_ios__bad">\</a>  basic_ios::bad  
 Indicates a loss of integrity of the stream buffer  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is nonzero; otherwise <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, see [ios_base::iostate](../vs140/ios_base-class.md#ios_base__iostate).  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__basic_ios">\</a>  basic_ios::basic_ios  
 Constructs the basic_ios class.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Standard buffer to store input or output elements.  
  
### Remarks  
 The first constructor initializes its member objects by calling [init](#basic_ios__init)(_ *Sb*). The second (protected) constructor leaves its member objects uninitialized. A later call to **init** must initialize the object before it can be safely destroyed.  
  
##  \<a name="basic_ios__char_type">\</a>  basic_ios::char_type  
 A synonym for the template parameter **Elem**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__clear">\</a>  basic_ios::clear  
 Clears all error flags.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> (optional)  
 The flags you want to set after clearing all flags. Defaults to <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> (optional)  
 Specifies whether the exception should be re-raised. Defaults to <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> (will not re-raise the exception).  
  
### Remarks  
 The flags are **goodbit**,                         **failbit**,                         **eofbit**, and **badbit**. Test for these flags with [good](#basic_ios__good),                         [bad](#basic_ios__bad),                         [eof](#basic_ios__eof), and [fail](#basic_ios__fail)  
  
 The member function replaces the stored stream state information with:  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> &#124;                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>[rdbuf](#basic_ios__rdbuf) != 0 ?                         **goodbit** :                         **badbit**)  
  
 If <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>**&**[exceptions](#basic_ios__exceptions) is nonzero, it then throws an object of class [failure](../vs140/ios_base-class.md#ios_base__failure).  
  
### Example  
  See [rdstate](#basic_ios__rdstate) and [getline](../vs140/-string--functions.md#getline_template_function) for examples using **clear**.  
  
##  \<a name="basic_ios__copyfmt">\</a>  basic_ios::copyfmt  
 Copies flags from one stream to another.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The stream whose flags you want to copy.  
  
### Return Value  
 The **this** object for the stream to which you are copying the flags.  
  
### Remarks  
 The member function reports the callback eventÂ erase_event. It then copies from <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> into **\*this** the fill character, the tie pointer, and the formatting information. Before altering the exception mask, it reports the callback event copyfmt_event. If, after the copy is complete,                         **state &**[exceptions](#basic_ios__exceptions) is nonzero, the function effectively calls [clear](#basic_ios__clear) with the argument [rdstate](#basic_ios__rdstate). It returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__eof">\</a>  basic_ios::eof  
 Indicates if the end of a stream has been reached.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> if the end of the stream has been reached,                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 The member function returns <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> if [rdstate](#basic_ios__rdstate) <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> is nonzero. For more information on <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, see [ios_base::iostate](../vs140/ios_base-class.md#ios_base__iostate).  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__exceptions">\</a>  basic_ios::exceptions  
 Indicates which exceptions will be thrown by the stream.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *_Newexcept*  
 The flags that you want to throw an exception.  
  
### Return Value  
 The flags that are currently specified to thrown an exception for the stream.  
  
### Remarks  
 The first member function returns the stored exception mask. The second member function stores *_Except* in the exception mask and returns its previous stored value. Note that storing a new exception mask can throw an exception just like the call [clear](#basic_ios__clear)(                         [rdstate](#basic_ios__rdstate) ).  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
   **0**  
 **1**  
 **Caught the exception.**  
 **Exception class: class std::ios_base::failure**  
 **Exception description: ios_base::eofbit set**     
##  \<a name="basic_ios__fail">\</a>  basic_ios::fail  
 Indicates failure to extract a valid field from a stream.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> if [rdstate](#basic_ios__rdstate) <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> is nonzero, otherwise <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, see [ios_base::iostate](../vs140/ios_base-class.md#ios_base__iostate).  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__fill">\</a>  basic_ios::fill  
 Specifies or returns the character that will be used when the text is not as wide as the stream.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The character you want as the fill character.  
  
### Return Value  
 The current fill character.  
  
### Remarks  
 The first member function returns the stored fill character. The second member function stores <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> in the fill character and returns its previous stored value.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
   **a**  
 **xxxxa**  
 **x**     
##  \<a name="basic_ios__good">\</a>  basic_ios::good  
 Indicates the stream is in good condition.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> if [rdstate](#basic_ios__rdstate) <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> (no state flags are set), otherwise,                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, see [ios_base::iostate](../vs140/ios_base-class.md#ios_base__iostate).  
  
### Example  
  See [basic_ios::bad](#basic_ios__bad) for an example of using <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_ios__imbue">\</a>  basic_ios::imbue  
 Changes the locale.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 A locale string.  
  
### Return Value  
 The previous locale.  
  
### Remarks  
 If [rdbuf](#basic_ios__rdbuf) is not a null pointer, the member function calls  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>->                        [pubimbue](../vs140/basic_streambuf-class.md#basic_streambuf__pubimbue)(_ *Loc*)  
  
 In any case, it returns [ios_base::imbue](../vs140/ios_base-class.md#ios_base__imbue)(_ *Loc*).  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__init">\</a>  basic_ios::init  
 Called by basic_ios constructors.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Standard buffer to store input or output elements.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 Specifies whether this is a standard stream.  
  
### Remarks  
 The member function stores values in all member objects, so that:  
  
-   [rdbuf](#basic_ios__rdbuf) returns *_Sb.*  
  
-   [tie](#basic_ios__tie) returns a null pointer.  
  
-   [rdstate](#basic_ios__rdstate) returns [goodbit](../vs140/ios_base-class.md#ios_base__iostate) if <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is nonzero; otherwise, it returns [badbit](../vs140/ios_base-class.md#ios_base__iostate).  
  
-   [exceptions](#basic_ios__exceptions) returns **goodbit**.  
  
-   [flags](../vs140/ios_base-class.md#ios_base__flags) returns [skipws](../vs140/ios_base-class.md#ios_base__fmtflags) &#124;                                 [dec](../vs140/ios_base-class.md#ios_base__fmtflags).  
  
-   [width](../vs140/ios_base-class.md#ios_base__width) returns 0.  
  
-   [precision](../vs140/ios_base-class.md#ios_base__precision) returns 6.  
  
-   [fill](#basic_ios__fill) returns the space character.  
  
-   [getloc](../vs140/ios_base-class.md#ios_base__getloc) returns <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
-   [iword](../vs140/ios_base-class.md#ios_base__iword) returns zero, and [pword](../vs140/ios_base-class.md#ios_base__pword) returns a null pointer for all argument values.  
  
##  \<a name="basic_ios__int_type">\</a>  basic_ios::int_type  
 A synonym for **traits_type::int_type**.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__move">\</a>  basic_ios::move  
 Moves all values, except the pointer to the stream buffer, from the parameter to the current object.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object to move values from.  
  
### Remarks  
 The protected member function moves all the values stored in <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> except the stored <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, which is unchanged in <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> and set to a null pointer in <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>. The stored <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> is set to a null pointer in <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_ios__narrow">\</a>  basic_ios::narrow  
 Finds the equivalent char to a given <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> to convert.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> that you want returned if no equivalent is found.  
  
### Return Value  
 The equivalent <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> to a given <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member function returns [use_facet](../vs140/basic_filebuf-class.md#basic_filebuf__open)**<**Â **ctype**\<                        **E**> >(                         [getloc](../vs140/ios_base-class.md#ios_base__getloc)( ) ).                         <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>(                        <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__off_type">\</a>  basic_ios::off_type  
 A synonym for **traits_type::off_type**.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__operator_void_star">\</a>  basic_ios::operator void *  
 Indicates if the stream is still good.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 The operator returns a null pointer only if [fail](#basic_ios__fail).  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **1**    
##  \<a name="basic_ios__operator_not">\</a>  basic_ios::operator!  
 Indicates if the stream is not bad.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 Returns [fail](#basic_ios__fail).  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **0**    
##  \<a name="basic_ios__operator_bool">\</a>  basic_ios::operator bool  
 Allows use of a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object as a <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>. Automatic type conversion is disabled to prevent common, unintended side effects.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 The operator returns a value convertible to <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> only if <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>. The return type is convertible only to <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>, not to <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> or other known scalar type.  
  
##  \<a name="basic_ios__pos_type">\</a>  basic_ios::pos_type  
 A synonym for **traits_type::pos_type**.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__rdbuf">\</a>  basic_ios::rdbuf  
 Routes stream to specified buffer.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 A stream.  
  
### Remarks  
 The first member function returns the stored stream buffer pointer.  
  
 The second member function stores <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> in the stored stream buffer pointer and returns the previously stored value.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **test2**    
##  \<a name="basic_ios__rdstate">\</a>  basic_ios::rdstate  
 Reads the state of bits for flags.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 The stored stream state information.  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
   **0**  
 **0**  
 **0**  
 **4**  
 **2**  
 **1**     
##  \<a name="basic_ios__setstate">\</a>  basic_ios::setstate  
 Sets additional flags.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 Additional flags to set.  
  
### Remarks  
 The member function effectively calls [clear](#basic_ios__clear)(_ *State* &#124;                         [rdstate](#basic_ios__rdstate)).  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
   **0**  
 **1**     
##  \<a name="basic_ios__set_rdbuf">\</a>  basic_ios::set_rdbuf  
 Assigns a stream buffer to be the read buffer for this stream object.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The stream buffer to become the read buffer.  
  
### Remarks  
 The protected member function stores <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.It does not call <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_ios__tie">\</a>  basic_ios::tie  
 Ensures that one stream is processed before another stream.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 A stream.  
  
### Return Value  
 The first member function returns the stored tie pointer. The second member function stores <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> in the tie pointer and returns its previous stored value.  
  
### Remarks  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> causes two streams to be synchronized, such that, operations on one stream occur after operations on the other stream are complete.  
  
### Example  
  In this example, by tying cin to cout, it is guaranteed that the "Enter a number:" string will go to the console before the number itself is extracted from cin. This eliminates the possibility that the "Enter a number:" string is still sitting in the buffer when the number is read, so that we are certain that the user actually has some prompt to respond to. By default, cin and cout are tied.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__traits_type">\</a>  basic_ios::traits_type  
 A synonym for the template parameter **Traits**.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__widen">\</a>  basic_ios::widen  
 Finds the equivalent <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> to a given <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The character to convert.  
  
### Return Value  
 Finds the equivalent <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> to a given <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member function returns [use_facet](../vs140/basic_filebuf-class.md#basic_filebuf__open)<                         **ctype**\<                        **E**> >(                         [getloc](../vs140/ios_base-class.md#ios_base__getloc)).                         <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>(                        <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
##  \<a name="basic_ios__swap">\</a>  basic_ios::swap  
 Exchanges the values in this <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object for those of another <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> object. However, the pointers to the stream buffers are not swapped.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> object that is used to exchange values.  
  
### Remarks  
 The protected member function exchanges all the values stored in <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> except the stored <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)