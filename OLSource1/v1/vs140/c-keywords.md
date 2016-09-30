---
title: "C Keywords"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "keywords [C]"
  - "redefining keywords"
  - "Microsoft-specific keywords"
ms.assetid: 2d932335-97bf-45cd-b367-4ae00db0ff42
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Keywords
"Keywords" are words that have special meaning to the C compiler. In translation phases 7 and 8, an identifier cannot have the same spelling and case as a C keyword. (See a description of [translation phases](../vs140/phases-of-translation.md) in the *Preprocessor Reference*; for information on identifiers, see [Identifiers](../vs140/c-identifiers.md).) The C language uses the following keywords:  
  
|||||  
|-|-|-|-|  
|**auto**|**double**|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|  
|**break**|**else**|**long**|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|**case**|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|**register**|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|**union**|  
|**const**|**float**|**short**|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|**continue**|**for**|**signed**|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|**default**|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|**do**|**if**|**static**|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
  
 You cannot redefine keywords. However, you can specify text to be substituted for keywords before compilation by using C [preprocessor directives](../vs140/preprocessor-directives.md).  
  
 **Microsoft Specific**  
  
 The ANSI C standard allows identifiers with two leading underscores to be reserved for compiler implementations. Therefore, the Microsoft convention is to precede Microsoft-specific keyword names with double underscores. These words cannot be used as identifier names. For a description of the ANSI rules for naming identifiers, including the use of double underscores, see [Identifiers](../vs140/c-identifiers.md).  
  
 The following keywords and special identifiers are recognized by the Microsoft C compiler:  
  
|||||  
|-|-|-|-|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|**dllimport**2|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>2|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>1|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|**thread**2|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>2|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>||  
  
 1. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> keyword has limited uses for 32-bit and 64-bit target compilations.  
  
 2. These are special identifiers when used with <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>; their use in other contexts is not restricted.  
  
 Microsoft extensions are enabled by default. To ensure that your programs are fully portable, you can disable Microsoft extensions by specifying the /Za option (compile for ANSI compatibility) during compilation. When you do this, Microsoft-specific keywords are disabled.  
  
 When Microsoft extensions are enabled, you can use the keywords listed above in your programs. For ANSI compliance, most of these keywords are prefaced by a double underscore. The four exceptions, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, **dllimport**, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, and **thread**, are used only with <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and therefore do not require a leading double underscore. For backward compatibility, single-underscore versions of the rest of the keywords are supported.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Elements of C](../vs140/elements-of-c.md)