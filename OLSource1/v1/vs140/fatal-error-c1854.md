---
title: "Fatal Error C1854"
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
  - "C1854"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1854"
ms.assetid: 8c21a9cc-1737-475c-9e57-8725cd8937c1
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1854
cannot overwrite information formed during creation of the precompiled header in object file: 'filename'  
  
 You specified the **/Yu** (use precompiled header) option after specifying the **/Yc** (create precompiled header) option for the same file. Certain declarations (such as declarations including <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) make this invalid.