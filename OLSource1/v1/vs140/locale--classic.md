---
title: "locale::classic"
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
  - "std.locale.classic"
  - "locale.classic"
  - "locale::classic"
  - "xlocale/std::locale::classic"
  - "std::locale::classic"
  - "classic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "classic method"
ms.assetid: 18aa3bf1-07c7-4811-a8c7-52aca145421a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::classic
The static member function returns a locale object that represents the classic C locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to the C locale.  
  
## Remarks  
 The classic C locale is the U.S. English ASCII locale within the Standard C Library that is implicitly used in programs that are not internationalized.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The name of the previous locale is: C.**  
**The name of the current locale is: German_Germany.1252.**  
**The previous locale was classic.**  
**The current locale is not classic.**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)