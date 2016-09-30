---
title: "Running NMAKE"
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
helpviewer_keywords: 
  - "targets, building"
  - "response files, NMAKE"
  - "targets"
  - "command files"
  - "NMAKE program, targets"
  - "NMAKE program, running"
  - "command files, NMAKE"
ms.assetid: 0421104d-8b7b-4bf3-86c1-928d9b7c1a8c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Running NMAKE
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 NMAKE builds only specified *targets* or, if none is specified, the first target in the makefile. The first makefile target can be a [pseudotarget](../vs140/pseudotargets.md) that builds other targets. NMAKE uses makefiles specified with /F; if /F is not specified, it uses the Makefile file in the current directory. If no makefile is specified, it uses inference rules to build command-line *targets*.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> text file (or response file) contains command-line input. Other input can precede or follow @<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. A path is permitted. In <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, line breaks are treated as spaces. Enclose macro definitions in quotation marks if they contain spaces.  
  
## What do you want to know more about?  
 [NMAKE options](../vs140/nmake-options.md)  
  
 [Tools.ini and NMAKE](../vs140/tools.ini-and-nmake.md)  
  
 [Exit codes from NMAKE](../vs140/exit-codes-from-nmake.md)  
  
## See Also  
 [NMAKE Reference](../vs140/nmake-reference.md)