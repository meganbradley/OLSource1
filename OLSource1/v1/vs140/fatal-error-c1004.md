---
title: "Fatal Error C1004"
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
  - "C1004"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1004"
ms.assetid: dbe034b0-6eb0-41b4-a50c-2fccf9e78ad4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1004
unexpected end of file found  
  
 The compiler reached the end of a source file without resolving a construct. The code may be missing one of the following elements:  
  
-   A closing brace  
  
-   A closing parenthesis  
  
-   A closing comment marker (*/)  
  
-   A semicolon  
  
 To resolve this error, check for the following:  
  
-   The default disk drive has insufficient space for temporary files, which require about twice as much space as the source file.  
  
-   An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive that evaluates to false lacks a closing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive.  
  
-   A source file does not end with a carriage return and line feed.  
  
 The following sample generates C1004:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>