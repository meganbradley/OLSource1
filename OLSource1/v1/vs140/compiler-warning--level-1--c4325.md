---
title: "Compiler Warning (level 1) C4325"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4325"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4325"
ms.assetid: 8127a08c-d626-481b-aa7b-04a3fdc9a9ec
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4325
**attributes for standard section '**   
 ***section* ' ignored**  
  
 You may not change the attributes of a standard section. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This would overwrite the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> standard section which uses the **short** data type with the **long** data type.  
  
 Standard sections whose attributes you may not change include,  
  
-   .data  
  
-   .sdata  
  
-   .bss  
  
-   .sbss  
  
-   .text  
  
-   .const  
  
-   .sconst  
  
-   .rdata  
  
-   .srdata  
  
 Additional sections may be added later.  
  
## See Also  
 [section](../vs140/section.md)