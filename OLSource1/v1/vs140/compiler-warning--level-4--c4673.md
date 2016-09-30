---
title: "Compiler Warning (level 4) C4673"
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
  - "C4673"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4673"
ms.assetid: 95626ec6-f05b-43c7-8b9a-a60a6f98dd30
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4673
throwing 'identifier' the following types will not be considered at the catch site  
  
 A throw object cannot be handled in the **catch** block. Each type that cannot be handled is listed in the error output immediately following the line containing this warning. Each unhandled type has its own warning. Read the warning for each specific type for more information.  
  
 The following sample generates C4673:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>