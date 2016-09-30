---
title: "tolower"
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
  - "tolower"
  - "std::tolower"
  - "std.tolower"
  - "locale/std::tolower"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tolower"
  - "tolower function"
ms.assetid: 295960e7-8d6d-4631-8b8e-1e3fc4a9fc23
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tolower
Converts a character to lower case.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The character to be converted to lower case.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale containing the character to be converted.  
  
## Return Value  
 The character converted to lower case.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)\<**CharType**> >(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).[tolower](../vs140/ctype--tolower.md)(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std