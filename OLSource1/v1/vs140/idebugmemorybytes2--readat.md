---
title: "IDebugMemoryBytes2::ReadAt"
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
  - "IDebugMemoryBytes2::ReadAt"
helpviewer_keywords: 
  - "IDebugMemoryBytes2::ReadAt method"
  - "ReadAt method"
ms.assetid: b413684d-4155-4bd4-ae30-ffa512243b5f
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMemoryBytes2::ReadAt
Reads a sequence of bytes, starting at a given location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md) object that specifies where to start reading bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number of bytes to read. Also specifies the length of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in, out] Array filled in with the bytes actually read.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns the number of contiguous bytes actually read.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in, out] Returns the number of unreadable bytes. May be a null value if the client is uninterested in the number of unreadable bytes.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 If 100 bytes are requested and the first 50 are readable, the next 20 are unreadable, and the remaining 30 are readable, this method returns:  
  
 *<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> = 50  
  
 *<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> = 20  
  
 In this case, because <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the caller must make an additional call to read the remaining 30 bytes of the original 100 requested and the [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md) object passed in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter must be advanced by 70.  
  
## See Also  
 [IDebugMemoryBytes2](../vs140/idebugmemorybytes2.md)   
 [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md)