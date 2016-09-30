---
title: "IDiaFrameData::get_allocatesBasePointer"
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
  - "IDiaFrameData::get_allocatesBasePointer method"
ms.assetid: 8a33db5d-008c-4fe5-b64f-210c9b77f686
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaFrameData::get_allocatesBasePointer
Retrieves a flag that indicates whether the base pointer is allocated for code in this address range. This method is deprecated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if a base pointer is allocated; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 This property should be used only by code that formerly accessed FPO_DATA, or when the program string returned by the [IDiaFrameData::get_program](../vs140/idiaframedata--get_program.md) method is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Otherwise, the program string contains all the information needed to compute previous register values.  
  
## See Also  
 [IDiaFrameData](../vs140/idiaframedata.md)   
 [IDiaFrameData::get_program](../vs140/idiaframedata--get_program.md)