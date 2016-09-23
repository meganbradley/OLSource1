---
title: "Bad record length"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbrID59
dev_langs: 
  - VB
ms.assetid: 0926a3a4-177b-4452-9b33-d8a01e24cc21
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Bad record length
Among the possible causes of this error are:  
  
-   The length of a record variable specified in a `FileGet`, `FileGetObject`, `FilePut` or `FilePutObject` statement differs from the length specified in the corresponding `FileOpen` statement.  
  
-   The variable in a `FilePut` or `FilePutObject` statement is or includes a variable-length string.  
  
-   The variable in a `FilePut` or `FilePutObject` is or includes a `Variant`type**.**  
  
### To correct this error  
  
1.  Make sure the sum of the sizes of fixed-length variables in the user-defined type defining the record variable's type is the same as the value stated in the `FileOpen` statement's `Len` clause.  
  
2.  If the variable in a `FilePut` or `FilePutObject` statement is or includes a variable-length string, make sure the variable-length string is at least 2 characters shorter than the record length specified in the `Len` clause of the `FileOpen` statement.  
  
3.  If the variable in a `FilePut` or `FilePutObject` is or includes a `Variant` make sure the variable-length string is at least 4 bytes shorter than the record length specified in the `Len` clause of the `FileOpen` statement.  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileSystem.FileGet?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.FileSystem.FileGetObject?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.FileSystem.FilePut?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.FileSystem.FilePutObject?qualifyHint=False>