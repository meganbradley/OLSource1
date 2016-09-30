---
title: "regex_token_iterator::reference"
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
  - "regex_token_iterator.reference"
  - "std::tr1::regex_token_iterator::reference"
  - "std.tr1.regex_token_iterator.reference"
  - "reference"
  - "regex_token_iterator::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference typedef [TR1]"
ms.assetid: f4bc9a52-a4c0-4789-bc11-8fd43a4d7cf5
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_token_iterator::reference
The type of a reference to a submatch.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the template parameter.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_token_iterator](../vs140/regex_token_iterator-class.md)