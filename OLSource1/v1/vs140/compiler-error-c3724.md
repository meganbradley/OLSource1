---
title: "Compiler Error C3724"
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
  - "C3724"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3724"
ms.assetid: cab8aba7-14fc-406f-8cc6-32744c8f31c1
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3724
must #include \<windows.h> to use multi-threading with events  
  
 The windows.h file is required if you use multi-threading with events. To fix this error, add <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to the top of the file in which event sources and event receivers are defined.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>