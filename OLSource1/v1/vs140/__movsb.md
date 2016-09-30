---
title: "__movsb"
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
  - "__movsb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "movsb instruction"
  - "rep movsb instruction"
  - "__movsb intrinsic"
ms.assetid: ba5469f6-f797-4cd2-bee8-74c7666c26d4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __movsb
**Microsoft Specific**  
  
 Generates a Move String (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) instruction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the destination of the copy.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the source of the copy.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of bytes to copy.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The result is that the first <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> bytes pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are copied to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> string.  
  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **A big black dog. A big black dog.**   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)