---
title: "Data Type Mappings"
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
  - "_TXCHAR"
  - "_TUCHAR"
  - "_TINT"
  - "_TSCHAR"
  - "_TCHAR"
  - "TCHAR::H"
  - "TCHAR"
  - "_T"
  - "_TEXT"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_TXCHAR type"
  - "TINT type"
  - "_TCHAR type"
  - "TSCHAR type"
  - "TEXT type"
  - "TCHAR type"
  - "TCHAR.H data types, mappings defined in"
  - "generic-text data types"
  - "_TINT type"
  - "TUCHAR type"
  - "TXCHAR type"
  - "_TSCHAR type"
  - "T type"
  - "_TUCHAR type"
  - "_TEXT type"
  - "_T type"
ms.assetid: 4e573c05-8800-468b-ae5f-76ff7409835e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Type Mappings
These data-type mappings are defined in TCHAR.H and depend on whether the constant <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> has been defined in your program.  
  
 For related information, see [Using TCHAR.H Data Types with _MBCS Code](../vs140/using-tchar.h-data-types-with-_mbcs-code.md).  
  
### Generic-Text Data Type Mappings  
  
|Generic-text\<br />\<br /> data type name|SBCS (_UNICODE,\<br />\<br /> _MBCS not\<br />\<br /> defined)|_MBCS\<br />\<br /> defined|_UNICODE\<br />\<br /> defined|  
|--------------------------------------|----------------------------------------------------|------------------------|---------------------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|No effect (removed by preprocessor)|No effect (removed by preprocessor)|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> (converts following character or string to its Unicode counterpart)|  
  
## See Also  
 [Generic-Text Mappings](../vs140/generic-text-mappings.md)   
 [Constant and Global Variable Mappings](../vs140/constant-and-global-variable-mappings.md)   
 [Routine Mappings](../vs140/routine-mappings.md)   
 [A Sample Generic-Text Program](../vs140/a-sample-generic-text-program.md)   
 [Using Generic-Text Mappings](../vs140/using-generic-text-mappings.md)