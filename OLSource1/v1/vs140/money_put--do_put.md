---
title: "money_put::do_put"
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
  - "xlocmon/std::money_put::do_put"
  - "std::money_put::do_put"
  - "std.money_put.do_put"
  - "money_put.do_put"
  - "money_put::do_put"
  - "do_put"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_put method"
ms.assetid: 40019196-c05f-4520-9cec-6dc2a1e3cc79
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# money_put::do_put
A virtual function called to convert either number or a string to a character sequence that represents a monetary value.  
  
## Syntax  
  
```  
virtual iter_type do_put(  
    iter_type _Next,   
    bool _Intl,   
    ios_base& _Iosbase,  
    CharType _Fill,   
    const string_type& _Val  
) const;  
virtual iter_type do_put(  
    iter_type _Next,   
    bool _Intl,   
    ios_base& _Iosbase,  
    CharType _Fill,  
    long double _Val  
) const;  
```  
  
#### Parameters  
 `_Next`  
 An iterator addressing the first element of the inserted string.  
  
 `_Intl`  
 A Boolean value indicating the type of currency symbol expected in the sequence: **true** if international, **false** if domestic.  
  
 `_Iosbase`  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required  
  
 `_Fill`  
 A character which is used for spacing.  
  
 `_Val`  
 A string object to be converted.  
  
## Return Value  
 An output iterator the addresses the position one beyond the last element produced.  
  
## Remarks  
 The first virtual protected member function generates sequential elements beginning at `_Next` to produce a monetary output field from the [string_type](../vs140/money_put--string_type.md) object `_Val`. The sequence controlled by `_Val` must begin with one or more decimal digits, optionally preceded by a minus sign (–), which represents the amount. The function returns an iterator designating the first element beyond the generated monetary output field.  
  
 The second virtual protected member function behaves the same as the first, except that it effectively first converts `_Val` to a sequence of decimal digits, optionally preceded by a minus sign, then converts that sequence as above.  
  
 The format of a monetary output field is determined by the [locale facet](../vs140/facet-class.md) fac returned by the (effective) call [use_facet](../vs140/use_facet.md) <[moneypunct](../vs140/moneypunct-class.md)\<**CharType**, **intl**> >(**iosbase**.[getloc](../vs140/ios_base--getloc.md)).  
  
 Specifically:  
  
-   **fac**.[pos_format](../vs140/moneypunct--pos_format.md) determines the order in which components of the field are generated for a nonnegative value.  
  
-   **fac**.[neg_format](../vs140/moneypunct--neg_format.md) determines the order in which components of the field are generated for a negative value.  
  
-   **fac**.[curr_symbol](../vs140/moneypunct--curr_symbol.md) determines the sequence of elements to generate for a currency symbol.  
  
-   **fac**.[positive_sign](../vs140/moneypunct--positive_sign.md) determines the sequence of elements to generate for a positive sign.  
  
-   **fac**.[negative_sign](../vs140/moneypunct--negative_sign.md) determines the sequence of elements to generate for a negative sign.  
  
-   **fac**.[grouping](../vs140/moneypunct--grouping.md) determines how digits are grouped to the left of any decimal point.  
  
-   **fac**.[thousands_sep](../vs140/moneypunct--thousands_sep.md) determines the element that separates groups of digits to the left of any decimal point.  
  
-   **fac**.[decimal_point](../vs140/moneypunct--decimal_point.md) determines the element that separates the integer digits from any fraction digits.  
  
-   **fac**.[frac_digits](../vs140/moneypunct--frac_digits.md) determines the number of significant fraction digits to the right of any decimal point.  
  
 If the sign string (**fac**.`negative_sign` or **fac**.`positive_sign`) has more than one element, only the first element is generated where the element equal to **money_base::sign** appears in the format pattern (**fac**.`neg_format` or **fac**.`pos_format`). Any remaining elements are generated at the end of the monetary output field.  
  
 If **iosbase**.[flags](../vs140/ios_base--flags.md) & [showbase](../vs140/showbase.md) is nonzero, the string **fac**.`curr_symbol` is generated where the element equal to **money_base::symbol** appears in the format pattern. Otherwise, no currency symbol is generated.  
  
 If no grouping constraints are imposed by **fac**.**grouping** (its first element has the value CHAR_MAX), then no instances of **fac**.`thousands_sep` are generated in the value portion of the monetary output field (where the element equal to **money_base::value** appears in the format pattern). If **fac**.`frac_digits` is zero, then no instance of **fac**.`decimal_point` is generated after the decimal digits. Otherwise, the resulting monetary output field places the low-order **fac**.`frac_digits` decimal digits to the right of the decimal point.  
  
 Padding occurs as for any numeric output field, except that if **iosbase**.**flags** & **iosbase**.[internal](../vs140/internal--standard-c---library-.md) is nonzero, any internal padding is generated where the element equal to **money_base::space** appears in the format pattern, if it does appear. Otherwise, internal padding occurs before the generated sequence. The padding character is **fill**.  
  
 The function calls **iosbase**.**width**(0) to reset the field width to zero.  
  
## Example  
 See the example for [put](../vs140/money_put--put.md), where the virtual member function is called by **put**.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [money_put Class](../vs140/money_put-class.md)