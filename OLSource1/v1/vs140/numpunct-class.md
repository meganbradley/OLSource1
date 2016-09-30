---
title: "numpunct Class"
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
  - "xlocnum/std::numpunct"
  - "std::numpunct"
  - "numpunct"
  - "std.numpunct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "numpunct class"
ms.assetid: 73fb93cc-ac11-4c98-987c-bfa6267df596
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# numpunct Class
A template class that describes an object that can serve as a local facet to describe the sequences of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> used to represent information about the formatting and punctuation of numeric and Boolean expressions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The type used within a program to encode characters in a locale.  
  
## Remarks  
 As with any locale facet, the static object ID has an initial stored value of zero. The first attempt to access its stored value stores a unique positive value in  **id.**  
  
### Constructors  
  
|||  
|-|-|  
|[numpunct](#numpunct__numpunct)|The constructor for objects of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#numpunct__char_type)|A type that is used to describe a character used by a locale.|  
|[string_type](#numpunct__string_type)|A type that describes a string containing characters of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[decimal_point](#numpunct__decimal_point)|Returns a locale-specific element to use as a decimal point.|  
|[do_decimal_point](#numpunct__do_decimal_point)|A protected virtual member function that is called to return a locale-specific element to use as a decimal point.|  
|[do_falsename](#numpunct__do_falsename)|A protected virtual member function that is called to return a string to use as a text representation of the value <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
|[do_grouping](#numpunct__do_grouping)|A protected virtual member function that is called to return a locale-specific rule for determining how digits are grouped to the left of any decimal point.|  
|[do_thousands_sep](#numpunct__do_thousands_sep)|A protected virtual member function that is called to return a locale-specific element to use as a thousands separator.|  
|[do_truename](#numpunct__do_truename)|A protected virtual member function that is called to return a string to use as a text representation of the value <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
|[falsename](#numpunct__falsename)|Returns a string to use as a text representation of the value <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[grouping](#numpunct__grouping)|Returns a locale-specific rule for determining how digits are grouped to the left of any decimal point.|  
|[thousands_sep](#numpunct__thousands_sep)|Returns a locale-specific element to use as a thousands separator.|  
|[truename](#numpunct__truename)|Returns a string to use as a text representation of the value <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="numpunct__char_type">\</a>  numpunct::char_type  
 A type that is used to describe a character used by a locale.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType.**  
  
##  \<a name="numpunct__decimal_point">\</a>  numpunct::decimal_point  
 Returns a locale-specific element to use as a decimal point.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific element to use as a decimal point.  
  
### Remarks  
 The member function returns [do_decimal_point](#numpunct__do_decimal_point).  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **German_Germany.1252 decimal point ,**  
**German_Germany.1252 thousands separator .**    
##  \<a name="numpunct__do_decimal_point">\</a>  numpunct::do_decimal_point  
 A protected virtual member function that is called to return a locale-specific element to use as a decimal point.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific element to use as a decimal point.  
  
### Example  
  See the example for [decimal_point](#numpunct__decimal_point), where the virtual member function is called by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
##  \<a name="numpunct__do_falsename">\</a>  numpunct::do_falsename  
 The protected virtual member function returns a sequence to use as a text representation of the value **false**.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A string containing a sequence to use as a text representation of the value **false**.  
  
### Remarks  
 The member function returns the string "false" to represent the value **false** in all locales.  
  
### Example  
  See the example for [falsename](#numpunct__falsename), where the virtual member function is called by <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
##  \<a name="numpunct__do_grouping">\</a>  numpunct::do_grouping  
 A protected virtual member function that is called to return a locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
### Remarks  
 The protected virtual member function returns a locale-specific rule for determining how digits are grouped to the left of any decimal point. The encoding is the same as for **lconv::grouping**.  
  
### Example  
  See the example for [grouping](#numpunct__grouping), where the virtual member function is called by **grouping**.  
  
##  \<a name="numpunct__do_thousands_sep">\</a>  numpunct::do_thousands_sep  
 A protected virtual member function that is called to return a locale-specific element to use as a thousands separator.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns a locale-specific element to use as a thousands separator.  
  
### Remarks  
 The protected virtual member function returns a locale-specific element of type **CharType** to use as a group separator to the left of any decimal point.  
  
### Example  
  See the example for [thousands_sep](#numpunct__thousands_sep), where the virtual member function is called by <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
##  \<a name="numpunct__do_truename">\</a>  numpunct::do_truename  
 A protected virtual member function that is called to return a string to use as a text representation of the value **true**.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 A string to use as a text representation of the value **true**.  
  
 All locales return a string "true" to represent the value **true**.  
  
### Example  
  See the example for [truename](#numpunct__truename), where the virtual member function is called by <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
##  \<a name="numpunct__falsename">\</a>  numpunct::falsename  
 Returns a string to use as a text representation of the value **false**.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A string containing a sequence of **CharType**s to use as a text representation of the value **false**.  
  
### Remarks  
 The member function returns the string "false" to represent the value **false** in all locales.  
  
 The member function returns [do_falsename](#numpunct__do_falsename).  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **English_United States.1252 truename true**  
**English_United States.1252 falsename false**  
**French_France.1252 truename true**  
**French_France.1252 falsename false**    
##  \<a name="numpunct__grouping">\</a>  numpunct::grouping  
 Returns a locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
### Remarks  
 The member function returns [do_grouping](#numpunct__do_grouping).  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **German_Germany.1252 international grouping:**  
 **the 0th group to the left of the radix character is of size 3**    
##  \<a name="numpunct__numpunct">\</a>  numpunct::numpunct  
 The constructor for objects of type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
### Remarks  
 The possible values for the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/locale-class.md#facet_class)( <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>).  
  
##  \<a name="numpunct__string_type">\</a>  numpunct::string_type  
 A type that describes a string containing characters of type **CharType**.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 The type describes a specialization of template class [basic_string](../vs140/basic_string-class.md) whose objects can store copies of the punctuation sequences.  
  
##  \<a name="numpunct__thousands_sep">\</a>  numpunct::thousands_sep  
 Returns a locale-specific element to use as a thousands separator.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific element to use as a thousands separator.  
  
### Remarks  
 The member function returns [do_thousands_sep](#numpunct__do_thousands_sep).  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **German_Germany.1252 decimal point ,**  
**German_Germany.1252 thousands separator .**    
##  \<a name="numpunct__truename">\</a>  numpunct::truename  
 Returns a string to use as a text representation of the value **true**.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A string to use as a text representation of the value **true**.  
  
### Remarks  
 The member function returns [do_truename](#numpunct__do_truename).  
  
 All locales return a string "true" to represent the value **true**.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **English_United States.1252 truename true**  
**English_United States.1252 falsename false**  
**French_France.1252 truename true**  
**French_France.1252 falsename false**    
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [facet Class](../vs140/locale-class.md#facet_class)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)