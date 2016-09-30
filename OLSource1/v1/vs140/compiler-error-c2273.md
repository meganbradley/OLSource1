---
title: "Compiler Error C2273"
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
  - "C2273"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2273"
ms.assetid: 3c682c66-97bf-4a23-a22c-d9a26a92bf95
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2273
'type' : illegal as right side of '->' operator  
  
 A type appears as the right operand of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator.  
  
 This error can be caused by trying to access a user-defined type conversion. Use the keyword <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> between -> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The following sample generates C2273:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>