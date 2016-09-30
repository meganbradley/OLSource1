---
title: "Compiler Warning (level 1) C4581"
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
  - "C4581"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4581"
ms.assetid: 598bcd87-257d-4eb3-94e4-15bb31aadc99
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4581
deprecated behavior: '"string1"' replaced with 'string2' to process attribute  
  
 This error can be generated as a result of compiler conformance work that was done for Visual C++ 2005: parameter checking for Visual C++ attributes.  
  
 In previous versions, attribute values were accepted whether or not they were enclosed in quotation marks. If the value is an enumeration, it must not be enclosed in quotation marks.  
  
## Example  
 The following sample generates C4581.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>