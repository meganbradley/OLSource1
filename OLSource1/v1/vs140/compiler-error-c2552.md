---
title: "Compiler Error C2552"
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
  - "C2552"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2552"
ms.assetid: 0e0ab759-788a-4faf-9337-80d4b9e2e8c9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2552
'identifier' : non-aggregates cannot be initialized with initializer list  
  
 The aggregate identifier was incorrectly initialized.  
  
 [Aggregates](../vs140/initializing-aggregate-types.md) are defined as:  
  
-   Arrays  
  
-   Classes, structures, and unions that do not have:  
  
    -   Constructors  
  
    -   Private or protected members  
  
    -   Base classes  
  
    -   Virtual functions  
  
 In addition, Visual C++ does not allow data types in an aggregate that contains constructors.  
  
 The following represent the reasons C2552 may fire when an aggregate initialization is attempted on a type:  
  
-   The type has one or more user-defined constructors.  
  
-   The type has one ore more non-static, private data members.  
  
-   The type has one or more virtual functions.  
  
-   The type has a base class.  
  
-   The type is a ref class or CLR interface.  
  
-   The type has a non-fixed dimension array (zero-array) whose elements have destructors.  
  
 The following sample generates C2552:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>