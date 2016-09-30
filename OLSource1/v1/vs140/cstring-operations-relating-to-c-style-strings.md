---
title: "CString Operations Relating to C-Style Strings"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CString objects, basic operations"
  - "MFC [C++], string handling class"
  - "string conversion [C++], C-style strings"
  - "strings [C++], string operations"
  - "standard run-time library string functions"
  - "null values, Null-terminated string conversion"
  - "string functions"
  - "strings [C++], in C"
  - "string arguments"
  - "C-style strings"
  - "strings [C++], class CString"
  - "casting CString objects"
ms.assetid: 5048de8a-5298-4891-b8a0-c554b5a3ac1b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CString Operations Relating to C-Style Strings
A [CString](../vs140/using-cstring.md) object contains character string data. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> inherits the set of the [methods and operators](../vs140/cstringt-class.md) that are defined in the class template [CStringT](../vs140/cstringt-class.md) to work with string data. (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that specializes <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to work with the kind of character data that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> supports.)  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> does not store character data internally as a C-style null-terminated string. Instead, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> tracks the length of character data so that it can more securely watch the data and the space it requires.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> does accept C-style strings, and provides ways to access character data as a C-style string. This topic contains the following sections that explain how to use a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object as if it were a C-style null-terminated string.  
  
-   [Converting to C-style null-terminated strings](#_core_using_cstring_as_a_c.2d.style_null.2d.terminated_string)  
  
-   [Working with standard run-time library string functions](#_core_working_with_standard_run.2d.time_library_string_functions)  
  
-   [Modifying CString contents directly](#_core_modifying_cstring_contents_directly)  
  
-   [Using CString objects with variable argument functions](#_core_using_cstring_objects_with_variable_argument_functions)  
  
-   [Specifying CString formal parameters](#_core_specifying_cstring_formal_parameters)  
  
##  \<a name="_core_using_cstring_as_a_c.2d.style_null.2d.terminated_string">\</a> Using CString as a C-Style Null-Terminated String  
 To use a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object as a C-style string, cast the object to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. In the following example, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns a pointer to a read-only C-style null-terminated string. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function puts a copy of the C-style string in the variable <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> methods, for example, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, to modify individual characters in the string object. However, the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> pointer is temporary and becomes invalid when any change is made to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> can also go out of scope and be automatically deleted. We recommend that you get a fresh <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> pointer of a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object every time that you use one.  
  
 Sometimes you may require a copy of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> data to modify directly. Use the more secured function <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> (or the Unicode/MBCS-portable <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>) to copy the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object into a separate buffer. This is where characters can be safely modified, as shown by the following example.  
  
 [!code[NVC_ATLMFC_Utilities#189](../vs140/codesnippet/CPP/cstring-operations-relating-to-c-style-strings_1.cpp)]  
  
> [!NOTE]
>  The third argument to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> (or the Unicode/MBCS-portable <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>) is either a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> (Unicode) or a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> (ANSI). The example above passes a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> for this argument. The C++ compiler automatically applies the conversion function defined for the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class that converts a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to an <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. The ability to define casting operations from one type to another is one of the most useful features of C++.  
  
##  \<a name="_core_working_with_standard_run.2d.time_library_string_functions">\</a> Working with Standard Run-Time Library String Functions  
 You should be able to find a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method to perform any string operation for which you might consider using the standard C run-time library string functions such as <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> (or the Unicode/MBCS-portable <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>).  
  
 If you must use the C run-time string functions, you can use the techniques described in _core_using_cstring_as_a_c.2d.style_null.2d.terminated_string. You can copy the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object to an equivalent C-style string buffer, perform your operations on the buffer, and then assign the resulting C-style string back to a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
##  \<a name="_core_modifying_cstring_contents_directly">\</a> Modifying CString Contents Directly  
 In most situations, you should use <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> member functions to modify the contents of a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object or to convert the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to a C-style character string.  
  
 There are some situations where it makes sense to directly modify the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> contents, for example, when you work with operating-system functions that require a character buffer.  
  
 The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> methods offer access to the internal character buffer of a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object and let you modify it directly. The following steps show how to use these functions for this purpose.  
  
#### To use GetBuffer and ReleaseBuffer to access the internal character buffer of a CString object  
  
1.  Call <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> for a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object and specify the length of the buffer you require.  
  
2.  Use the pointer returned by <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to write characters directly into the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
3.  Call <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object to update all the internal <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> state information, for example, the length of the string. After you modify the contents of a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object directly, you must call <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> before you call any other <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> member functions.  
  
##  \<a name="_core_using_cstring_objects_with_variable_argument_functions">\</a> Using CString Objects with Variable Argument Functions  
 Some C functions take a variable number of arguments. A notable example is <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. Because of the way this kind of function is declared, the compiler cannot be sure of the type of the arguments and cannot determine which conversion operation to perform on each argument. Therefore, it is essential that you use an explicit type cast when passing a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object to a function that takes a variable number of arguments.  
  
 To use a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object in a variable argument function, explicitly cast the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to an <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> string, as shown in the following example.  
  
 [!code[NVC_ATLMFC_Utilities#190](../vs140/codesnippet/CPP/cstring-operations-relating-to-c-style-strings_2.cpp)]  
  
##  \<a name="_core_specifying_cstring_formal_parameters">\</a> Specifying CString Formal Parameters  
 For most functions that need a string argument, it is best to specify the formal parameter in the function prototype as a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> pointer to a character (<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>) instead of a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. When a formal parameter is specified as a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> pointer to a character, you can pass either a pointer to a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> array, a literal string [<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>], or a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object will be automatically converted to an <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>. Any place you can use an <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, you can also use a <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object.  
  
 You can also specify a formal parameter as a constant string reference (that is, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>) if the argument will not be modified. Drop the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> modifier if the string will be modified by the function. If a default null value is desired, initialize it to the null string [<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>], as shown below:  
  
 [!code[NVC_ATLMFC_Utilities#191](../vs140/codesnippet/CPP/cstring-operations-relating-to-c-style-strings_3.cpp)]  
  
 For most function results, you can simply return a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object by value.  
  
## See Also  
 [Strings (ATL/MFC)](../vs140/strings--atl-mfc-.md)   
 [CString Argument Passing](../vs140/cstring-argument-passing.md)