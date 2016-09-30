---
title: "Compiler Warning (level 4) C4564"
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
  - "C4564"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4564"
ms.assetid: 555b301b-313e-4262-9f81-eb878674be60
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4564
method 'method' of class 'class' defines unsupported default parameter 'parameter'  
  
 The compiler detected a method with one or more parameters with default values. The default value(s) for the parameters will be ignored when the method is invoked; explicitly specify values for those parameters. If you do not explicitly specify values for those parameters, the C++ compiler will generate an error.  
  
 Given the following .dll created with Visual Basic, which allows default parameters on method arguments:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 And the following C++ sample that uses the .dll created with Visual Basic,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>