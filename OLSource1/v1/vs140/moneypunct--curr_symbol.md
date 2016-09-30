---
title: "moneypunct::curr_symbol"
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
  - "moneypunct::curr_symbol"
  - "std::moneypunct::curr_symbol"
  - "curr_symbol"
  - "moneypunct.curr_symbol"
  - "std.moneypunct.curr_symbol"
  - "locale/std::moneypunct::curr_symbol"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "curr_symbol method"
ms.assetid: 99430cc1-569d-4417-bea7-4d6125b7cb59
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::curr_symbol
Returns a locale-specific sequence of elements to use as a currency symbol.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A string containing the currency symbol.  
  
## Remarks  
 The member function returns [do_curr_symbol](../vs140/moneypunct--do_curr_symbol.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
 If you run Windows 2000 or earlier, you will get this output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If you run Windows XP, you will get this output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This assumes that you have not changed the default currency settings.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)