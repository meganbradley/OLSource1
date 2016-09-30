---
title: "Country-Region Strings"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Country/Region Strings"
f1_keywords: 
  - "c.strings"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "country/region strings"
ms.assetid: 5baf0ccf-0d9b-40dc-83bd-323705287930
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Country-Region Strings
Country and region strings can be combined with a language string to create a locale specification for the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions. For lists of country/region names that are supported by various Windows operating system versions, see the [National Language Support (NLS) API Reference](http://msdn.microsoft.com/goglobal/bb896001.aspx).In the lists, the country/region string can be any of the country values in the **Locale – Language Country/Region** column, or any of the abbreviations in the **Country or Region name abbreviation** column.  
  
 The C run-time library implementation also supports the following additional country/region strings and abbreviations:  
  
|Country/region string|Abbreviation|Equivalent locale name|  
|----------------------------|------------------|----------------------------|  
|america|USA|en-US|  
|britain|GBR|en-GB|  
|china|CHN|zh-CN|  
|czech|CZE|cs-CZ|  
|england|GBR|en-GB|  
|great britain|GBR|en-GB|  
|holland|NLD|nl-NL|  
|hong-kong|HKG|zh-HK|  
|new-zealand|NZL|en-NZ|  
|nz|NZL|en-NZ|  
|pr china|CHN|zh-CN|  
|pr-china|CHN|zh-CN|  
|puerto-rico|PRI|es-PR|  
|slovak|SVK|sk-SK|  
|south africa|ZAF|af-ZA|  
|south korea|KOR|ko-KR|  
|south-africa|ZAF|af-ZA|  
|south-korea|KOR|ko-KR|  
|trinidad & tobago|TTO|en-TT|  
|uk|GBR|en-GB|  
|united-kingdom|GBR|en-GB|  
|united-states|USA|en-US|  
|us|USA|en-US|  
  
## See Also  
 [Locale Names, Languages, and Country/Region Strings](../vs140/locale-names--languages--and-country-region-strings.md)   
 [Language Strings](../vs140/language-strings.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [_create_locale, _wcreate_locale](../vs140/_create_locale--_wcreate_locale.md)