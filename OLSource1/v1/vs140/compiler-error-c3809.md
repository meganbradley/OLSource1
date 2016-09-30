---
title: "Compiler Error C3809"
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
  - "C3809"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3809"
ms.assetid: 37eca584-c20c-464e-8e45-a987214b7ce4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3809
'class' : a managed or WinRT type cannot have any friend functions/classes/interfaces  
  
 Managed types and Windows Runtime types do not allow friends. To fix this error, do not declare friends inside managed or Windows Runtime types.  
  
 The following sample generates C3809:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>