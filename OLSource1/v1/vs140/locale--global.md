---
title: "locale::global"
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
  - "global"
  - "locale::global"
  - "locale.global"
  - "xlocale/std::locale::global"
  - "std.locale.global"
  - "std::locale::global"
  - "Global"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "global method"
ms.assetid: 16e47251-a892-42d0-a6ea-ca17692e34d8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::global
Resets the default locale for the program. This affects the global locale for both C and C++.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The locale to be used as the default locale by the program.  
  
## Return Value  
 The previous locale before the default locale was reset.  
  
## Remarks  
 At program startup, the global locale is the same as the classic locale. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to establish a matching locale in the Standard C library.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial locale is: C**  
**The current locale is: German_Germany.1252**  
**The previous locale was: C**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)