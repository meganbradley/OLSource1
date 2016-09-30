---
title: "__outwordstring"
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
  - "__outwordstring"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rep outsw instruction"
  - "__outwordstring intrinsic"
  - "outsw instruction"
ms.assetid: b470c7a0-1de9-4370-886a-b2c3a1f842f4
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __outwordstring
**Microsoft Specific**  
  
 Generates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> instruction, which sends <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> words starting at <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> out the I/O port specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The port to send the data to.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the data to be sent out the specified port.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The number of words to send.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This routine is only available as an intrinsic.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)