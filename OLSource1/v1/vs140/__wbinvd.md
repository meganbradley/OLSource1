---
title: "__wbinvd"
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
  - "__wbinvd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__wbinvd intrinsic"
  - "wbinvd instruction"
ms.assetid: 628d0981-39e5-49e1-bd43-706d123af121
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __wbinvd
**Microsoft Specific**  
  
 Generates the Write Back and Invalidate Cache (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) instruction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This function is only available in kernel mode with a privilege level (CPL) of 0, and the routine is only available as an intrinsic.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)