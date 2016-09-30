---
title: "IDiaStackWalkFrame::searchForReturnAddressStart"
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
  - "IDiaStackWalkFrame::searchForReturnAddressStart method"
ms.assetid: 47660b9b-6e4f-4dfa-88ab-63dce28f7412
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalkFrame::searchForReturnAddressStart
Searches the specified stack frame for a return address at or near the specified address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] An [IDiaFrameData](../vs140/idiaframedata.md) object that represents the current stack frame.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A virtual memory address from which to begin searching.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the nearest function return address to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkFrame](../vs140/idiastackwalkframe.md)   
 [IDiaFrameData](../vs140/idiaframedata.md)