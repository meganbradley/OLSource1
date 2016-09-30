---
title: "stdext Namespace"
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
  - "stdext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_DEFINE_DEPRECATED_HASH_CLASSES symbol"
  - "stdext namespace"
ms.assetid: 3e94fc89-0584-424f-bc09-081b73379545
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stdext Namespace
Members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are not currently part of the ISO C++ standard. Therefore, these types and members have been moved from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> namespace to namespace <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, to remain conformant with the C++ standard.  
  
 When compiling with [/Ze](../vs140/-za---ze--disable-language-extensions-.md), which is the default, the compiler will warn on the use of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for members of the \<hash_map> and \<hash_set> header files. To disable the warning, use the [warning](../vs140/warning.md) pragma.  
  
 To have the compiler generate an error for the use of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for members of the \<hash_map> and \<hash_set> header files with **/Ze**, add the following directive before #include'ing any Standard C++ Library header files.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When compiling with **/Za**, the compiler will generate an error.  
  
## See Also  
 [Standard C++ Library Overview](../vs140/c---standard-library-overview.md)