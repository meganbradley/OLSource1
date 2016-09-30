---
title: "money_get Class"
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
  - "xlocmon/std::money_get"
  - "money_get"
  - "std.money_get"
  - "std::money_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "money_get class"
ms.assetid: 692d3374-3fe7-4b46-8aeb-f8d91ed66b2e
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# money_get Class
The template class describes an object that can serve as a locale facet to control conversions of sequences of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to monetary values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The type used within a program to encode characters in a locale.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The type of iterator from which the get functions read their input.  
  
## Remarks  
 As with any locale facet, the static object ID has an initial stored value of zero. The first attempt to access its stored value stores a unique positive value in  **id.**  
  
### Constructors  
  
|||  
|-|-|  
|[money_get](#money_get__money_get)|The constructor for objects of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that are used to extract numerical values from sequences representing monetary values.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#money_get__char_type)|A type that is used to describe a character used by a locale.|  
|[iter_type](#money_get__iter_type)|A type that describes an input iterator.|  
|[string_type](#money_get__string_type)|A type that describes a string containing characters of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[do_get](#money_get__do_get)|A virtual function called to extracts a numerical value from a character sequence that represents a monetary value.|  
|[get](#money_get__get)|Extracts a numerical value from a character sequence that represents a monetary value.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="money_get__char_type">\</a>  money_get::char_type  
 A type that is used to describe a character used by a locale.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
##  \<a name="money_get__do_get">\</a>  money_get::do_get  
 Virtual function called to extracts a numerical value from a character sequence that represents a monetary value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A Boolean value indicating the type of currency symbol expected in the sequence: **true** if international, **false** if domestic.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded or not.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A string storing the converted sequence.  
  
### Return Value  
 An input iterator addressing the first element beyond the monetary input field.  
  
### Remarks  
 The first virtual protected member function tries to match sequential elements beginning at first in the sequence [ <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) until it has recognized a complete, nonempty monetary input field. If successful, it converts this field to a sequence of one or more decimal digits, optionally preceded by a minus sign ( <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>), to represent the amount and stores the result in the [string_type](#money_get__string_type) object <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. It returns an iterator designating the first element beyond the monetary input field. Otherwise, the function stores an empty sequence in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. It returns an iterator designating the first element beyond any prefix of a valid monetary input field. In either case, if the return value equals <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, the function sets <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 The second virtual protected member function behaves the same as the first, except that if successful it converts the optionally signed digit sequence to a value of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 The format of a monetary input field is determined by the [locale facet](../vs140/locale-class.md#facet_class)**fac** returned by the effective call [use_facet](../vs140/-locale--functions.md#use_facet) < [moneypunct](../vs140/moneypunct-class.md)\< **CharType**, **intl**>>( **iosbase**. [getloc](../vs140/ios_base-class.md#ios_base__getloc)).  
  
 Specifically:  
  
-   **fac**. [neg_format](../vs140/moneypunct-class.md#moneypunct__neg_format) determines the order in which components of the field occur.  
  
-   **fac**. [curr_symbol](../vs140/moneypunct-class.md#moneypunct__curr_symbol) determines the sequence of elements that constitutes a currency symbol.  
  
-   **fac**. [positive_sign](../vs140/moneypunct-class.md#moneypunct__positive_sign) determines the sequence of elements that constitutes a positive sign.  
  
-   **fac**. [negative_sign](../vs140/moneypunct-class.md#moneypunct__negative_sign) determines the sequence of elements that constitutes a negative sign.  
  
-   **fac**. [grouping](../vs140/moneypunct-class.md#moneypunct__grouping) determines how digits are grouped to the left of any decimal point.  
  
-   **fac**. [thousands_sep](../vs140/moneypunct-class.md#moneypunct__thousands_sep) determines the element that separates groups of digits to the left of any decimal point.  
  
-   **fac**. [decimal_point](../vs140/moneypunct-class.md#moneypunct__decimal_point) determines the element that separates the integer digits from the fraction digits.  
  
-   **fac**. [frac_digits](../vs140/moneypunct-class.md#moneypunct__frac_digits) determines the number of significant fraction digits to the right of any decimal point. When parsing a monetary amount with more fraction digits than are called for by <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> stops parsing after consuming at most <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> characters.  
  
 If the sign string ( **fac**. <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> or **fac**. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>) has more than one element, only the first element is matched where the element equal to **money_base::sign** appears in the format pattern ( **fac**. <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>). Any remaining elements are matched at the end of the monetary input field. If neither string has a first element that matches the next element in the monetary input field, the sign string is taken as empty and the sign is positive.  
  
 If **iosbase**. [flags](../vs140/ios_base-class.md#ios_base__flags) & [showbase](../vs140/-ios--functions.md#showbase) is nonzero, the string **fac**. <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> must match where the element equal to **money_base::symbol** appears in the format pattern. Otherwise, if **money_base::symbol** occurs at the end of the format pattern, and if no elements of the sign string remain to be matched, the currency symbol is not matched. Otherwise, the currency symbol is optionally matched.  
  
 If no instances of **fac**. <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> occur in the value portion of the monetary input field (where the element equal to **money_base::value** appears in the format pattern), no grouping constraint is imposed. Otherwise, any grouping constraints imposed by **fac**. **grouping** is enforced. Note that the resulting digit sequence represents an integer whose low-order **fac**. <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> decimal digits are considered to the right of the decimal point.  
  
 Arbitrary white space is matched where the element equal to **money_base::space** appears in the format pattern, if it appears other than at the end of the format pattern. Otherwise, no internal white space is matched. An element                         *ch* is considered white space if [use_facet](../vs140/-locale--functions.md#use_facet) < [ctype](../vs140/ctype-class.md)\< **CharType**> >( **iosbase**. [getloc](../vs140/ios_base-class.md#ios_base__getloc)). [is](../vs140/ctype-class.md#ctype__is)( **ctype_base::space**,                         *ch*) is **true**.  
  
### Example  
  See the example for [get](#money_get__get), which calls <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
##  \<a name="money_get__get">\</a>  money_get::get  
 Extracts a numerical value from a character sequence that represents a monetary value.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A Boolean value indicating the type of currency symbol expected in the sequence: **true** if international, **false** if domestic.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A string storing the converted sequence.  
  
### Return Value  
 An input iterator addressing the first element beyond the monetary input field.  
  
### Remarks  
 Both member functions return [do_get](#money_get__do_get)( <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="money_get__iter_type">\</a>  money_get::iter_type  
 A type that describes an input iterator.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **InputIterator**.  
  
##  \<a name="money_get__money_get">\</a>  money_get::money_get  
 The constructor for objects of type <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> that are used to extract numerical values from sequences representing monetary values.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
### Remarks  
 The possible values for the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/locale-class.md#facet_class)( **_***Refs*).  
  
##  \<a name="money_get__string_type">\</a>  money_get::string_type  
 A type that describes a string containing characters of type **CharType**.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The type describes a specialization of template class [basic_string](../vs140/basic_string-class.md).  
  
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [facet Class](../vs140/locale-class.md#facet_class)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)