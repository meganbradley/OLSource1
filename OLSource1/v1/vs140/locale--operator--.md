---
title: "locale::operator()"
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
  - "operator()"
  - "locale::operator()"
  - "std::locale::operator()"
  - "xlocale/std::locale::operator()"
  - "std.locale.operator()"
  - "locale.operator()"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator()"
  - "() operator"
ms.assetid: c6e6065e-10ab-4772-99e4-e7566192d063
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::operator()
Compares two <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The left string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The right string.  
  
## Return Value  
 The member function returns:  
  
-   –1 if the first sequence compares less than the second sequence.  
  
-   +1 if the second sequence compares less than the first sequence.  
  
-   0 if the sequences are equivalent.  
  
## Remarks  
 The member function effectively executes:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Thus, you can use a locale object as a function object.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **0**  
**0**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)