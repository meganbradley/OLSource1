---
title: "&lt;iomanip&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 3ddde610-70cc-4cfa-8a89-3e83d1d356a8
caps.latest.revision: 10
---
# &lt;iomanip&gt; functions
||||  
|-|-|-|  
|[&lt;iomanip&gt; get_money](#iomanip_get_money)|[&lt;iomanip&gt; get_time](#iomanip_get_time)|[&lt;iomanip&gt; put_money](#iomanip_put_money)|  
|[&lt;iomanip&gt; put_time](#iomanip_put_time)|[quoted](#quoted)|[resetiosflags](#resetiosflags)|  
|[setbase](#setbase)|[setfill](#setfill)|[setiosflags](#setiosflags)|  
|[setprecision](#setprecision)|[setw](#setw)|  
  
##  \<a name="iomanip_get_money">\</a>  &lt;iomanip&gt; get_money  
 Extracts a monetary value from a stream using the desired format, and returns the value in a parameter.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 _Amount  
 The extracted monetary value.  
  
 _Intl  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, use international format. The default value is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
### Remarks  
 The manipulator returns an object that, when extracted from the stream <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, behaves as a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that calls the member function <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for the locale facet <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> associated with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, using <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to indicate international format. If successful, the call stores in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> the extracted monetary value. The manipulator then returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> must be of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or an instantiation of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> with the same element and traits parameters as <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
##  \<a name="iomanip_get_time">\</a>  &lt;iomanip&gt; get_time  
 Extracts a time value from a stream using a desired format. Returns the value in a parameter as a time structure.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The time in the form of a time structure.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The desired format to use to obtain the time value.  
  
### Remarks  
 The manipulator returns an object that, when extracted from the stream <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, behaves as a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> that calls the member function <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> for the locale facet <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> associated with <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, using <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to indicate the time structure and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to indicate the beginning of a null-terminated format string. If successful, the call stores in the time structure the values associated with any extracted time fields. The manipulator then returns <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
##  \<a name="iomanip_put_money">\</a>  &lt;iomanip&gt; put_money  
 Inserts a monetary amount using the desired format into a stream.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The monetary amount to insert into the stream.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Set to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if manipulator should use international format, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if it should not.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
### Remarks  
 The manipulator returns an object that, when inserted into the stream <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, behaves as a formatted output function that calls the member function <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> for the locale facet <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> associated with <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. If successful, the call inserts <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> suitably formatted, using <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to indicate international format and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, as the fill element. The manipulator then returns <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> must be of type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> or an instantiation of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> with the same element and traits parameters as <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
##  \<a name="iomanip_put_time">\</a>  &lt;iomanip&gt; put_time  
 Writes a time value from a time structure to a stream by using a specified format.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The time value to write to the stream, provided in a time structure.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The desired format to write the time value.  
  
### Remarks  
 The manipulator returns an object that, when inserted into the stream <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, behaves as a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. The output function calls the member function <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> for the locale facet <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> associated with <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. The output function uses <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to indicate the time structure and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to indicate the beginning of a NUL-terminated format string. If successful, the call inserts literal text from the format string and converted values from the time structure. The manipulator then returns <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
##  \<a name="quoted">\</a>  quoted  
 **(New in C++14)** An iostream manipulator that enables convenient round-tripping of strings into and out of streams using the >> and << operators.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A std::string, char*, string literal or raw string literal, or a wide version of any of these (e.g. std::wstring, wchar_t\*).  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A user-specified character, or wide character, to use as the delimiter for the beginning and end of the string.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 A user-specified character, or wide character, to use as the escape character for escape sequences within the string.  
  
### Remarks  
 See [Using Insertion Operators and Controlling Format](../vs140/using-insertion-operators-and-controlling-format.md).  
  
### Example  
  This example shows how to use <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> with the default delimiter and escape character using narrow strings. Wide strings are equally supported.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Example  
  The following example shows how to provide custom a delimiter and/or escape character:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="resetiosflags">\</a>  resetiosflags  
 Clears the specified flags.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The flags to clear.  
  
### Return Value  
 The manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**. [setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>[fmtflags](../vs140/ios_base-class.md#ios_base__fmtflags), _                        *Mask*), and then returns **str**.  
  
### Example  
  See [setw](../vs140/-iomanip--functions.md#setw) for an example of using <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
##  \<a name="setbase">\</a>  setbase  
 Set base for integers.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The number base.  
  
### Return Value  
 The manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**. <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>( **mask**, [ios_base::basefield](../vs140/ios_base-class.md#ios_base__fmtflags)), and then returns **str**. Here, **mask** is determined as follows:  
  
-   If _                                *Base* is 8, then **mask** is <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>[oct](../vs140/-ios--functions.md#oct).  
  
-   If _                                *Base* is 10, then mask is <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>[dec](../vs140/-ios--functions.md#dec).  
  
-   If _                                *Base* is 16, then **mask** is <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>[hex](../vs140/-ios--functions.md#hex).  
  
-   If _                                *Base* is any other value, then mask is <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>[fmtflags](../vs140/ios_base-class.md#ios_base__fmtflags)(0).  
  
### Example  
  See [setw](../vs140/-iomanip--functions.md#setw) for an example of using <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
##  \<a name="setfill">\</a>  setfill  
 Sets the character that will be used to fill spaces in a right-justified display.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The character that will be used to fill spaces in a right-justified display.  
  
### Return Value  
 The template manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**. [fill](../vs140/basic_ios-class.md#basic_ios__fill)( <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>), and then returns **str**. The type **Elem** must be the same as the element type for the stream **str**.  
  
### Example  
  See [setw](../vs140/-iomanip--functions.md#setw) for an example of using <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
##  \<a name="setiosflags">\</a>  setiosflags  
 Sets the specified flags.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The flags to set.  
  
### Return Value  
 The manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**. [setf](../vs140/ios_base-class.md#ios_base__setf)(_                        *Mask*), and then returns **str**.  
  
### Example  
  See [setw](../vs140/-iomanip--functions.md#setw) for an example of using <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
##  \<a name="setprecision">\</a>  setprecision  
 Sets the precision for floating-point values.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The precision for floating-point values.  
  
### Return Value  
 The manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**. [precision](../vs140/ios_base-class.md#ios_base__precision)( <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>), and then returns **str**.  
  
### Example  
  See [setw](../vs140/-iomanip--functions.md#setw) for an example of using <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
##  \<a name="setw">\</a>  setw  
 Specifies the width of the display field for the next element in the stream.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The width of the display field.  
  
### Return Value  
 The manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**. [width](../vs140/ios_base-class.md#ios_base__width)(_                        *Wide*), then returns **str**.  
  
### Remarks  
 setw sets the width only for the next element in the stream and must be inserted before each element whose width you want to specify.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
   **default display**  
**d1 = 1.23457**  
**d2 = 12.3457**  
**d3 = 123.457**  
**d4 = 1234.57**  
**d5 = 12345.7**  
**setprecision(3)**  
**default display**  
**d1 = 1.23**  
**d2 = 12.3**  
**d3 = 123**  
**d4 = 1.23e+003**  
**d5 = 1.23e+004**  
**setprecision(12)**  
**default display**  
**d1 = 1.23456789**  
**d2 = 12.3456789**  
**d3 = 123.456789**  
**d4 = 1234.56789**  
**d5 = 12345.6789**  
**setiosflags(4096)**  
**default display**  
**d1 = 1.234567890000e+000**  
**d2 = 1.234567890000e+001**  
**d3 = 1.234567890000e+002**  
**d4 = 1.234567890000e+003**  
**d5 = 1.234567890000e+004**  
**resetiosflags(4096)**  
**default display**  
**d1 = 1.23456789**  
**d2 = 12.3456789**  
**d3 = 123.456789**  
**d4 = 1234.56789**  
**d5 = 12345.6789**  
**setfill('S')**  
**fixed width display set to 15.**  
**d1 = SSSSS1.23456789**  
**d2 = SSSSS12.3456789**  
**d3 = SSSSS123.456789**  
**d4 = SSSSS1234.56789**  
**d5 = SSSSS12345.6789**  
**default display**  
**d1 = 1.23456789**  
**d2 = 12.3456789**  
**d3 = 123.456789**  
**d4 = 1234.56789**  
**d5 = 12345.6789**  
**setfill(' ')**  
**fixed width display set to 15.**  
**d1 =      1.23456789**  
**d2 =      12.3456789**  
**d3 =      123.456789**  
**d4 =      1234.56789**  
**d5 =      12345.6789**  
**default display**  
**d1 = 1.23456789**  
**d2 = 12.3456789**  
**d3 = 123.456789**  
**d4 = 1234.56789**  
**d5 = 12345.6789**  
**setprecision(8)**  
**fixed width display set to 10.**  
**d1 =  1.2345679**  
**d2 =  12.345679**  
**d3 =  123.45679**  
**d4 =  1234.5679**  
**d5 =  12345.679**  
**default display**  
**d1 = 1.2345679**  
**d2 = 12.345679**  
**d3 = 123.45679**  
**d4 = 1234.5679**  
**d5 = 12345.679**  
**setbase(16)**  
**l1 = 10**  
**l2 = 100**  
**l3 = 400**  
**l4 = 1000**  
**l5 = 10000**  
**setbase(8)**  
**l1 = 20**  
**l2 = 400**  
**l3 = 2000**  
**l4 = 10000**  
**l5 = 200000**  
**setbase(10)**  
**l1 = 16**  
**l2 = 256**  
**l3 = 1024**  
**l4 = 4096**  
**l5 = 65536**    
## See Also  
 [&lt;iomanip&gt;](../vs140/-iomanip-.md)