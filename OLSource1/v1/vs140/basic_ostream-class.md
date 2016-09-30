---
title: "basic_ostream Class"
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
  - "std::basic_ostream"
  - "std.basic_ostream"
  - "ostream/std::basic_ostream"
  - "basic_ostream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ostream class"
ms.assetid: 5baadc65-b662-4fab-8c9f-94457c58cda1
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_ostream Class
This template class describes an object that controls insertion of elements and encoded objects into a stream buffer with elements of type **Elem**, also known as [char_type](../vs140/basic_ios-class.md#basic_ios__char_type), whose character traits are determined by the class **Tr**, also known as [traits_type](../vs140/basic_ios-class.md#basic_ios__traits_type).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The character <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Remarks  
 Most of the member functions that overload [operator<<](#basic_ostream__operator_lt__lt_) are formatted output functions. They follow the pattern:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Two other member functions are unformatted output functions. They follow the pattern:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Both groups of functions call [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)**(badbit)** if they encounter a failure while inserting elements.  
  
 An object of class basic_istream\< **Elem**, **Tr**> stores only a virtual public base object of class [basic_ios](../vs140/basic_ios-class.md)**\<Elem**,  **Tr>**.  
  
## Example  
 See the example for [basic_ofstream Class](../vs140/basic_ofstream-class.md) to learn more about output streams.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_ostream](#basic_ostream__basic_ostream)|Constructs a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.|  
  
### Member Functions  
  
|||  
|-|-|  
|[flush](#basic_ostream__flush)|Flushes the buffer.|  
|[put](#basic_ostream__put)|Puts a character in a stream.|  
|[seekp](#basic_ostream__seekp)|Resets position in output stream.|  
|[sentry](#basic_ostream__sentry)|The nested class describes an object whose declaration structures the formatted output functions and the unformatted output functions.|  
|[swap](#basic_ostream__operator_eq)|Exchanges the values of this <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object for those of the provided <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.|  
|[tellp](#basic_ostream__tellp)|Reports position in output stream.|  
|[write](#basic_ostream__write)|Puts characters in a stream.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#basic_ostream__operator_eq)|Assigns the value of the provided <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object parameter to this object.|  
|[operator<<](#basic_ostream__operator_lt__lt_)|Writes to the stream.|  
  
## Requirements  
 **Header:** \<ostream>  
  
 **Namespace:** std  
  
##  \<a name="basic_ostream__basic_ostream">\</a>  basic_ostream::basic_ostream  
 Constructs a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 An object of type [basic_streambuf](../vs140/basic_streambuf-class.md).  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> if this is a standard stream; otherwise, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 An rvalue reference to an object of type <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first constructor initializes the base class by calling [init](../vs140/basic_ios-class.md#basic_ios__init)(<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>). The second constructor initializes the base class by calling [move](../vs140/basic_ios-class.md#basic_ios__move)<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [basic_ofstream::basic_ofstream](../vs140/basic_ofstream-class.md#basic_ofstream__basic_ofstream) to learn more about output streams.  
  
##  \<a name="basic_ostream__flush">\</a>  basic_ostream::flush  
 Flushes the buffer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the basic_ostream object.  
  
### Remarks  
 If [rdbuf](../vs140/basic_ios-class.md#basic_ios__rdbuf) is not a null pointer, the function calls **rdbuf->**[pubsync](../vs140/basic_streambuf-class.md#basic_streambuf__pubsync). If that returns -1, the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)(**badbit**). It returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **test**    
##  \<a name="basic_ostream__operator_lt__lt_">\</a>  basic_ostream::operator&lt;&lt;  
 Writes to the stream.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A function pointer.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to a **stream_buf** object.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 An element to write to the stream.  
  
### Return Value  
 A reference to the basic_ostream object.  
  
### Remarks  
 The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> header also defines several global insertion operators. For more information, see [operator<< (\<ostream>)](../vs140/-ostream--operators.md#operator_lt__lt_).  
  
 The first member function ensures that an expression of the form **ostr << endl** calls [endl](../vs140/-ostream--functions.md#endl)**(ostr)**, and then returns **\*this**. The second and third functions ensure that other manipulators, such as [hex](../vs140/-ios--functions.md#hex), behave similarly. The remaining functions are all formatted output functions.  
  
 The function  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 extracts elements from <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is not a null pointer, and inserts them. Extraction stops on end of file, or if an extraction throws an exception (which is rethrown). It also stops, without extracting the element in question, if an insertion fails. If the function inserts no elements, or if an extraction throws an exception, the function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)(**failbit**). In any case, the function returns **\*this**.  
  
 The function  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 converts _<CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to a Boolean field and inserts it by calling [use_facet](../vs140/basic_filebuf-class.md#basic_filebuf__open)**<num_put\<Elem, OutIt>**<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>[getloc](../vs140/ios_base-class.md#ios_base__getloc)). [put](#basic_ostream__put)(**OutIt**([rdbuf](../vs140/basic_ios-class.md#basic_ios__rdbuf)), **\*this**, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, **val**). Here, **OutIt** is defined as [ostreambuf_iterator](../vs140/ostreambuf_iterator-class.md)**\<Elem, Tr>**. The function returns **\*this**.  
  
 The functions  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 each convert <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to a numeric field and insert it by calling **use_facet<num_put\<Elem, OutIt>**(<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>). **put**(**OutIt**(<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>), **\*this**, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, **val**). Here, **OutIt** is defined as **ostreambuf_iterator\<Elem, Tr>**. The function returns **\*this**.  
  
 The functions  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 each convert _<CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to a numeric field and insert it by calling **use_facet<num_put\<Elem, OutIt>**(<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>)**. put**(**OutIt**(<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>), **\*this**, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, **val**). Here, **OutIt** is defined as **ostreambuf_iterator\<Elem, Tr>**. The function returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="basic_ostream__operator_eq">\</a>  basic_ostream::operator=  
 Assigns values for the provided <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object parameter to this object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> reference to a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The member operator calls swap <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_ostream__put">\</a>  basic_ostream::put  
 Puts a character in a stream.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A character.  
  
### Return Value  
 A reference to the basic_ostream object.  
  
### Remarks  
 The unformatted output function inserts the element <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. It returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **v**  
**l**    
##  \<a name="basic_ostream__seekp">\</a>  basic_ostream::seekp  
 Reset position in output stream.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The position in the stream.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The offset relative to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 One of the [ios_base::seekdir](../vs140/ios_base-class.md#ios_base__seekdir) enumerations.  
  
### Return Value  
 A reference to the basic_ostream object.  
  
### Remarks  
 If [fail](../vs140/basic_ios-class.md#basic_ios__fail) is **false**, the first member function calls **newpos =** [rdbuf](../vs140/basic_ios-class.md#basic_ios__rdbuf)**->** [pubseekpos](../vs140/basic_streambuf-class.md#basic_streambuf__pubseekpos)(_*Pos*), for some <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> temporary object **newpos**. If **fail** is false, the second function calls **newpos = rdbuf->** [pubseekoff](../vs140/basic_streambuf-class.md#basic_streambuf__pubseekoff)(*_Off, _Way*). In either case, if (<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>)**newpos ==** (<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>)(-1) (the positioning operation fails), then the function calls **istr.**[setstate](../vs140/basic_ios-class.md#basic_ios__setstate)(**failbit**). Both functions return **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **0**  
**7**    
##  \<a name="basic_ostream__sentry">\</a>  basic_ostream::sentry  
 The nested class describes an object whose declaration structures the formatted output functions and the unformatted output functions.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 The nested class describes an object whose declaration structures the formatted output functions and the unformatted output functions. If **ostr.**[good](../vs140/basic_ios-class.md#basic_ios__good) is **true** and **ostr.**[tie](../vs140/basic_ios-class.md#basic_ios__tie) is not a null pointer, the constructor calls **ostr.tie->**[flush](#basic_ostream__flush). The constructor then stores the value returned by **ostr.good** in **status**. A later call to **operator bool** delivers this stored value.  
  
 If <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> returns **false** and [flags](../vs140/ios_base-class.md#ios_base__flags) **&** [unitbuf](../vs140/-ios--functions.md#unitbuf) is nonzero, the destructor calls [flush](#basic_ostream__flush).  
  
##  \<a name="basic_ostream__swap">\</a>  basic_ostream::swap  
 Exchanges the values of this <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object for the values of the provided <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The member function calls [swap](../vs140/basic_ios-class.md#basic_ios__swap)<CodeContentPlaceHolder>74\</CodeContentPlaceHolder> to exchange the contents of this object for the contents of <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_ostream__tellp">\</a>  basic_ostream::tellp  
 Report position in output stream.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Position in output stream.  
  
### Remarks  
 If [fail](../vs140/basic_ios-class.md#basic_ios__fail) is **false**, the member function returns [rdbuf](../vs140/basic_ios-class.md#basic_ios__rdbuf)**->** [pubseekoff](../vs140/basic_streambuf-class.md#basic_streambuf__pubseekoff)(0, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, **in**). Otherwise, it returns <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>(-1).  
  
### Example  
  See [seekp](#basic_ostream__seekp) for an example using <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_ostream__write">\</a>  basic_ostream::write  
 Put characters in a stream.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Count of characters to put into the stream.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Characters to put into the stream.  
  
### Return Value  
 A reference to the basic_ostream object.  
  
### Remarks  
 The [unformatted output function](../vs140/basic_ostream-class.md) inserts the sequence of <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> elements beginning at <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
### Example  
  See [streamsize](../vs140/-ios--typedefs.md#streamsize) for an example using <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)