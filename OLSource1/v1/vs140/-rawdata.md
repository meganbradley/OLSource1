---
title: "-RAWDATA"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /RAWDATA
f1_keywords: 
  - /rawdata
dev_langs: 
  - C++
helpviewer_keywords: 
  - RAWDATA dumpbin option
  - raw data
  - -RAWDATA dumpbin option
  - /RAWDATA dumpbin option
ms.assetid: 41cba845-5e1f-415e-9fe4-604a52235983
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -RAWDATA
```  
/RAWDATA[:{1|2|4|8|NONE[,number]]  
```  
  
## Remarks  
 This option displays the raw contents of each section in the file. The arguments control the format of the display, as shown below:  
  
|Argument|Result|  
|--------------|------------|  
|1|The default. Contents are displayed in hexadecimal bytes, and also as ASCII characters if they have a printed representation.|  
|2|Contents are displayed as hexadecimal 2-byte values.|  
|4|Contents are displayed as hexadecimal 4-byte values.|  
|8|Contents are displayed as hexadecimal 8-byte values.|  
|NONE|Raw data is suppressed. This argument is useful to control the output of /ALL.|  
|*Number*|Displayed lines are set to a width that holds `number` values per line.|  
  
 Only the [/HEADERS](../vs140/-headers.md) DUMPBIN option is available for use on files produced with the [/GL](../vs140/-gl--whole-program-optimization-.md) compiler option.  
  
## See Also  
 [DUMPBIN Options](../vs140/dumpbin-options.md)