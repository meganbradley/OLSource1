---
title: "money_get::do_get"
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
  - "money_get::do_get"
  - "std::money_get::do_get"
  - "xlocmon/std::money_get::do_get"
  - "do_get"
  - "std.money_get.do_get"
  - "money_get.do_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get method"
ms.assetid: 1a51082b-c889-4be6-b0ec-66abdbc874e2
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# money_get::do_get
Virtual function called to extracts a numerical value from a character sequence that represents a monetary value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean value indicating the type of currency symbol expected in the sequence: **true** if international, **false** if domestic.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded or not.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A string storing the converted sequence.  
  
## Return Value  
 An input iterator addressing the first element beyond the monetary input field.  
  
## Remarks  
 The first virtual protected member function tries to match sequential elements beginning at first in the sequence [<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) until it has recognized a complete, nonempty monetary input field. If successful, it converts this field to a sequence of one or more decimal digits, optionally preceded by a minus sign (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>), to represent the amount and stores the result in the [string_type](../vs140/money_get--string_type.md) object <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. It returns an iterator designating the first element beyond the monetary input field. Otherwise, the function stores an empty sequence in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. It returns an iterator designating the first element beyond any prefix of a valid monetary input field. In either case, if the return value equals <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the function sets <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The second virtual protected member function behaves the same as the first, except that if successful it converts the optionally signed digit sequence to a value of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The format of a monetary input field is determined by the [locale facet](../vs140/facet-class.md) **fac** returned by the effective call [use_facet](../vs140/use_facet.md) <[moneypunct](../vs140/moneypunct-class.md)\<**CharType**, **intl**>>(**iosbase**.[getloc](../vs140/ios_base--getloc.md)).  
  
 Specifically:  
  
-   **fac**.[neg_format](../vs140/moneypunct--neg_format.md) determines the order in which components of the field occur.  
  
-   **fac**.[curr_symbol](../vs140/moneypunct--curr_symbol.md) determines the sequence of elements that constitutes a currency symbol.  
  
-   **fac**.[positive_sign](../vs140/moneypunct--positive_sign.md) determines the sequence of elements that constitutes a positive sign.  
  
-   **fac**.[negative_sign](../vs140/moneypunct--negative_sign.md) determines the sequence of elements that constitutes a negative sign.  
  
-   **fac**.[grouping](../vs140/moneypunct--grouping.md) determines how digits are grouped to the left of any decimal point.  
  
-   **fac**.[thousands_sep](../vs140/moneypunct--thousands_sep.md) determines the element that separates groups of digits to the left of any decimal point.  
  
-   **fac**.[decimal_point](../vs140/moneypunct--decimal_point.md) determines the element that separates the integer digits from the fraction digits.  
  
-   **fac**.[frac_digits](../vs140/moneypunct--frac_digits.md) determines the number of significant fraction digits to the right of any decimal point. When parsing a monetary amount with more fraction digits than are called for by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> stops parsing after consuming at most <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> characters.  
  
 If the sign string (**fac**.<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or **fac**.<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>) has more than one element, only the first element is matched where the element equal to **money_base::sign** appears in the format pattern (**fac**.<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>). Any remaining elements are matched at the end of the monetary input field. If neither string has a first element that matches the next element in the monetary input field, the sign string is taken as empty and the sign is positive.  
  
 If **iosbase**.[flags](../vs140/ios_base--flags.md) &[showbase](../vs140/showbase.md) is nonzero, the string **fac**.<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> must match where the element equal to **money_base::symbol** appears in the format pattern. Otherwise, if **money_base::symbol** occurs at the end of the format pattern, and if no elements of the sign string remain to be matched, the currency symbol is not matched. Otherwise, the currency symbol is optionally matched.  
  
 If no instances of **fac**.<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> occur in the value portion of the monetary input field (where the element equal to **money_base::value** appears in the format pattern), no grouping constraint is imposed. Otherwise, any grouping constraints imposed by **fac**.**grouping** is enforced. Note that the resulting digit sequence represents an integer whose low-order **fac**.<CodeContentPlaceHolder>27\</CodeContentPlaceHolder> decimal digits are considered to the right of the decimal point.  
  
 Arbitrary white space is matched where the element equal to **money_base::space** appears in the format pattern, if it appears other than at the end of the format pattern. Otherwise, no internal white space is matched. An element *ch* is considered white space if [use_facet](../vs140/use_facet.md) <[ctype](../vs140/ctype-class.md)\<**CharType**> >(**iosbase**.[getloc](../vs140/ios_base--getloc.md)).[is](../vs140/ctype--is.md)(**ctype_base::space**, *ch*) is **true**.  
  
## Example  
 See the example for [get](../vs140/money_get--get.md), which calls <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [money_get Class](../vs140/money_get-class.md)