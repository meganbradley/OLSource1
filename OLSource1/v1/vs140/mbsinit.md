---
title: "mbsinit"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "mbsinit"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsinit"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbsinit function"
ms.assetid: 4618555b-baaa-4d04-93fa-36abae411034
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mbsinit
Tracks the state of a multibyte character conversion.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an [mbstate_t](../vs140/standard-types.md) variable.  
  
## Return Value  
 Nonzero if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is NULL or if not in the middle of a conversion.  
  
## Remarks  
 When using one of the ANSI functions that takes an **mbstate_t** pointer, passing the address of your <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will return information about whether the last byte in the buffer was converted.  
  
 The appropriate code page needs to be installed to support your multibyte characters.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)