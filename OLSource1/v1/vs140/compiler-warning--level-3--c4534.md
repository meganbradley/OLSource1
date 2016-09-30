---
title: "Compiler Warning (level 3) C4534"
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
  - "c4534"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4534"
ms.assetid: ec2adf3b-d7a1-4005-bb0c-5d219df78dc8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4534
'constructor' will not be a default constructor for class 'class' due to the default argument  
  
 An unmanaged class can have a constructor with parameters that have default values and the compiler will use this as the default constructor. A class marked with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword will not use a constructor with default values for its parameters as a default constructor.  
  
 For more information, see [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md).  
  
 The following sample generates C4534:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>