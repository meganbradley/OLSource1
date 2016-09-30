---
title: "moneypunct::thousands_sep"
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
  - "moneypunct::thousands_sep"
  - "std.moneypunct.thousands_sep"
  - "locale/std::moneypunct::thousands_sep"
  - "std::moneypunct::thousands_sep"
  - "thousands_sep"
  - "moneypunct.thousands_sep"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "thousands_sep method"
ms.assetid: e2527cae-012f-4b5a-a636-bed6705c15f4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::thousands_sep
Returns a locale-specific sequence of elements to use as a thousands separator symbol.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A locale-specific sequence of elements to use as a thousands separator  
  
## Remarks  
 The member function returns [do_thousands_sep](../vs140/moneypunct--do_thousands_sep.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **German_Germany.1252 international thousands separator: .**  
**German_Germany.1252 domestic thousands separator: .**  
**English_Canada.1252 international thousands separator: ,**  
**English_Canada.1252 domestic thousands separator: ,**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)