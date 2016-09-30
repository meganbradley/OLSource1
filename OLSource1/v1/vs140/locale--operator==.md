---
title: "locale::operator=="
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
  - "std::locale::operator=="
  - "std.locale.operator=="
  - "operator=="
  - "locale::operator=="
  - "xlocale/std::locale::operator=="
  - "=="
  - "locale.operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, locales"
  - "operator==, locale"
  - "== operator, with specific standard C++ objects"
ms.assetid: 1cf362d7-f31b-449f-b491-c92e1a66c22d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::operator==
Tests two locales for equality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One of the locales to be tested for equality.  
  
## Return Value  
 A Boolean value that is **true** if the locales are copies of the same locale; **false** if the locales are not copies of the same locale.  
  
## Remarks  
 Two locales are equal if they are the same locale, if one is a copy of the other, or if they have identical names.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **locales loc1 (German_Germany.1252)**  
 **and loc2 (German_Germany.1252) are equal.**  
**locales loc1 (German_Germany.1252)**  
 **and loc3 (English_United States.1252) are not equal.**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)