---
title: "__outdword"
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
  - "__outdword"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "out instruction"
  - "outdword instruction"
  - "__outdword intrinsic"
ms.assetid: ed1e4994-a84b-4759-8bf9-cd48fb073f4d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __outdword
**Microsoft Specific**  
  
 Generates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> instruction to send a doubleword <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> out the port <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The port to send the data to.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The doubleword to be sent.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This routine is only available as an intrinsic.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)