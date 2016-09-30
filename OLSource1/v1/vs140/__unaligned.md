---
title: "__unaligned"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__unaligned_cpp"
  - "__unaligned"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__unaligned keyword [C++]"
ms.assetid: 0cd83aad-1840-47e3-ad33-59bfcbe6375b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __unaligned
When you declare a pointer with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier, the compiler assumes that the pointer addresses data that is not aligned. Consequently, for an application that targets an Itanium Processor Family (IPF) computer, the compiler generates code that reads the unaligned data one byte at a time.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier is valid for the [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] and [!INCLUDE[vcpritanium](../vs140/includes/vcpritanium_md.md)] compilers but affects only applications that target an IPF computer. This modifier describes the alignment of the addressed data only; the pointer itself is assumed to be aligned.  
  
 The [!INCLUDE[vcpritanium](../vs140/includes/vcpritanium_md.md)] processor generates an alignment fault when it accesses misaligned data, and the time to process the fault weakens performance. Use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier to cause the processor to read data one byte at a time and avoid the fault. This modifier is not required for [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] applications because the [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] processor handles misaligned data without faulting.  
  
 For more information about alignment, see:  
  
-   [align (C++)](../vs140/align--c---.md)  
  
-   [__alignof Operator](../vs140/__alignof-operator.md)  
  
-   [pack](../vs140/pack.md)  
  
-   [/Zp (Struct Member Alignment)](../vs140/-zp--struct-member-alignment-.md)  
  
-   [Structure Alignment Examples](../vs140/examples-of-structure-alignment.md)  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Keywords](../vs140/keywords--c---.md)