---
title: "locale::operator!="
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
  - "std.locale.operator!="
  - "locale::operator!="
  - "locale.operator!="
  - "!="
  - "std::locale::operator!="
  - "xlocale/std::locale::operator!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator!=, locales"
  - "operator !=, locales"
ms.assetid: 21af069f-7a01-45e9-8af3-492296e62763
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::operator!=
Tests two locales for inequality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One of the locales to be tested for inequality.  
  
## Return Value  
 A Boolean value that is **true** if the locales are not copies of the same locale; **false** if the locales are copies of the same locale.  
  
## Remarks  
 Two locales are equal if they are the same locale, if one is a copy of the other, or if they have identical names.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **locales loc1 (German_Germany.1252) and**  
 **loc2 (German_Germany.1252) are equal.**  
**locales loc1 (German_Germany.1252) and**  
 **loc3 (English_United States.1252) are not equal.**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)