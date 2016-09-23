---
title: "Including Quoted Filenames"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
  - C
ms.assetid: 789a047e-ea38-4c99-b71d-a2ad9c81daee
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Including Quoted Filenames
**ANSI 3.8.2** The support for quoted names for includable source files  
  
 If you specify a complete, unambiguous path specification for the include file between two sets of double quotation marks (" "), the preprocessor searches only that path specification and ignores the standard directories.  
  
 For include files specified as [#include](../vs140/sharpinclude-directive--c-c---.md) "path-spec", directory searching begins with the directories of the parent file, then proceeds through the directories of any grandparent files. Thus, searching begins relative to the directory containing the source file currently being processed. If there is no grandparent file and the file has not been found, the search continues as if the filename were enclosed in angle brackets.  
  
## See Also  
 [Preprocessing Directives](../vs140/preprocessing-directives.md)