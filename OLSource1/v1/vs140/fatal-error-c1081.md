---
title: "Fatal Error C1081"
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
  - "C1081"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1081"
ms.assetid: e58adf17-cbe1-4955-a5c7-80622bbba249
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1081
'symbol': file name too long  
  
 The length of a file pathname exceeds <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (defined by STDLIB.h as 260 characters). Shorten the name of the file.  
  
 If you call CL.exe with a short filename, the compiler may need to generate a full pathname. For example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> may cause the compiler to generate:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>