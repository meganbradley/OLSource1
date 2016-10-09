---
title: "How to: Validate File Names and Paths in Visual Basic"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "file names, validating"
  - "strings [Visual Basic], validating"
  - "Boolean values"
  - "paths, validating"
ms.assetid: f673462d-57b7-4120-b13a-6a7592f7ab2c
caps.latest.revision: 7
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Validate File Names and Paths in Visual Basic
This example returns a `Boolean` value that indicates whether a string represents a file name or path. The validation checks if the name contains characters that are not allowed by the file system.  
  
## Example  
 [!code[VbVbcnRegEx#4](../VS_visualbasic/codesnippet/VisualBasic/how-to--validate-file-names-and-paths-in-visual-basic_1.vb)]  
  
 This example does not check if the name has incorrectly placed colons, or directories with no name, or if the length of the name exceeds the system-defined maximum length. It also does not check if the application has permission to access the file-system resource with the specified name.  
  
## See Also  
 \<xref:System.IO.Path.GetInvalidPathChars*>   
 [Validating Strings in Visual Basic](../VS_visualbasic/validating-strings-in-visual-basic.md)