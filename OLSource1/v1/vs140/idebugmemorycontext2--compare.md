---
title: "IDebugMemoryContext2::Compare"
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
  - "IDebugMemoryContext2::Compare"
helpviewer_keywords: 
  - "IDebugMemoryContext2::Compare method"
  - "Compare method"
ms.assetid: c51b5128-848e-4d8e-b2e9-1161339763c3
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMemoryContext2::Compare
Compares the memory context to each context in the given array in the manner indicated by compare flags, returning an index of the first context that matches.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A value from the [CONTEXT_COMPARE](../vs140/context_compare.md) enumeration that determines the type of comparison.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An array of references to the [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md) objects to compare against.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The number of contexts in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns the index of the first memory context that satisfies the comparison.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the two contexts cannot be compared.  
  
## Remarks  
 A debug engine (DE) does not have to support all types of comparisons, but it must support at least <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md)   
 [CONTEXT_COMPARE](../vs140/context_compare.md)