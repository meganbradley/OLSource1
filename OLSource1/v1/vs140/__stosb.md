---
title: "__stosb"
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
  - "__stosb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rep stosb instruction"
  - "__stosb intrinsic"
  - "stosb instruction"
ms.assetid: 634589ed-2da3-439b-a381-a214d89bf10c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __stosb
**Microsoft Specific**  
  
 Generates a store string instruction (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The destination of the operation.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The data to store.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The length of the block of bytes to write.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The result is that the character <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is written into a block of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> bytes in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> string.  
  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\***  
**\*@@@@@@\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\***   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)