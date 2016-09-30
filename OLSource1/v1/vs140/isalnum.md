---
title: "isalnum"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "locale/std::isalnum"
  - "std::isalnum"
  - "isalnum"
  - "std.isalnum"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isalnum function"
  - "isalnum"
ms.assetid: b2748009-8f89-4c03-ab62-87401677b705
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isalnum
Tests whether an element in a locale is an alphabetic or a numeric character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The alphanumeric element to be tested.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The locale containing the alphanumeric element to be tested.  
  
## Return Value  
 **true** if the element tested is alphanumeric; **false** if it is not.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The character 'L' in the locale is alphanumeric.**  
**The character '@' in the locale is  not alphanumeric.**  
**The character '3' in the locale is alphanumeric.**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std