---
title: "IEnumDebugFrameInfo2::Next"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugFrameInfo2::Next"
helpviewer_keywords: 
  - "IEnumDebugFrameInfo2::Next"
ms.assetid: 64a64eeb-5dea-4119-8a22-03771015d1e5
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugFrameInfo2::Next
Returns the next set of elements from the enumeration.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The number of elements to retrieve. Also specifies the maximum size of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] Array of [FRAMEINFO](../vs140/frameinfo.md) elements to be filled in.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns the number of elements actually returned in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if fewer than the requested number of elements could be returned; otherwise, returns an error code.  
  
## See Also  
 [IEnumDebugFrameInfo2](../vs140/ienumdebugframeinfo2.md)   
 [FRAMEINFO](../vs140/frameinfo.md)