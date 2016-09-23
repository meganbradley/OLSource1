---
title: "Bad file name or number"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbrID52
dev_langs: 
  - VB
ms.assetid: d0e96aea-7621-48f6-a78b-5d37d18aaa4e
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Bad file name or number
An error occurred while trying to access the specified file. Among the possible causes for this error are:  
  
-   A statement refers to a file with a file name or number that was not specified in the `FileOpen` statement or that was specified in a `FileOpen` statement but was subsequently closed.  
  
-   A statement refers to a file with a number that is out of the range of file numbers.  
  
-   A statement refers to a file name or number that is not valid.  
  
### To correct this error  
  
1.  Make sure the file name is specified in a `FileOpen` statement. Note that if you invoked the `FileClose` statement without arguments, you may have inadvertently closed all open files.  
  
2.  If your code is generating file numbers algorithmically, make sure the numbers are valid.  
  
3.  Check the file names to make sure they conform to operating system conventions.  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileSystem.FileOpen?qualifyHint=False>   
 [Visual Basic Naming Conventions](../vs140/visual-basic-naming-conventions.md)