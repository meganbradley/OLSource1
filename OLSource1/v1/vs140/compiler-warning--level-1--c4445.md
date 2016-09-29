---
title: "Compiler Warning (level 1) C4445"
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
  - "C4445"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4445"
ms.assetid: 535e92a0-ba08-4dfc-89b2-af2dcdd7caeb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4445
'function' : in a WinRT or managed type a virtual method cannot be private  
  
 If a virtual function is private, it cannot be accessed by a derived type. To fix this error, change the accessibility of the virtual member function to protected or public.