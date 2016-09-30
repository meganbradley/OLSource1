---
title: "Compiler Warning (Level 1) C4789"
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
  - "C4789"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4789"
ms.assetid: 5800c301-5afb-4af0-85c1-ceb54d775234
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (Level 1) C4789
buffer 'identifier' of size N bytes will be overrun; M bytes will be written starting at offset L  
  
 Warns about buffer overrun when specific C run-time (CRT) functions are used, parameters are passed, and assignments are performed, such that the data sizes are known at compile time. This warning is for situations that might elude typical data-size mismatch detection.  
  
 The warning appears when data, whose length is known at compile time, is copied and put into a data block whose size is known at compile time to be too small for the data. The copy must be done by using the intrinsic form of one of the following CRT functions:  
  
-   [strcpy](../vs140/strcpy--wcscpy--_mbscpy.md)  
  
-   [memset](../vs140/memset--wmemset.md)  
  
-   [memcpy](../vs140/memcpy--wmemcpy.md), [wmemcpy](../vs140/memcpy--wmemcpy.md)  
  
 The warning also appears when a parameter datatype is mismatched by using a cast, and then a copy assignment from an lvalue reference is attempted.  
  
 Visual C++ might generate this warning for a code path that does not ever execute. You can temporarily disable the warning by using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, as shown in this example:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 This keeps Visual C++ from generating the warning for that specific block of code. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> preserves the existing state before <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> changes it. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> restores the pushed state, and removes the effects of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For more information about the C++ preprocessor directive <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, see [warning](../vs140/warning.md) and [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md).  
  
## Example  
 The following sample generates C4789.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample also generates C4789.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>