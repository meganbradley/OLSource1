---
title: "Compiler Error CS2021"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS2021
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS2021
ms.assetid: 8379d77e-6586-4e43-9aab-7cdf3ffecf51
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS2021
File name 'file' is too long or invalid  
  
 All file names passed to the C# compiler must be no longer than `_MAX_PATH` (defined in a Windows header file). the compiler will give this error in the following situations:  
  
-   A file name (including the path) is longer than `_MAX_PATH`.  
  
-   The file name contains invalid characters.  
  
-   The file name contains wildcards where wildcards are not allowed (such as in resource file names).