---
title: "Compiler Warning (level 1) C4965"
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
  - "C4965"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4965"
ms.assetid: 47f3f6dc-459b-4a25-9947-f394c8966cb5
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4965
implicit box of integer 0; use nullptr or explicit cast  
  
 Visual C++ features implicit boxing of value types. An instruction that resulted in a null assignment using Managed Extensions for C++ now becomes an assignment to a boxed int.  
  
 For more information, see [Implicit Boxing](../vs140/boxing---c---component-extensions-.md).  
  
## Example  
 The following sample generates C4965.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>