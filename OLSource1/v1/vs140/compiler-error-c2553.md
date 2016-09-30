---
title: "Compiler Error C2553"
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
  - "C2553"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2553"
ms.assetid: 64bc1e9a-627f-4ce9-b7bc-dc911bdb9180
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2553
'base_function': overriding virtual function return type differs from 'override_function'  
  
 A function in a derived class attempted to override a virtual function in a base class, but the derived class function did not have the same return type as the base class function.  An override function signature must match the signature of the function being overridden.  
  
 The following sample generates C2553:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>