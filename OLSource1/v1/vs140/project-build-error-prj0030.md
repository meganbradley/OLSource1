---
title: "Project Build Error PRJ0030"
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
  - "PRJ0030"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PRJ0030"
ms.assetid: c48b3727-e166-46e7-bcd7-3e5b2ac5c1d4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Project Build Error PRJ0030
Macro expansion error. Evaluate recursion exceeded 32 levels for $(macro).  
  
 This error is caused by recursion in your macros. For example, if you set the **Intermediate Directory** property (see [General Property Page (Project)](../vs140/general-property-page--project-.md)) to $(IntDir), you will have recursion.  
  
 To resolve this error, do not define macros or properties in terms of macros they are used to define.