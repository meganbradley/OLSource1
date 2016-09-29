---
title: "Math Error M6111"
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
  - "M6111"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "M6111"
ms.assetid: c0fc13f8-33c8-4e3f-a440-126cc623441b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Math Error M6111
stack underflow  
  
 A floating-point operation resulted in a stack underflow on the 8087/287/387 coprocessor or the emulator.  
  
 This error is often caused by a call to a `long double` function that does not return a value. For example, the following generates this error when compiled and run:  
  
```  
long double ld() {};  
main ()  
{  
  ld();  
}  
```  
  
 Program terminates with exit code 139.