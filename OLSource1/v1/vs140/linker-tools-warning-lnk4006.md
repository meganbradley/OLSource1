---
title: "Linker Tools Warning LNK4006"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "LNK4006"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK4006"
ms.assetid: 3a637d17-1676-4ea6-bd8b-290137d28d3b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Warning LNK4006
symbol already defined in object; second definition ignored  
  
 The given <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, displayed in its decorated form, was multiply defined. When this warning is encountered, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> will be added twice, but only its first form will be used.  
  
 You can get this warning if you try to merge two import libs into one.  
  
 If you are rebuilding the C run-time library, you can ignore this message.  
  
### To fix by using the following possible solutions  
  
1.  The given <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> may be a packaged function, created by compiling with [/Gy](../vs140/-gy--enable-function-level-linking-.md). This symbol was included in more than one file but was changed between compilations. Recompile all files that include the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
2.  The given <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> may have been defined differently in two member objects in different libraries.  
  
3.  An absolute may have been defined twice, with a different value in each definition.  
  
4.  If the error message is received when combining libraries, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> already exists in the library being added to.