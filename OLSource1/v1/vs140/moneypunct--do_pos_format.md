---
title: "moneypunct::do_pos_format"
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
  - "do_pos_format"
  - "moneypunct.do_pos_format"
  - "std::moneypunct::do_pos_format"
  - "locale/std::moneypunct::do_pos_format"
  - "moneypunct::do_pos_format"
  - "std.moneypunct.do_pos_format"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_pos_format method"
ms.assetid: 7f44a514-e29d-48cc-930f-788e2de8c933
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::do_pos_format
A protected virtual member function that is called to return a locale-specific rule for formatting outputs with positive amounts.  
  
## Syntax  
  
```  
virtual pattern do_pos_format( ) const;  
```  
  
## Return Value  
 The protected virtual member function returns a locale-specific rule for determining how to generate a monetary output field for a positive amount. (It also determines how to match the components of a monetary input field.) The encoding is the same as for [do_neg_format](../vs140/moneypunct--do_neg_format.md).  
  
 The template version of moneypunct<**CharType**, **Inputlterator**> returns `{`**money_base::symbol**, **money_base::sign**, **money_base::value**, **money_base::none**`}`.  
  
## Example  
 See the example for [pos_format](../vs140/moneypunct--pos_format.md), where the virtual member function is called by `pos_format`.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)