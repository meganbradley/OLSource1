---
title: "Compiler Warning (level 1) C4526"
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
  - "C4526"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4526"
ms.assetid: 490f8916-5fdc-4cad-b412-76c3382a5976
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4526
'function' : static member function cannot override virtual function 'virtual function'override ignored, virtual function will be hidden  
  
 The static member function meets the criteria to override the virtual function, which makes the member function both virtual and static.  
  
 The following code generates C4526:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following are possible fixes:  
  
-   If the function was intended to override the base class virtual function, remove the static specifier.  
  
-   If the function was intended to be a static member function, rename it so it doesn't conflict with the base class virtual function.