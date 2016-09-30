---
title: "Compiler Error C2395"
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
  - "C2395"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2395"
ms.assetid: 2d9e3b28-8c2c-4f41-a57f-61ef88fc2af0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2395
'your_type::operator'op'' : CLR or WinRT operator not valid. At least one parameter must be of the following types: 'T', 'T%', 'T&', 'T^', 'T^%', 'T^&', where T = 'your_type'  
  
 An operator in a Windows Runtime or managed type did not have at least one parameter whose type is the same as the type of the operator return value.  
  
 The following sample generates C2395 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>