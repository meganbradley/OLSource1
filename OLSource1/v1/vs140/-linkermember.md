---
title: "-LINKERMEMBER"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /LINKERMEMBER
f1_keywords: 
  - /linkermember
dev_langs: 
  - C++
helpviewer_keywords: 
  - /LINKERMEMBER dumpbin option
  - LINKERMEMBER dumpbin option
  - -LINKERMEMBER dumpbin option
ms.assetid: c96868c1-d70e-4651-ae36-c55b58b16406
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -LINKERMEMBER
```  
/LINKERMEMBER[:{1|2}]  
```  
  
## Remarks  
 This option displays public symbols defined in a library. Specify the 1 argument to display symbols in object order, along with their offsets. Specify the 2 argument to display offsets and index numbers of objects, and then list the symbols in alphabetical order, along with the object index for each. To get both outputs, specify /LINKERMEMBER without the number argument.  
  
 Only the [/HEADERS](../vs140/-headers.md) DUMPBIN option is available for use on files produced with the [/GL](../vs140/-gl--whole-program-optimization-.md) compiler option.  
  
## See Also  
 [DUMPBIN Options](../vs140/dumpbin-options.md)