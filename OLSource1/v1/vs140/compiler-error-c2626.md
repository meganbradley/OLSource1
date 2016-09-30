---
title: "Compiler Error C2626"
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
  - "C2626"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2626"
ms.assetid: 4c283ad0-251b-4571-bc18-468b9836746f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2626
'identifier': a private or protected data member is not allowed in an anonymous struct or union  
  
 A member of an anonymous struct or union must have public access.  
  
 The following sample generates C2626:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To fix this issue, remove any private or protected tags:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>