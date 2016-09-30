---
title: "Compiler Warning (level 1) C4772"
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
  - "C4772"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4772"
ms.assetid: dafe6fd8-9faf-41f5-9d66-a55838742c14
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4772
\#import referenced a type from a missing type library; 'missing_type' used as a placeholder  
  
 A type library was referenced with the [#import](../vs140/sharpimport-directive--c---.md) directive. However, the type library contained a reference to another type library that was not referenced with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This other .tlb file was not found by the compiler.  
  
 Note that the compiler will not find type libraries in different directories if you use the [/I (Additional Include Directories)](../vs140/-i--additional-include-directories-.md) compiler option to specify those directories. If you want the compiler to find type libraries in different directories, add those directories to the PATH environment variable.  
  
 This warning is, by default, issued as an error. C4772 can not be suppressed with /W0.  
  
## Example  
 This is the first type library needed to reproduce C4772.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This is the second type library needed to reproduce C4772.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C4772:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>