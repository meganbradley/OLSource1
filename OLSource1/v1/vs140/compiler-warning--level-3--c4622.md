---
title: "Compiler Warning (level 3) C4622"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C4622
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4622
ms.assetid: d3c879f0-4492-4f4b-b26d-230993f3a933
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 3) C4622
Overwriting debug information formed during creation of the precompiled header in object file: 'file'  
  
 CodeView information in the specified file was lost when it was compiled with the [/Yu](../vs140/-yu--use-precompiled-header-file-.md) (Use Precompiled Headers) option.  
  
 Rename the object file (using [/Fo](../vs140/-fo--object-file-name-.md)) when creating or using the precompiled header file, and link using the new object file.