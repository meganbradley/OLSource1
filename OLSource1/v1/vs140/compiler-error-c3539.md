---
title: "Compiler Error C3539"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3539"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3539"
ms.assetid: 34a33a0f-d1b6-498f-b312-ffad2d4799b3
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3539
'type': a template-argument cannot be a type that contains 'auto'  
  
 The indicated template argument type cannot contain a usage of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword.  
  
### To correct this error  
  
1.  Do not specify the template argument with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword.  
  
## Example  
 The following example yields C3539.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [auto Keyword](../vs140/auto-keyword.md)