---
title: "Compiler Warning (level 3) C4267"
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
  - "C4267"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4267"
ms.assetid: 2fa2f13f-fa4f-47bb-ad8f-6cb19cfc91e6
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4267
'var' : conversion from 'size_t' to 'type', possible loss of data  
  
 The compiler detected a conversion from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to a smaller type.  
  
 To fix this warning, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Alternatively, use an integral type that is at least as large as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 The following example generates C4267.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>