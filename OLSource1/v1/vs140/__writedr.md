---
title: "__writedr"
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
  - "__writedr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__writedr intrinsic"
ms.assetid: ac55c1ee-df2f-41d4-a429-6f369d2a934d
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __writedr
Writes the specified value to the specified debug register.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A number from 0 through 7 that identifies the debug register.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value to write to the debug register.  
  
## Remarks  
 These intrinsics are available only in kernel mode, and the routines are available only as intrinsics.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [__readdr](../vs140/__readdr.md)