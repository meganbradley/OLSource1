---
title: "locale::locale"
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
  - "locale::locale"
  - "std.locale.locale"
  - "locale"
  - "std::locale::locale"
  - "xlocale/std::locale::locale"
  - "locale.locale"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "locale class, constructor"
  - "locale method"
ms.assetid: 3c604e11-4100-43dd-8d2e-eb7dbd93f02c
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::locale
Creates a locale, or a copy of a locale, or a copy of locale where a facet or a category has been replaced by a facet or category from another locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Name of a locale.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A locale that is to be copied in constructing the new locale.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A locale from which to select a category.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The category to be substituted into the constructed locale.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The facet to be substituted into the constructed locale.  
  
## Remarks  
 The first constructor initializes the object to match the global locale. The second and third constructors initialize all the locale categories to have behavior consistent with the locale name <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The remaining constructors copy <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, with the exceptions noted:  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 replaces from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> those facets corresponding to a category C for which C & <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is nonzero.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 replaces from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> those facets corresponding to a category C for which C & <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>is nonzero.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 replaces in (or adds to) <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> the facet <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is not a null pointer.  
  
 If a locale name <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a null pointer or otherwise invalid, the function throws [runtime_error](../vs140/runtime_error-class.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)