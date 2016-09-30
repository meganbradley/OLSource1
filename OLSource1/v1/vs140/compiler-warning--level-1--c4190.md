---
title: "Compiler Warning (level 1) C4190"
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
  - "C4190"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4190"
ms.assetid: a4d0ad93-a19a-4063-addd-36d605831567
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4190
'identifier1' has C-linkage specified, but returns UDT 'identifier2' which is incompatible with C  
  
 A function or pointer to function has a UDT (user-defined type, which is a class, structure, enum, union, or [__value](../vs140/__value.md) type) as return type and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> "C" linkage. This is legal if:  
  
-   All calls to this function occur from C++.  
  
-   The definition of the function is in C++.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>