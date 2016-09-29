---
title: "&lt;locale&gt;"
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
  - "<locale>"
  - "std.<locale>"
  - "locale/std::<locale>"
  - "std::<locale>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "locale header"
ms.assetid: ca56f9d2-7128-44da-8df1-f4c78c17fbf2
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;locale&gt;
Defines template classes and functions that C++ programs can use to encapsulate and manipulate different cultural conventions regarding the representation and formatting of numeric, monetary, and calendric data, including internationalization support for character classification and string collation.  
  
## Syntax  
  
```  
#include <locale>  
  
```  
  
### Functions  
  
|||  
|-|-|  
|[has_facet](../VS_csharp/-locale--functions.md#has_facet)|Tests if a particular facet is stored in a specified locale.|  
|[isalnum](../VS_csharp/-locale--functions.md#isalnum)|Tests whether an element in a locale is an alphabetic or a numeric character.|  
|[isalpha](../VS_csharp/-locale--functions.md#isalpha)|Tests whether an element in a locale is alphabetic character.|  
|[iscntrl](../VS_csharp/-locale--functions.md#iscntrl)|Tests whether an element in a locale is a control character.|  
|[isdigit](../VS_csharp/-locale--functions.md#isdigit)|Tests whether an element in a locale is a numeric character.|  
|[isgraph](../VS_csharp/-locale--functions.md#isgraph)|Tests whether an element in a locale is an alphanumeric or punctuation character.|  
|[islower](../VS_csharp/-locale--functions.md#islower)|Tests whether an element in a locale is lower case.|  
|[isprint](../VS_csharp/-locale--functions.md#isprint)|Tests whether an element in a locale is a printable character.|  
|[ispunct](../VS_csharp/-locale--functions.md#ispunct)|Tests whether an element in a locale is a punctuation character.|  
|[isspace](../VS_csharp/-locale--functions.md#isspace)|Tests whether an element in a locale is a whitespace character.|  
|[isupper](../VS_csharp/-locale--functions.md#isupper)|Tests whether an element in a locale is upper case.|  
|[isxdigit](../VS_csharp/-locale--functions.md#isxdigit)|Tests whether an element in a locale is a character used to represent a hexadecimal number.|  
|[tolower](../VS_csharp/-locale--functions.md#tolower)|Converts a character to lower case.|  
|[toupper](../VS_csharp/-locale--functions.md#toupper)|Converts a character to upper case.|  
|[use_facet](../VS_csharp/-locale--functions.md#use_facet)|Returns a reference to a facet of a specified type stored in a locale.|  
  
### Classes  
  
|||  
|-|-|  
|[codecvt](../VS_csharp/codecvt-class.md)|A template class that provides a facet used to convert between internal and external character encodings.|  
|[codecvt_base](../VS_csharp/codecvt_base-class.md)|A base class for the codecvt class that is used to define an enumeration type referred to as **result**, used as the return type for the facet member functions to indicate the result of a conversion.|  
|[codecvt_byname](../VS_csharp/codecvt_byname-class.md)|A derived template class that describes an object that can serve as a collate facet of a given locale, enabling the retrieval of information specific to a cultural area concerning conversions.|  
|[collate](../VS_csharp/collate-class.md)|A collate template class that provides a facet that handles string sorting conventions.|  
|[collate_byname](../VS_csharp/collate_byname-class.md)|A derived template class that describes an object that can serve as a collate facet of a given locale, enabling the retrieval of information specific to a cultural area concerning string sorting conventions.|  
|[ctype](../VS_csharp/ctype-class.md)|A template class that provides a facet that is used to classify characters, convert from upper- and lowercase and between the native character set and that set used by the locale.|  
|[ctype<char\>](../VS_csharp/ctype-char--class.md)|A class that is an explicit specialization of template class **ctype<CharType**> to type `char`, describing an object that can serve as a locale facet to characterize various properties of a character of type `char`.|  
|[ctype_base](../VS_csharp/ctype_base-class.md)|A base class for the ctype class that is used to define enumeration types used to classify or test characters either individually or within entire ranges.|  
|[ctype_byname](../VS_csharp/ctype_byname-class.md)|A derived template class that describes an object that can serve as a ctype facet of a given locale, enabling the classification of characters and conversion of characters between case and native and locale specified character sets.|  
|[locale](../VS_csharp/locale-class.md)|A class that describes a locale object that encapsulates culture-specific information as a set of facets that collectively define a specific localized environment.|  
|[messages](../VS_csharp/messages-class.md)|A template class that describes an object that can serve as a locale facet to retrieve localized messages from a catalog of internationalized messages for a given locale.|  
|[messages_base](../VS_csharp/messages_base-class.md)|A base class that describes an `int` type for the catalog of messages.|  
|[messages_byname](../VS_csharp/messages_byname-class.md)|A derived template class that describes an object that can serve as a message facet of a given locale, enabling the retrieval of localized messages.|  
|[money_base](../VS_csharp/money_base-class.md)|A base class for the ctype class that is used to define enumeration types used to classify or test characters either individually or within entire ranges.|  
|[money_get](../VS_csharp/money_get-class.md)|A template class that describes an object that can serve as a locale facet to control conversions of sequences of type **CharType** to monetary values.|  
|[money_put](../VS_csharp/money_put-class.md)|A template class that describes an object that can serve as a locale facet to control conversions of monetary values to sequences of type **CharType**.|  
|[moneypunct](../VS_csharp/moneypunct-class.md)|A template class that describes an object that can serve as a locale facet to describe the sequences of type **CharType** used to represent a monetary input field or a monetary output field.|  
|[moneypunct_byname](../VS_csharp/moneypunct_byname-class.md)|A derived template class that describes an object that can serve as a moneypunct facet of a given locale enabling the formatting monetary input or output fields.|  
|[num_get](../VS_csharp/num_get-class.md)|A template class that describes an object that can serve as a locale facet to control conversions of sequences of type **CharType** to numeric values.|  
|[num_put](../VS_csharp/num_put-class.md)|A template class that describes an object that can serve as a locale facet to control conversions of numeric values to sequences of type **CharType**.|  
|[numpunct](../VS_csharp/numpunct-class.md)|A template class that describes an object that can serve as a local facet to describe the sequences of type **CharType** used to represent information about the formatting and punctuation of numeric and Boolean expressions.|  
|[numpunct_byname](../VS_csharp/numpunct_byname-class.md)|A derived template class that describes an object that can serve as a moneypunct facet of a given locale enabling the formatting and punctuation of numeric and Boolean expressions.|  
|[time_base](../VS_csharp/time_base-class.md)|A class that serves as a base class for facets of template class time_get, defining just the enumerated type dateorder and several constants of this type.|  
|[time_get](../VS_csharp/time_get-class.md)|A template class that describes an object that can serve as a locale facet to control conversions of sequences of type **CharType** to time values.|  
|[time_get_byname](../VS_csharp/time_get_byname-class.md)|A derived template class that describes an object that can serve as a locale facet of type time_get<**CharType**, **InputIterator**>.|  
|[time_put](../VS_csharp/time_put-class.md)|A template class that describes an object that can serve as a locale facet to control conversions of time values to sequences of type **CharType**.|  
|[time_put_byname](../VS_csharp/time_put_byname-class.md)|A derived template class that describes an object that can serve as a locale facet of type `time_put`<**CharType**, **OutputIterator**>.|  
|[wbuffer_convert Class](../VS_csharp/wbuffer_convert-class.md)|Describes a stream buffer that controls the transmission of elements to and from a byte stream buffer.|  
|[wstring_convert Class](../VS_csharp/wstring_convert-class.md)|A template class that performs conversions between a wide string and a byte string.|  
  
## See Also  
 [Code Pages](../VS_csharp/code-pages.md)   
 [Locale Names, Languages, and Country/Region Strings](../VS_csharp/locale-names--languages--and-country-region-strings.md)   
 [Thread Safety in the Standard C++ Library](../VS_csharp/thread-safety-in-the-c---standard-library.md)