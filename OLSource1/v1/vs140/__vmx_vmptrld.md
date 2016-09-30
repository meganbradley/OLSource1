---
title: "__vmx_vmptrld"
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
  - "__vmx_vmptrld"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__vmx_vmptrld intrinsic"
  - "VMPTRLD instruction"
ms.assetid: 95c9ec5b-1a81-41ba-983e-327bd6a65fcb
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __vmx_vmptrld
**Microsoft Specific**  
  
 Loads the pointer to the current virtual-machine control structure (VMCS) from the specified address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] *<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The address where the VMCS pointer is stored.  
  
## Return Value  
 0  
 The operation succeeded.  
  
 1  
 The operation failed with extended status available in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of the current VMCS.  
  
 2  
 The operation failed without status available.  
  
## Remarks  
 The VMCS pointer is a 64-bit physical address.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function is equivalent to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> machine instruction. This function supports the interaction of a host's virtual machine monitor with a guest operating system and its applications. For more information, search for the document, "Intel Virtualization Technical Specification for the IA-32 Intel Architecture," document number C97063-002, at the [Intel Corporation](http://go.microsoft.com/fwlink/?LinkId=127) site.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [__vmx_vmptrst](../vs140/__vmx_vmptrst.md)