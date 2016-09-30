---
title: "IDiaEnumStackFrames::Next"
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
  - "IDiaEnumStackFrames::Next method"
ms.assetid: 09378a21-d5e3-4213-b7e2-10f04d85295f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumStackFrames::Next
Retrieves a specified number of stack frame elements from the enumeration sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 celt  
 [in] The number of stackframe elements in the enumerator to be retrieved.  
  
 rgelt  
 [out] An array that is to be filled in with the requested [IDiaStackFrame](../vs140/idiastackframe.md) objects.  
  
 pceltFetched  
 [out] Returns the number of stack frame elements in the fetched enumerator.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if there are no more stack frames. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumStackFrames](../vs140/idiaenumstackframes.md)   
 [IDiaStackFrame](../vs140/idiastackframe.md)