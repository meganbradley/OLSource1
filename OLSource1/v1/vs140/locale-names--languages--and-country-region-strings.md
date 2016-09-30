---
title: "Locale Names, Languages, and Country-Region Strings"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Locale Names, Languages, and Country/Region Strings"
f1_keywords: 
  - "c.strings"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "country/region strings"
  - "localization, locale"
  - "locales"
  - "setlocale function"
  - "language strings"
ms.assetid: a0e5a0c5-5602-4da0-b65f-de3d6c8530a2
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Locale Names, Languages, and Country-Region Strings
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> functions can be set by using the locale names, languages, country/region codes, and code pages that are supported by the Windows NLS API. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument takes the following form:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The locale name form—for example, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for English (United States) or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for Bosnian (Cyrillic, Bosnia and Herzegovina)—is preferred. The set of locale names is described in [Locale Names](http://msdn.microsoft.com/library/windows/desktop/dd373814.aspx). For a list of supported locale names by Windows operating system version, see the **Culture Name** column of the [National Language Support (NLS) API Reference](http://msdn.microsoft.com/goglobal/bb896001.aspx). This resource lists the supported language, script, and region parts of the locale names. For information about the supported locale names that have non-default sort orders, see the **Locale name** column in [Sort Order Identifiers](http://msdn.microsoft.com/library/windows/desktop/dd374060.aspx).  
  
 The *language*[_*country_region*[.*code_page*]] form is stored in the locale setting for a category when a language string, or language string and country/region string, is used to create the locale. The set of supported language strings is described in [Language Strings](../vs140/language-strings.md), and the list of supported country/region strings is listed in [Country/Region Strings](../vs140/country-region-strings.md). If the specified language is not associated with the specified country/region, the default language for the specified country/region is stored in the locale setting. We do not recommend this form for locale strings embedded in code or serialized to storage, because these strings are more likely to be changed by an operating system update than the locale name form.  
  
 The code page is the ANSI/OEM code page that's associated with the locale. The code page is determined for you when you specify a locale by language or by language and country/region alone. The special value <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> specifies the ANSI code page for the country/region. The special value <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> specifies the OEM code page for the country/region. For example, if you specify <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as the locale, the locale is stored as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (the ANSI code page for Greek), and if you specify <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> as the locale, it is stored as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (the OEM code page for Greek). For more information about code pages, see [Code Pages](../vs140/code-pages.md). For a list of supported code pages on Windows, see [Code Page Identifiers](http://msdn.microsoft.com/library/windows/desktop/dd317756.aspx).  
  
 If you use only the code page to specify the locale, the system default language and country/region are used. For example, if you specify <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (ANSI Turkish) as the locale on a system that's configured for English (United States), the locale that's stored is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. We do not recommend this form, because it could lead to inconsistent behavior.  
  
 A <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> specifies the minimal ANSI conforming environment for C translation. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> locale assumes that every <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> data type is 1 byte and its value is always less than 256. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> points to an empty string, the locale is the implementation-defined native environment.  
  
 You can specify all of the locale categories at the same time for the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> functions by using the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> category. The categories can all be set to the same locale, or you can set each category individually by using a locale argument that has this form:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can specify multiple category types, separated by semicolons. Category types that are not specified use the current locale setting. For example, this code sets the current locale for all categories to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and then sets the categories <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>:  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
## See Also  
 [Run-Time Library Reference](../vs140/c-run-time-library-reference.md)   
 [_get_current_locale](../vs140/_get_current_locale.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [_create_locale, _wcreate_locale](../vs140/_create_locale--_wcreate_locale.md)   
 [Language Strings](../vs140/language-strings.md)   
 [Country/Region Strings](../vs140/country-region-strings.md)