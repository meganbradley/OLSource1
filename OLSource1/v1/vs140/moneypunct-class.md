---
title: "moneypunct Class"
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
  - "moneypunct"
  - "std.moneypunct"
  - "xlocmon/std::moneypunct"
  - "std::moneypunct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "moneypunct class"
ms.assetid: cf2650da-3e6f-491c-95d5-23e57f582ee6
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct Class
The template class describes an object that can serve as a locale facet to describe the sequences of type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> used to represent a monetary input field or a monetary output field. If the template parameter <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, international conventions are observed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The type used within a program to encode characters.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A flag specifying whether international conventions are to be observed.  
  
## Remarks  
 As with any locale facet, the static object ID has an initial stored value of zero. The first attempt to access its stored value stores a unique positive value in  **id.**  
  
 The const static object intl stores the value of the template parameter **Intl**.  
  
### Constructors  
  
|||  
|-|-|  
|[moneypunct](#moneypunct__moneypunct)|Constructor of objects of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#moneypunct__char_type)|A type that is used to describe a character used by a locale.|  
|[string_type](#moneypunct__string_type)|A type that describes a string containing characters of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[curr_symbol](#moneypunct__curr_symbol)|Returns a locale-specific sequence of elements to use as a currency symbol.|  
|[decimal_point](#moneypunct__decimal_point)|Returns a locale-specific sequence of elements to use as a decimal point symbol.|  
|[do_curr_symbol](#moneypunct__do_curr_symbol)|A protected virtual member function that returns a locale-specific sequence of elements to use as a currency symbol.|  
|[do_decimal_point](#moneypunct__do_decimal_point)|A protected virtual member function that is called to return a locale-specific sequence of elements to use as a decimal point symbol.|  
|[do_frac_digits](#moneypunct__do_frac_digits)|The protected virtual member function returns a locale-specific count of the number of digits to display to the right of any decimal point.|  
|[do_grouping](#moneypunct__do_grouping)|The protected virtual member function returns a locale-specific rule for determining how digits are grouped to the left of any decimal point.|  
|[do_neg_format](#moneypunct__do_neg_format)|A protected virtual member function that is called to return a locale-specific rule for formatting outputs with negative amounts.|  
|[do_negative_sign](#moneypunct__do_negative_sign)|A protected virtual member function that is called to return a locale-specific sequence of elements to use as a negative sign symbol.|  
|[do_pos_format](#moneypunct__do_pos_format)|A protected virtual member function that is called to return a locale-specific rule for formatting outputs with positive amounts.|  
|[do_positive_sign](#moneypunct__do_positive_sign)|A protected virtual member function that is called to return a locale-specific sequence of elements to use as a positive sign symbol.|  
|[do_thousands_sep](#moneypunct__do_thousands_sep)|A protected virtual member function that is called to return a locale-specific sequence of elements to use as a thousands separator symbol.|  
|[frac_digits](#moneypunct__frac_digits)|Returns a locale-specific count of the number of digits to display to the right of any decimal point.|  
|[grouping](#moneypunct__grouping)|Returns a locale-specific rule for determining how digits are grouped to the left of any decimal point.|  
|[neg_format](#moneypunct__neg_format)|Returns a locale-specific rule for formatting outputs with negative amounts.|  
|[negative_sign](#moneypunct__negative_sign)|Returns a locale-specific sequence of elements to use as a negative sign symbol.|  
|[pos_format](#moneypunct__pos_format)|Returns a locale-specific rule for formatting outputs with positive amounts.|  
|[positive_sign](#moneypunct__positive_sign)|Returns a locale-specific sequence of elements to use as a positive sign symbol.|  
|[thousands_sep](#moneypunct__thousands_sep)|Returns a locale-specific sequence of elements to use as a thousands separator symbol.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="moneypunct__char_type">\</a>  moneypunct::char_type  
 A type that is used to describe a character used by a locale.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
##  \<a name="moneypunct__curr_symbol">\</a>  moneypunct::curr_symbol  
 Returns a locale-specific sequence of elements to use as a currency symbol.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A string containing the currency symbol.  
  
### Remarks  
 The member function returns [do_curr_symbol](#moneypunct__do_curr_symbol).  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="moneypunct__decimal_point">\</a>  moneypunct::decimal_point  
 Returns a locale-specific sequence of elements to use as a decimal point symbol.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific sequence of elements to use as a decimal point symbol.  
  
### Remarks  
 The member function returns [do_decimal_point](#moneypunct__do_decimal_point).  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **German_Germany.1252 international decimal point ,**  
**German_Germany.1252 domestic decimal point ,**    
##  \<a name="moneypunct__do_curr_symbol">\</a>  moneypunct::do_curr_symbol  
 A protected virtual member function that returns a locale-specific sequence of elements to use as a currency symbol.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific sequence of elements to use as a decimal point symbol.  
  
### Example  
  See the example for [curr_symbol](#moneypunct__curr_symbol), where the virtual member function is called by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
##  \<a name="moneypunct__do_decimal_point">\</a>  moneypunct::do_decimal_point  
 A protected virtual member function that returns a locale-specific sequence of elements to use as a decimal point symbol.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific sequence of elements to use as a decimal point symbol.  
  
### Example  
  See the example for [decimal_point](#moneypunct__decimal_point), where the virtual member function is called by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
##  \<a name="moneypunct__do_frac_digits">\</a>  moneypunct::do_frac_digits  
 A protected virtual member function that returns a locale-specific count of the number of digits to display to the right of any decimal point.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific count of the number of digits to display to the right of any decimal point.  
  
### Example  
  See the example for [frac_digits](#moneypunct__frac_digits), where the virtual member function is called by <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
##  \<a name="moneypunct__do_grouping">\</a>  moneypunct::do_grouping  
 A protected virtual member function that returns a locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
### Example  
  See the example for [grouping](#moneypunct__grouping), where the virtual member function is called by **grouping**.  
  
##  \<a name="moneypunct__do_neg_format">\</a>  moneypunct::do_neg_format  
 A protected virtual member function that is called to return a locale-specific rule for formatting outputs with negative amounts.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The protected virtual member function returns a locale-specific rule for determining how to generate a monetary output field for a negative amount. Each of the four elements of **pattern::field** can have the values:  
  
-   **none** to match zero or more spaces or generate nothing.  
  
-   **sign** to match or generate a positive or negative sign.  
  
-   **space** to match zero or more spaces or generate a space.  
  
-   **symbol** to match or generate a currency symbol.  
  
-   **value** to match or generate a monetary value.  
  
 Components of a monetary output field are generated and components of a monetary input field are matched in the order in which these elements appear in **pattern::field**. Each of the values **sign**, **symbol**, **value**, and either **none** or **space** must appear exactly once. The value **none** must not appear first. The value space **must** not appear first or last. If **Intl** is true, the order is **symbol**, **sign**, **none**, then **value**.  
  
 The template version of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>\< **CharType**, **Intl**> returns <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>**money_base::symbol**, **money_base::sign**, **money_base::value**, **money_base::none**<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [neg_format](#moneypunct__neg_format), where the virtual member function is called by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
##  \<a name="moneypunct__do_negative_sign">\</a>  moneypunct::do_negative_sign  
 A protected virtual member function that is called to return a locale-specific sequence of elements to use as a negative sign symbol.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific sequence of elements to use as a negative sign.  
  
### Example  
  See the example for [negative_sign](#moneypunct__negative_sign), where the virtual member function is called by <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
##  \<a name="moneypunct__do_pos_format">\</a>  moneypunct::do_pos_format  
 A protected virtual member function that is called to return a locale-specific rule for formatting outputs with positive amounts.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The protected virtual member function returns a locale-specific rule for determining how to generate a monetary output field for a positive amount. (It also determines how to match the components of a monetary input field.) The encoding is the same as for [do_neg_format](#moneypunct__do_neg_format).  
  
 The template version of moneypunct\< **CharType**, **Inputlterator**> returns <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>**money_base::symbol**, **money_base::sign**, **money_base::value**, **money_base::none**<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [pos_format](#moneypunct__pos_format), where the virtual member function is called by <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
##  \<a name="moneypunct__do_positive_sign">\</a>  moneypunct::do_positive_sign  
 A protected virtual member function that returns a locale-specific sequence of elements to use as a positive sign.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific sequence of elements to use as a positive sign.  
  
### Example  
  See the example for [positive_sign](#moneypunct__positive_sign), where the virtual member function is called by <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
##  \<a name="moneypunct__do_thousands_sep">\</a>  moneypunct::do_thousands_sep  
 A protected virtual member function that returns a locale-specific element to use as a group separator to the left of any decimal point.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific element to use as a group separator to the left of any decimal point.  
  
### Example  
  See the example for [thousands_sep](#moneypunct__thousands_sep), where the virtual member function is called by <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
##  \<a name="moneypunct__frac_digits">\</a>  moneypunct::frac_digits  
 Returns a locale-specific count of the number of digits to display to the right of any decimal point.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific count of the number of digits to display to the right of any decimal point.  
  
### Remarks  
 The member function returns [do_frac_digits](#moneypunct__do_frac_digits).  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **German_Germany.1252 international grouping:**  
 **the 0th group to the left of the radix character is of size 3**  
**German_Germany.1252 international frac_digits**  
 **to the right of the radix character: 2**  
**German_Germany.1252 domestic grouping:**  
 **the 0th group to the left of the radix character is of size 3**  
**German_Germany.1252 domestic frac_digits**  
 **to the right of the radix character: 2**    
##  \<a name="moneypunct__grouping">\</a>  moneypunct::grouping  
 Returns a locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
### Remarks  
 The member function returns [do_grouping](#moneypunct__do_grouping).  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **German_Germany.1252 international grouping:**  
 **the 0th group to the left of the radix character is of size 3**  
**German_Germany.1252 international frac_digits**  
 **to the right of the radix character: 2**  
**German_Germany.1252 domestic grouping:**  
 **the 0th group to the left of the radix character is of size 3**  
**German_Germany.1252 domestic frac_digits**  
 **to the right of the radix character: 2**    
##  \<a name="moneypunct__moneypunct">\</a>  moneypunct::moneypunct  
 Constructor of objects of type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
### Remarks  
 The possible values for the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with [locale::facet](../vs140/locale-class.md#facet_class)(_                        *Refs*).  
  
##  \<a name="moneypunct__neg_format">\</a>  moneypunct::neg_format  
 Returns a locale-specific rule for formatting outputs with negative amounts.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific rule for formatting outputs with negative amounts.  
  
### Remarks  
 The member function returns [do_neg_format](#moneypunct__do_neg_format).  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="moneypunct__negative_sign">\</a>  moneypunct::negative_sign  
 Returns a locale-specific sequence of elements to use as a negative sign symbol.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Returns a locale-specific sequence of elements to use as a negative sign symbol.  
  
### Remarks  
 The member function returns [do_negative_sign](#moneypunct__do_negative_sign).  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  **German_Germany.1252 international negative sign: -**  
**German_Germany.1252 domestic negative sign: -**  
**French_France.1252 international negative sign: -**  
**French_France.1252 domestic negative sign: -**    
##  \<a name="moneypunct__pos_format">\</a>  moneypunct::pos_format  
 Returns a locale-specific rule for formatting outputs with positive amounts.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific rule for formatting outputs with positive amounts.  
  
### Remarks  
 The member function returns [do_pos_format](#moneypunct__do_pos_format).  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
##  \<a name="moneypunct__positive_sign">\</a>  moneypunct::positive_sign  
 Returns a locale-specific sequence of elements to use as a positive sign symbol.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific sequence of elements to use as a positive sign symbol.  
  
### Remarks  
 The member function returns [do_positive_sign](#moneypunct__do_positive_sign).  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  **German_Germany.1252 international positive sign:**  
**German_Germany.1252 domestic positive sign:**  
**French_France.1252 international positive sign:**  
**French_France.1252 domestic positive sign:**    
##  \<a name="moneypunct__string_type">\</a>  moneypunct::string_type  
 A type that describes a string containing characters of type **CharType**.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Remarks  
 The type describes a specialization of template class [basic_string](../vs140/basic_string-class.md) whose objects can store copies of the punctuation sequences.  
  
##  \<a name="moneypunct__thousands_sep">\</a>  moneypunct::thousands_sep  
 Returns a locale-specific sequence of elements to use as a thousands separator symbol.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A locale-specific sequence of elements to use as a thousands separator  
  
### Remarks  
 The member function returns [do_thousands_sep](#moneypunct__do_thousands_sep).  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **German_Germany.1252 international thousands separator: .**  
**German_Germany.1252 domestic thousands separator: .**  
**English_Canada.1252 international thousands separator: ,**  
**English_Canada.1252 domestic thousands separator: ,**    
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)