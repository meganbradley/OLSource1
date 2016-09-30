---
title: "__svm_stgi"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "__svm_stgi"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__svm_stgi intrinsic"
  - "STGI instruction"
ms.assetid: 96488da4-5587-4e99-8674-627a9e51be84
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __svm_stgi
**Microsoft Specific**  
  
 Sets the global interrupt flag.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function is equivalent to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> machine instruction. The global interrupt flag determines whether the microprocessor ignores, postpones, or handles interrupts due to events such as an I/O completion, a hardware temperature alert, or a debug exception.  
  
 This function supports the interaction of a host's virtual machine monitor with a guest operating system and its applications. For more information, search for the document, "AMD64 Architecture Programmer's Manual Volume 2: System Programming," document number 24593, revision 3.11, at the [AMD corporation](http://go.microsoft.com/fwlink/?LinkId=23746) site.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [__svm_clgi](../vs140/__svm_clgi.md)