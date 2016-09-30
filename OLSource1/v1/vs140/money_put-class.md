---
title: "money_put Class"
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
  - "std::money_put"
  - "xlocmon/std::money_put"
  - "money_put"
  - "std.money_put"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "money_put class"
ms.assetid: f439fd56-c9b1-414c-95e1-66c918c6eee6
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# money_put Class
The template class describes an object that can serve as a locale facet to control conversions of monetary values to sequences of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The type used within a program to encode characters in a locale.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The type of iterator to which the monetary put functions write their output.  
  
## Remarks  
 As with any locale facet, the static object ID has an initial stored value of zero. The first attempt to access its stored value stores a unique positive value in  **id.**  
  
### Constructors  
  
|||  
|-|-|  
|[money_put](#money_put__money_put)|The constructor for objects of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#money_put__char_type)|A type that is used to describe a character used by a locale.|  
|[iter_type](#money_put__iter_type)|A type that describes an output iterator.|  
|[string_type](#money_put__string_type)|A type that describes a string containing characters of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[do_put](#money_put__do_put)|A virtual function called to convert either number or a string to a character sequence that represents a monetary value.|  
|[put](#money_put__put)|Converts either number or a string to a character sequence that represents a monetary value.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="money_put__char_type">\</a>  money_put::char_type  
 A type that is used to describe a character used by a locale.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
##  \<a name="money_put__do_put">\</a>  money_put::do_put  
 A virtual function called to convert either number or a string to a character sequence that represents a monetary value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 An iterator addressing the first element of the inserted string.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A Boolean value indicating the type of currency symbol expected in the sequence: **true** if international, **false** if domestic.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A character which is used for spacing.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A string object to be converted.  
  
### Return Value  
 An output iterator the addresses the position one beyond the last element produced.  
  
### Remarks  
 The first virtual protected member function generates sequential elements beginning at <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to produce a monetary output field from the [string_type](#money_put__string_type) object <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The sequence controlled by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> must begin with one or more decimal digits, optionally preceded by a minus sign (–), which represents the amount. The function returns an iterator designating the first element beyond the generated monetary output field.  
  
 The second virtual protected member function behaves the same as the first, except that it effectively first converts <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to a sequence of decimal digits, optionally preceded by a minus sign, then converts that sequence as above.  
  
 The format of a monetary output field is determined by the [locale facet](../vs140/locale-class.md#facet_class) fac returned by the (effective) call [use_facet](../vs140/-locale--functions.md#use_facet) < [moneypunct](../vs140/moneypunct-class.md)\< **CharType**, **intl**> >( **iosbase**. [getloc](../vs140/ios_base-class.md#ios_base__getloc)).  
  
 Specifically:  
  
-   **fac**. [pos_format](../vs140/moneypunct-class.md#moneypunct__pos_format) determines the order in which components of the field are generated for a nonnegative value.  
  
-   **fac**. [neg_format](../vs140/moneypunct-class.md#moneypunct__neg_format) determines the order in which components of the field are generated for a negative value.  
  
-   **fac**. [curr_symbol](../vs140/moneypunct-class.md#moneypunct__curr_symbol) determines the sequence of elements to generate for a currency symbol.  
  
-   **fac**. [positive_sign](../vs140/moneypunct-class.md#moneypunct__positive_sign) determines the sequence of elements to generate for a positive sign.  
  
-   **fac**. [negative_sign](../vs140/moneypunct-class.md#moneypunct__negative_sign) determines the sequence of elements to generate for a negative sign.  
  
-   **fac**. [grouping](../vs140/moneypunct-class.md#moneypunct__grouping) determines how digits are grouped to the left of any decimal point.  
  
-   **fac**. [thousands_sep](../vs140/moneypunct-class.md#moneypunct__thousands_sep) determines the element that separates groups of digits to the left of any decimal point.  
  
-   **fac**. [decimal_point](../vs140/moneypunct-class.md#moneypunct__decimal_point) determines the element that separates the integer digits from any fraction digits.  
  
-   **fac**. [frac_digits](../vs140/moneypunct-class.md#moneypunct__frac_digits) determines the number of significant fraction digits to the right of any decimal point.  
  
 If the sign string ( **fac**. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or **fac**. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>) has more than one element, only the first element is generated where the element equal to **money_base::sign** appears in the format pattern ( **fac**. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or **fac**. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>). Any remaining elements are generated at the end of the monetary output field.  
  
 If **iosbase**. [flags](../vs140/ios_base-class.md#ios_base__flags) & [showbase](../vs140/-ios--functions.md#showbase) is nonzero, the string **fac**. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is generated where the element equal to **money_base::symbol** appears in the format pattern. Otherwise, no currency symbol is generated.  
  
 If no grouping constraints are imposed by **fac**. **grouping** (its first element has the value CHAR_MAX), then no instances of **fac**. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> are generated in the value portion of the monetary output field (where the element equal to **money_base::value** appears in the format pattern). If **fac**. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is zero, then no instance of **fac**. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is generated after the decimal digits. Otherwise, the resulting monetary output field places the low-order **fac**. <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> decimal digits to the right of the decimal point.  
  
 Padding occurs as for any numeric output field, except that if **iosbase**. **flags** & **iosbase**. [internal](../vs140/-ios--functions.md#internal) is nonzero, any internal padding is generated where the element equal to **money_base::space** appears in the format pattern, if it does appear. Otherwise, internal padding occurs before the generated sequence. The padding character is **fill**.  
  
 The function calls **iosbase**. **width**(0) to reset the field width to zero.  
  
### Example  
  See the example for [put](#money_put__put), where the virtual member function is called by **put**.  
  
##  \<a name="money_put__iter_type">\</a>  money_put::iter_type  
 A type that describes an output iterator.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **OutputIterator.**  
  
##  \<a name="money_put__money_put">\</a>  money_put::money_put  
 The constructor for objects of type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
### Remarks  
 The possible values for the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: the lifetime of the object is managed by the locales that contain it.  
  
-   1: the lifetime of the object must be manually managed.  
  
-   \> 0: these values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/locale-class.md#facet_class)( <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>).  
  
##  \<a name="money_put__put">\</a>  money_put::put  
 Converts either number or a string to a character sequence that represents a monetary value.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An iterator addressing the first element of the inserted string.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A Boolean value indicating the type of currency symbol expected in the sequence: **true** if international, **false** if domestic.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A character which is used for spacing.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A string object to be converted.  
  
### Return Value  
 An output iterator the addresses the position one beyond the last element produced.  
  
### Remarks  
 Both member functions return [do_put](#money_put__do_put)( <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **money_put( ) = "CAD1,000.12"**    
##  \<a name="money_put__string_type">\</a>  money_put::string_type  
 A type that describes a string containing characters of type **CharType**.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The type describes a specialization of template class [basic_string](../vs140/basic_string-class.md) whose objects can store sequences of elements from the source sequence.  
  
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [facet Class](../vs140/locale-class.md#facet_class)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)