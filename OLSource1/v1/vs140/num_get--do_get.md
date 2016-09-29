---
title: "num_get::do_get"
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
  - "std.num_get.do_get"
  - "std::num_get::do_get"
  - "xlocnum/std::num_get::do_get"
  - "do_get"
  - "num_get::do_get"
  - "num_get.do_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get method"
ms.assetid: 85a43224-c761-4f2b-ba78-bd7f1d56458a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# num_get::do_get
A virtual function that is called to extracts a numerical or Boolean value from a character sequence.  
  
## Syntax  
  
```  
virtual iter_type do_get(  
    iter_type _First,  
    iter_type _Last,  
    ios_base& _Iosbase,  
    ios_base::iostate& _State,  
    long& _Val  
) const;virtual iter_type do_get(  
    iter_type _First,  
    iter_type _Last,  
    ios_base& _Iosbase,  
    ios_base::iostate& _State,  
    unsigned short& _Val  
) const;  
virtual iter_type do_get(  
    iter_type _First,  
    iter_type _Last,  
    ios_base& _Iosbase,  
    ios_base::iostate& _State,  
    unsigned int& _Val  
) const;  
virtual iter_type do_get(  
    iter_type _First,  
    iter_type _Last,  
    ios_base& _Iosbase,  
    ios_base::iostate& _State,  
    unsigned long& _Val  
) const;  
virtual iter_type do_get(  
    iter_type _First,   
    iter_type _Last,  
    ios_base& _Iosbase,   
    ios_base::iostate& _State,  
    long long& _Val  
) const;  
virtual iter_type do_get(  
    iter_type _First,   
    iter_type _Last,  
    ios_base& _Iosbase,   
    ios_base::iostate& _State,  
    unsigned long long& _Val  
) const;  
virtual iter_type do_get(  
    iter_type _First,  
    iter_type _Last,  
    ios_base& _Iosbase,  
    ios_base::iostate& _State,  
    float& _Val  
) const;  
virtual iter_type do_get(  
    iter_type _First,  
    iter_type _Last,  
    ios_base& _Iosbase,  
    ios_base::iostate& _State,  
    double& _Val  
) const;  
virtual iter_type do_get(  
    iter_type _First,  
    iter_type _Last,  
    ios_base& _Iosbase,  
    ios_base::iostate& _State,  
    long double& _Val  
) const;  
virtual iter_type do_get(  
    iter_type _First,  
    iter_type _Last,  
    ios_base& _Iosbase,  
    ios_base::iostate& _State,  
    void *& _Val  
) const;  
virtual iter_type do_get(  
    iter_type _First,  
    iter_type _Last,  
    ios_base& _Iosbase,  
    ios_base::iostate& _State,  
    bool& _Val  
) const;  
```  
  
#### Parameters  
 `_First`  
 The beginning of the range of characters from which to read the number.  
  
 `_Last`  
 The end of the range of characters from which to read the number.  
  
 `_Iosbase`  
 The [ios_base](../vs140/ios_base-class.md) whose flags are used by the conversion.  
  
 `_State`  
 The state to which failbit (see [ios_base::iostate](../vs140/ios_base--iostate.md)) is added upon failure.  
  
 `_Val`  
 The value that was read.  
  
## Return Value  
 The iterator after the value has been read.  
  
## Remarks  
 The first virtual protected member function,  
  
 `virtual iter_type do_get(`  
  
 `iter_type _First,`  
  
 `iter_type _Last,`  
  
 `ios_base& _Iosbase,`  
  
 `ios_base::iostate& _State,`  
  
 `long& _Val`  
  
 `) const;`  
  
 matches sequential elements beginning at `_First` in the sequence `[``_First``,` `_Last``)` until it has recognized a complete, nonempty integer input field. If successful, it converts this field to its equivalent value as type `long``,` and stores the result in `_Val`. It returns an iterator designating the first element beyond the numeric input field. Otherwise, the function stores nothing in `_Val` and sets `ios_base::failbit` in `state`. It returns an iterator designating the first element beyond any prefix of a valid integer input field. In either case, if the return value equals `last`, the function sets `ios_base::eofbit` in `state`.  
  
 The integer input field is converted by the same rules used by the scan functions for matching and converting a series of `char` elements from a file. (Each such `char` element is assumed to map to an equivalent element of type `Elem` by a simple, one-to-one, mapping.) The equivalent scan conversion specification is determined as follows:  
  
 If `iosbase.`[flags](../vs140/ios_base--flags.md)`() & ios_base::basefield == ios_base::`[oct](../vs140/oct---ios--.md), the conversion specification is `lo`.  
  
 If `iosbase.flags() & ios_base::basefield == ios_base::`[hex](../vs140/hex.md), the conversion specification is `lx`.  
  
 If `iosbase.flags() & ios_base::basefield == 0`, the conversion specification is `li`.  
  
 Otherwise, the conversion specification is `ld`.  
  
 The format of an integer input field is further determined by the [locale facet](../vs140/facet-class.md)`fac` returned by the call [use_facet](../vs140/use_facet.md) `<`[numpunct](../vs140/numpunct-class.md)`<Elem>(iosbase.` [getloc](../vs140/ios_base--getloc.md)`())`. Specifically:  
  
 `fac.` [grouping](../vs140/numpunct--grouping.md) `()` determines how digits are grouped to the left of any decimal point  
  
 `fac.` [thousands_sep](../vs140/numpunct--thousands_sep.md) `()` determines the sequence that separates groups of digits to the left of any decimal point.  
  
 If no instances of `fac.thousands_sep()` occur in the numeric input field, no grouping constraint is imposed. Otherwise, any grouping constraints imposed by `fac.grouping()` are enforced and separators are removed before the scan conversion occurs.  
  
 The fourth virtual protected member function:  
  
 `virtual iter_type do_get(`  
  
 `iter_type _First,`  
  
 `iter_type _Last,`  
  
 `ios_base& _Iosbase,`  
  
 `ios_base::iostate& _State,`  
  
 `unsigned long& _Val`  
  
 `) const;`  
  
 behaves the same as the first, except that it replaces a conversion specification of `ld` with `lu`. If successful it converts the numeric input field to a value of type `unsigned long` and stores that value in `_Val`.  
  
 The fifth virtual protected member function:  
  
 `virtual iter_type do_get(`  
  
 `iter_type _First,`  
  
 `iter_type _Last,`  
  
 `ios_base& _Iosbase,`  
  
 `ios_base::iostate& _State,`  
  
 `long long& _Val`  
  
 `) const;`  
  
 behaves the same as the first, except that it replaces a conversion specification of `ld` with `lld`. If successful it converts the numeric input field to a value of type `long long` and stores that value in `_Val`.  
  
 The sixth virtual protected member function:  
  
 `virtual iter_type do_get(`  
  
 `iter_type _First,`  
  
 `iter_type _Last,`  
  
 `ios_base& _Iosbase,`  
  
 `ios_base::iostate& _State,`  
  
 `unsigned long long& _Val`  
  
 `) const;`  
  
 behaves the same as the first, except that it replaces a conversion specification of `ld` with `llu`. If successful it converts the numeric input field to a value of type `unsigned long long` and stores that value in `_Val`.  
  
 The seventh virtual protected member function:  
  
 `virtual iter_type do_get(`  
  
 `iter_type _First,`  
  
 `iter_type _Last,`  
  
 `ios_base& _Iosbase,`  
  
 `ios_base::iostate& _State,`  
  
 `float& _Val`  
  
 `) const;`  
  
 behaves the same as the first, except that it endeavors to match a complete, nonempty floating-point input field. `fac.`[decimal_point](../vs140/numpunct--decimal_point.md)`()` determines the sequence that separates the integer digits from the fraction digits. The equivalent scan conversion specifier is `lf`.  
  
 The eighth virtual protected member function:  
  
 `virtual iter_type do_get(`  
  
 `iter_type _First,`  
  
 `iter_type _Last,`  
  
 `ios_base& _Iosbase,`  
  
 `ios_base::iostate& _State,`  
  
 `double& _Val`  
  
 `) const;`  
  
 behaves the same as the first, except that it endeavors to match a complete, nonempty floating-point input field. `fac.`[decimal_point](../vs140/numpunct--decimal_point.md)`()` determines the sequence that separates the integer digits from the fraction digits. The equivalent scan conversion specifier is `lf`.  
  
 The ninth virtual protected member function:  
  
 `virtual iter_type do_get(`  
  
 `iter_type _First,`  
  
 `iter_type _Last,`  
  
 `ios_base& _Iosbase,`  
  
 `ios_base::iostate& _State,`  
  
 `long double& _Val`  
  
 `) const;`  
  
 behaves the same as the eighth, except that the equivalent scan conversion specifier is `Lf`.  
  
 The ninth virtual protected member function:  
  
 `virtual iter_type do_get(`  
  
 `iter_type _First,`  
  
 `iter_type _Last,`  
  
 `ios_base& _Iosbase,`  
  
 `ios_base::iostate& _State,`  
  
 `void *& _Val`  
  
 `) const;`  
  
 behaves the same the first, except that the equivalent scan conversion specifier is `p`.  
  
 The last (eleventh) virtual protected member function:  
  
 `virtual iter_type do_get(`  
  
 `iter_type _First,`  
  
 `iter_type _Last,`  
  
 `ios_base& _Iosbase,`  
  
 `ios_base::iostate& _State,`  
  
 `bool& _Val`  
  
 `) const;`  
  
 behaves the same as the first, except that it endeavors to match a complete, nonempty Boolean input field. If successful it converts the Boolean input field to a value of type `bool` and stores that value in `_Val`.  
  
 A Boolean input field takes one of two forms. If `iosbase.flags() & ios_base::`[boolalpha](../vs140/boolalpha.md) is false, it is the same as an integer input field, except that the converted value must be either 0 (for false) or 1 (for true). Otherwise, the sequence must match either `fac.`[falsename](../vs140/numpunct--falsename.md)`()` (for false), or `fac.`[truename](../vs140/numpunct--truename.md)`()` (for true).  
  
## Example  
 See the example for [get](../vs140/num_get--get.md), where the virtual member function is called by `do_get`.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [num_get Class](../vs140/num_get-class.md)