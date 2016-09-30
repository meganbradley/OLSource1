---
title: "Compiler Warning (level 1) C4532"
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
  - "C4532"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4532"
ms.assetid: 4e2a286a-d233-4106-9f65-29be1a94ca02
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4532
'continue' : jump out of __finally/finally block has undefined behavior during termination handling  
  
 The compiler encountered one of the following keywords:  
  
-   [continue](../vs140/continue-statement--c---.md)  
  
-   [break](../vs140/break-statement--c---.md)  
  
-   [goto](../vs140/goto-statement--c---.md)  
  
 causing a jump out of a [__finally](../vs140/try-finally-statement.md) or [finally](../vs140/finally.md) block during abnormal termination.  
  
 If an exception occurs, and while the stack is being unwound during execution of the termination handlers (the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or finally blocks), and your code jumps out of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block before the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block ends, the behavior is undefined. Control may not return to the unwinding code, so the exception may not be handled properly.  
  
 If you must jump out of a **__finally** block, check for abnormal termination first.  
  
 The following sample generates C4532; simply comment out the jump statements to resolve the warnings.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>