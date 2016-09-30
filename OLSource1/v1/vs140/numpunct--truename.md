---
title: "numpunct::truename"
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
  - "numpunct::truename"
  - "xlocnum/std::numpunct::truename"
  - "truename"
  - "std::numpunct::truename"
  - "std.numpunct.truename"
  - "numpunct.truename"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "truename method"
ms.assetid: 2a5015e8-e88f-47ca-bca5-c886d2240eba
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numpunct::truename
Returns a string to use as a text representation of the value **true**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A string to use as a text representation of the value **true**.  
  
## Remarks  
 The member function returns [do_truename](../vs140/numpunct--do_truename.md).  
  
 All locales return a string "true" to represent the value **true**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **English_United States.1252 truename true**  
**English_United States.1252 falsename false**  
**French_France.1252 truename true**  
**French_France.1252 falsename false**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [numpunct Class](../vs140/numpunct-class.md)