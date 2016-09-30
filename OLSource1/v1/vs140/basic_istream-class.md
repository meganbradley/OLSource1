---
title: "basic_istream Class"
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
  - "basic_istream"
  - "istream/std::basic_istream"
  - "std::basic_istream"
  - "std.basic_istream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_istream class"
ms.assetid: c7c27111-de6d-42b4-95a3-a7e65259bf17
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream Class
Describes an object that controls extraction of elements and encoded objects from a stream buffer with elements of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, also known as [char_type](../vs140/basic_ios-class.md#basic_ios__char_type), whose character traits are determined by the class             *Tr*, also known as [traits_type](../vs140/basic_ios-class.md#basic_ios__traits_type).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Most of the member functions that overload [operator>>](#basic_istream__operator_gt__gt_) are formatted input functions. They follow the pattern:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Many other member functions are unformatted input functions. They follow the pattern:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Both groups of functions call [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **eofbit**) if they encounter end of file while extracting elements.  
  
 An object of class <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>,                 *Tr*> stores:  
  
-   A virtual public base object of class [basic_ios](../vs140/basic_ios-class.md)< <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>,                         *Tr*> <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
-   An extraction count for the last unformatted input operation (called **count** in the previous code).  
  
## Example  
 See the example for [basic_ifstream Class](../vs140/basic_ifstream-class.md) to learn more about input streams.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_istream](#basic_istream__basic_istream)|Constructs an object of type <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[gcount](#basic_istream__gcount)|Returns the number of characters read during the last unformatted input.|  
|[get](#basic_istream__get)|Reads one or more characters from the input stream.|  
|[getline](#basic_istream__getline)|Reads a line from the input stream.|  
|[ignore](#basic_istream__ignore)|Causes a number of elements to be skipped from the current read position.|  
|[peek](#basic_istream__peek)|Returns the next character to be read.|  
|[putback](#basic_istream__putback)|Puts a specified character into the stream.|  
|[read](#basic_istream__read)|Reads a specified number of characters from the stream and stores them in an array.|  
|[readsome](#basic_istream__readsome)|Read from buffer only.|  
|[seekg](#basic_istream__seekg)|Moves the read position in a stream.|  
|[sentry](#basic_istream__sentry)|The nested class describes an object whose declaration structures the formatted input functions and the unformatted input functions.|  
|[swap](#basic_istream__swap)|Exchanges this <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object for the provided <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object parameter.|  
|[sync](#basic_istream__sync)|Synchronizes the input device associated with the stream with the stream's buffer.|  
|[tellg](#basic_istream__tellg)|Reports the current read position in the stream.|  
|[unget](#basic_istream__unget)|Puts the most recently read character back into the stream.|  
  
### Operators  
  
|||  
|-|-|  
|[operator>>](#basic_istream__operator_gt__gt_)|Calls a function on the input stream or reads formatted data from the input stream.|  
|[operator=](#basic_istream__operator_eq)|Assigns the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> on the right side of the operator to this object. This is a move assignment involving an <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> reference that does not leave a copy behind.|  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
##  \<a name="basic_istream__basic_istream">\</a>  basic_istream::basic_istream  
 Constructs an object of type <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 An object of type [basic_streambuf](../vs140/basic_streambuf-class.md).  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> if this is a standard stream; otherwise, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object to copy.  
  
### Remarks  
 The first constructor initializes the base class by calling [init](../vs140/basic_ios-class.md#basic_ios__init)(_S <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>). It also stores zero in the extraction count. For more information about this extraction count, see the Remarks section of the [basic_istream Class](../vs140/basic_istream-class.md) overview topic.  
  
 The second constructor initializes the base class by calling <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. It also stores _R <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> in the extraction count and stores zero in the extraction count for _R <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [basic_ifstream::basic_ifstream](../vs140/basic_ifstream-class.md#basic_ifstream__basic_ifstream) to learn more about input streams.  
  
##  \<a name="basic_istream__gcount">\</a>  basic_istream::gcount  
 Returns the number of characters read during the last unformatted input.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The extraction count.  
  
### Remarks  
 Use [basic_istream::get](#basic_istream__get) to read unformatted characters.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>57\</CodeContentPlaceHolder> <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>Type the letter 'a':**  
**a**  
**1**    
##  \<a name="basic_istream__get">\</a>  basic_istream::get  
 Reads one or more characters from the input stream.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The number of characters to read from <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The character that should terminate the read if it is encountered before <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A string in which to write.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A character to get.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A buffer in which to write.  
  
### Return Value  
 The parameterless form of get returns the element read as an integer or end of file. The remaining forms return the stream (* <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>).  
  
### Remarks  
 The first of these unformatted input functions extracts an element, if possible, as if by returning <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>-> <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>. Otherwise, it returns **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof). If the function extracts no element, it calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**).  
  
 The second function extracts the [int_type](../vs140/basic_ios-class.md#basic_ios__int_type) element <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> the same way. If <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> compares equal to **traits_type::eof**, the function calls <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>( **failbit**). Otherwise, it stores **traits_type::**[to_char_type](../vs140/char_traits-struct.md#char_traits__to_char_type)( <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>) in <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>. The function returns **\*this**.  
  
 The third function returns **get**(_                        *Str*, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>('\ **n**')).  
  
 The fourth function extracts up to <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> - 1 elements and stores them in the array beginning at _                        *Str*. It always stores <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> after any extracted elements it stores. In order of testing, extraction stops:  
  
-   At end of file.  
  
-   After the function extracts an element that compares equal to <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, in which case the element is put back to the controlled sequence.  
  
-   After the function extracts <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> - 1 elements.  
  
 If the function extracts no elements, it calls <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>( **failbit**). In any case, it returns **\*this**.  
  
 The fifth function returns **get**( **strbuf**, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>('\ **n**')).  
  
 The sixth function extracts elements and inserts them in **strbuf**. Extraction stops on end-of-file or on an element that compares equal to _                        *Delim,* which is not extracted. It also stops, without extracting the element in question, if an insertion fails or throws an exception (which is caught but not rethrown). If the function extracts no elements, it calls <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>( **failbit**). In any case, the function returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>11**    
##  \<a name="basic_istream__getline">\</a>  basic_istream::getline  
 Gets a line from the input stream.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The number of characters to read from **strbuf**.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The character that should terminate the read if it is encountered before <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A string in which to write.  
  
### Return Value  
 The stream ( **\*this**).  
  
### Remarks  
 The first of these unformatted input functions returns **getline**(_                        *Str*, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>(' <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>**n**')).  
  
 The second function extracts up to <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> - 1 elements and stores them in the array beginning at _                        *Str*. It always stores the string termination character after any extracted elements it stores. In order of testing, extraction stops:  
  
-   At end of file.  
  
-   After the function extracts an element that compares equal to <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, in which case the element is neither put back nor appended to the controlled sequence.  
  
-   After the function extracts <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> - 1 elements.  
  
 If the function extracts no elements or <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> - 1 elements, it calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**). In any case, it returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>1**    
##  \<a name="basic_istream__ignore">\</a>  basic_istream::ignore  
 Causes a number of elements to be skipped from the current read position.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The number of elements to skip from the current read position.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The element that, if encountered before count, causes **ignore** to return and allowing all elements after <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> to be read.  
  
### Return Value  
 The stream ( **\*this**).  
  
### Remarks  
 The unformatted input function extracts up to <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> elements and discards them. If <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> equals **numeric_limits\<int>::max**, however, it is taken as arbitrarily large. Extraction stops early on end of file or on an element <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> such that **traits_type::**[to_int_type](../vs140/char_traits-struct.md#char_traits__to_int_type)( <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>) compares equal to _                        *Delim* (which is also extracted). The function returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>103\</CodeContentPlaceHolder> <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>def**    
##  \<a name="basic_istream__operator_gt__gt_">\</a>  basic_istream::operator&gt;&gt;  
 Calls a function on the input stream or reads formatted data from the input stream.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 A function pointer.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 An object of type **stream_buf**.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The value to read from the stream.  
  
### Return Value  
 The stream ( **\*this**).  
  
### Remarks  
 The <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> header also defines several global extraction operators. For more information, see [operator>> (\<istream>)](../vs140/-istream--operators.md#operator_gt__gt_).  
  
 The first member function ensures that an expression of the form **istr** >> <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> calls [ws](../vs140/-istream--functions.md#ws)( **istr**), and then returns **\*this**. The second and third functions ensure that other manipulators, such as [hex](../vs140/-ios--functions.md#hex), behave similarly. The remaining functions constitute the formatted input functions.  
  
 The function:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 extracts elements, if _                        *Strbuf* is not a null pointer, and inserts them in <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>. Extraction stops on end of file. It also stops without extracting the element in question, if an insertion fails or throws an exception (which is caught but not rethrown). If the function extracts no elements, it calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**). In any case, the function returns **\*this**.  
  
 The function:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 extracts a field and converts it to a Boolean value by calling [use_facet](../vs140/basic_filebuf-class.md#basic_filebuf__open) < <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>\< **Elem**, **InIt**>( [getloc](../vs140/ios_base-class.md#ios_base__getloc)). [get](../vs140/ios_base-class.md#ios_base__getloc)( **InIt**( [rdbuf](../vs140/basic_ios-class.md#basic_ios__rdbuf)), <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>(0), **\*this**, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>). Here, **InIt** is defined as [istreambuf_iterator](../vs140/istreambuf_iterator-class.md)\< **Elem**, **Tr**>. The function returns **\*this**.  
  
 The functions:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 each extract a field and convert it to a numeric value by calling <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>\< **Elem**, **InIt**>( <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>). [get](#basic_istream__get)( **InIt**( <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>(0), **\*this**, <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>). Here, **InIt** is defined as <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>\< **Elem**, **Tr**>, and <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> has type **long***,*<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>*,* or **void \*** as needed.  
  
 If the converted value cannot be represented as the type of <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>, the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**). In any case, the function returns **\*this**.  
  
 The functions:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 each extract a field and convert it to a numeric value by calling <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>\< **Elem**, **InIt**>( <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>). **get**( **InIt**( <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>(0), **\*this**, <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>). Here, **InIt** is defined as <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>\< **Elem**, **Tr**>, and <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> has type **double** or <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> as needed.  
  
 If the converted value cannot be represented as the type of <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>, the function calls <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>( **failbit**). In any case, it returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="basic_istream__operator_eq">\</a>  basic_istream::operator=  
 Assigns the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> on the right side of the operator to this object. This is a move assignment involving an <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> reference that does not leave a copy behind.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> reference to a <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns *this.  
  
### Remarks  
 The member operator calls swap <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_istream__peek">\</a>  basic_istream::peek  
 Returns the next character to be read.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The next character that will be read.  
  
### Remarks  
 The unformatted input function extracts an element, if possible, as if by returning <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> -> [sgetc](../vs140/basic_streambuf-class.md#basic_streambuf__sgetc). Otherwise, it returns **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof).  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>145\</CodeContentPlaceHolder> <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>Type 'abcde': abcde**  
**a abcde**    
##  \<a name="basic_istream__putback">\</a>  basic_istream::putback  
 Puts a specified character into the stream.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 A character to put back into the stream.  
  
### Return Value  
 The stream ( **\*this**).  
  
### Remarks  
 The [unformatted input function](../vs140/basic_istream-class.md) puts back <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, if possible, as if by calling [rdbuf](../vs140/basic_ios-class.md#basic_ios__rdbuf)<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>[sputbackc](../vs140/basic_streambuf-class.md#basic_streambuf__sputbackc). If rdbuf is a null pointer, or if the call to <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> returns **traits_type::**[eof](../vs140/char_traits-struct.md#char_traits__eof), the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **badbit**). In any case, it returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>q**    
##  \<a name="basic_istream__read">\</a>  basic_istream::read  
 Reads a specified number of characters from the stream and stores them in an array.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 The array in which to read the characters.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 The number of characters to read.  
  
### Return Value  
 The stream ( <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>).  
  
### Remarks  
 The unformatted input function extracts up to <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> elements and stores them in the array beginning at _ <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>. Extraction stops early on end of file, in which case the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>). In any case, it returns <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>159\</CodeContentPlaceHolder> <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>Type 'abcde': abcde**  
**abcde**    
##  \<a name="basic_istream__readsome">\</a>  basic_istream::readsome  
 Reads the specified number of character values.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 The array in which <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> stores the characters it reads.  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 The number of characters to read.  
  
### Return Value  
 The number of characters actually read, [gcount](#basic_istream__gcount).  
  
### Remarks  
 This unformatted input function extracts up to <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> elements from the input stream and stores them in the array <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>.  
  
 This function does not wait for input. It reads whatever data is available.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
##  \<a name="basic_istream__seekg">\</a>  basic_istream::seekg  
 Moves the read position in a stream.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 The absolute position in which to move the read pointer.  
  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 An offset to move the read pointer relative to <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 One of the [ios_base::seekdir](../vs140/ios_base-class.md#ios_base__seekdir) enumerations.  
  
### Return Value  
 The stream ( **\*this**).  
  
### Remarks  
 The first member function performs an absolute seek, the second member function performs a relative seek.  
  
> [!NOTE]
>  Do not use the second member function with text files, because Standard C++ does not support relative seeks in text files.  
  
 If [fail](../vs140/basic_ios-class.md#basic_ios__fail) is false, the first member function calls **newpos** = [rdbuf](../vs140/basic_ios-class.md#basic_ios__rdbuf) -> [pubseekpos](../vs140/basic_streambuf-class.md#basic_streambuf__pubseekpos)( <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>), for some **pos_type** temporary object **newpos**. If **fail** is false, the second function calls **newpos** = **rdbuf** -> [pubseekoff](../vs140/basic_streambuf-class.md#basic_streambuf__pubseekoff)( <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>). In either case, if ( <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>) **newpos** == ( <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>)(-1) (the positioning operation fails), the function calls **istr**. [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**). Both functions return **\*this**.  
  
 If [fail](../vs140/basic_ios-class.md#basic_ios__fail) is true, the member functions do nothing.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
##  \<a name="basic_istream__sentry">\</a>  basic_istream::sentry  
 The nested class describes an object whose declaration structures the formatted and unformatted input functions.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 If <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>[good](../vs140/basic_ios-class.md#basic_ios__good) is true, the constructor:  
  
-   Calls <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>. [tie](../vs140/basic_ios-class.md#basic_ios__tie) -> [flush](../vs140/basic_ostream-class.md#basic_ostream__flush) if <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> is not a null pointer  
  
-   Effectively calls [ws](../vs140/-istream--functions.md#ws)( <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>) if <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>. [flags](../vs140/ios_base-class.md#ios_base__flags)**&**[skipws](../vs140/-ios--functions.md#skipws) is nonzero  
  
 If, after any such preparation, <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>. **good** is false, the constructor calls <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>. [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**). In any case, the constructor stores the value returned by <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>. **good** in **status**. A later call to **operator bool** delivers this stored value.  
  
##  \<a name="basic_istream__swap">\</a>  basic_istream::swap  
 Exchanges the contents of two <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 An lvalue reference to a <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The member function calls [swap](../vs140/basic_ios-class.md#basic_ios__swap)<CodeContentPlaceHolder>187\</CodeContentPlaceHolder>. It also exchanges the extraction count with the extraction count for <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_istream__sync">\</a>  basic_istream::sync  
 Synchronizes the input device associated with the stream with the stream's buffer.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 If [rdbuf](../vs140/basic_ios-class.md#basic_ios__rdbuf) is a null pointer, the function returns -1. Otherwise, it calls <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> -> [pubsync](../vs140/basic_streambuf-class.md#basic_streambuf__pubsync). If that returns -1, the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **badbit**) and returns -1. Otherwise, the function returns zero.  
  
##  \<a name="basic_istream__tellg">\</a>  basic_istream::tellg  
 Reports the current read position in the stream.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 The current position in the stream.  
  
### Remarks  
 If [fail](../vs140/basic_ios-class.md#basic_ios__fail) is false, the member function returns [rdbuf](../vs140/basic_ios-class.md#basic_ios__rdbuf) -> [pubseekoff](../vs140/basic_streambuf-class.md#basic_streambuf__pubseekoff)(0, <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>, **in**). Otherwise, it returns <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>(-1).  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
##  \<a name="basic_istream__unget">\</a>  basic_istream::unget  
 Puts the most recently read character back into the stream.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 The stream ( **\*this**).  
  
### Remarks  
 The [unformatted input function](../vs140/basic_istream-class.md) puts back the previous element in the stream, if possible, as if by calling <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> -> [sungetc](../vs140/basic_streambuf-class.md#basic_streambuf__sungetc). If [rdbuf](../vs140/basic_ios-class.md#basic_ios__rdbuf) is a null pointer, or if the call to <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> returns **traits_type::**[eof](../vs140/basic_ios-class.md#basic_ios__eof), the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **badbit**). In any case, it returns **\*this**.  
  
 For information on how <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> might fail, see [basic_streambuf::sungetc](../vs140/basic_streambuf-class.md#basic_streambuf__sungetc).  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>195\</CodeContentPlaceHolder> <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>Type 'abc': abc**  
**abc**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)