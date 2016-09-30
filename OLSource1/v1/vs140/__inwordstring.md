---
title: "__inwordstring"
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
  - "__inwordstring"
  - "__inwordstring_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__inwordstring intrinsic"
  - "rep insw instruction"
ms.assetid: 6de37939-017a-4740-9e3d-7de78a30daba
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __inwordstring
**Microsoft Specific**  
  
 Reads data from the specified port using the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> instruction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The port to read from.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The data read from the port is written here.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of words of data to read.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This routine is only available as an intrinsic.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)