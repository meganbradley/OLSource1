---
title: "IDiaFrameData::get_lengthLocals"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaFrameData::get_lengthLocals method"
ms.assetid: 51fe15c3-4cd6-4a06-8a41-a56502209762
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaFrameData::get_lengthLocals
Retrieves the number of bytes of local variables pushed on the stack.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns the number of bytes of local variables.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The value returned by this method is typically used in the interpretation of a program string (see the [IDiaFrameData::get_program](../vs140/idiaframedata--get_program.md) method for the definition of a program string).  
  
## See Also  
 [IDiaFrameData](../vs140/idiaframedata.md)   
 [IDiaFrameData::get_program](../vs140/idiaframedata--get_program.md)