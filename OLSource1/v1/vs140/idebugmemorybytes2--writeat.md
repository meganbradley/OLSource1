---
title: "IDebugMemoryBytes2::WriteAt"
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
  - "IDebugMemoryBytes2::WriteAt"
helpviewer_keywords: 
  - "IDebugMemoryBytes2::WriteAt method"
  - "WriteAt method"
ms.assetid: 61cc3704-47fa-4d9b-aa62-bb4585ac8fb1
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMemoryBytes2::WriteAt
Writes the specified number of bytes of memory, starting at the specified address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md) object that specifies where to start writing bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number of bytes to write.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The bytes to write. This array is assumed to be at least <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> bytes in size.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if not all bytes could be written or returns an error code (typically <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>).  
  
## Remarks  
 If the starting address is not within the memory window represented by this [IDebugMemoryBytes2](../vs140/idebugmemorybytes2.md) object, no writing occurs and an error code of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is returned — even if the amount to write overlaps into the memory space.  
  
## See Also  
 [IDebugMemoryBytes2](../vs140/idebugmemorybytes2.md)   
 [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md)