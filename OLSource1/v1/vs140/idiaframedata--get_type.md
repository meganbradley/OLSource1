---
title: "IDiaFrameData::get_type"
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
  - "IDiaFrameData::get_type method"
ms.assetid: efca38b5-c479-4d0a-a164-f903f25c5509
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaFrameData::get_type
Retrieves the compiler-specific frame type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns a value from the [StackFrameTypeEnum](../vs140/stackframetypeenum.md) enumeration that indicates the compiler-specific frame type.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaFrameData](../vs140/idiaframedata.md)   
 [StackFrameTypeEnum](../vs140/stackframetypeenum.md)