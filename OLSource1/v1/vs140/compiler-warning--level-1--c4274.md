---
title: "Compiler Warning (level 1) C4274"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C4274"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4274"
ms.assetid: 5a948680-7ed1-469f-978d-ae99d154e161
caps.latest.revision: 17
---
# Compiler Warning (level 1) C4274
\#ident ignored; see documentation for #pragma comment(exestr, 'string')  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> directive, which inserts a user-specified string in the object or executable file, is deprecated. Consequently, the compiler ignores the directive.  
  
> [!CAUTION]
>  Warning C4274 advises you to use the [#pragma comment(exestr, 'string')](../vs140/comment--c-c---.md) directive. However, this advice is deprecated and will be revised in a future release of the compiler. If you use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directive, the linker tool (LINK.exe) ignores the comment record produced by the directive and issues warning [LNK4229](../vs140/linker-tools-warning-lnk4229.md). Instead of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive, we recommend that you use a [file version resource string](_win32_Version_Information) in your application.  
  
### To correct this error  
  
-   Remove the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>*string*<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive.  
  
## See Also  
 [comment (C/C++)](../vs140/comment--c-c---.md)   
 [Linker Tools Warning LNK4229](../vs140/linker-tools-warning-lnk4229.md)   
 [Version Information](_win32_Version_Information)   
 [Working with Resource Files](../vs140/working-with-resource-files.md)