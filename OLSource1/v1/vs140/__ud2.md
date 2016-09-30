---
title: "__ud2"
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
  - "__ud2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UD2 instruction"
  - "__ud2 intrinsic"
ms.assetid: 0831cd5a-8b65-402e-bb57-11e1d5d7ffd2
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __ud2
**Microsoft Specific**  
  
 Generates an undefined instruction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The processor raises an invalid opcode exception if you execute an undefined instruction.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function is equivalent to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> machine instruction, and is available only in kernel mode. For more information, search for the document, "Intel Architecture Software Developer's Manual, Volume 2: Instruction Set Reference," at the [Intel Corporation](http://go.microsoft.com/fwlink/?LinkId=127) site.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## Example  
 The following example executes an undefined instruction, which raises an exception. The exception handler then changes the return code from zero to one.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Before __ud2(). Return code = 0.**  
 **In the exception handler.**  
**After __ud2().  Return code = 1.**   
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)