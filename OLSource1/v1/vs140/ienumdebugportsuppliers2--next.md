---
title: "IEnumDebugPortSuppliers2::Next"
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
  - "IEnumDebugPortSuppliers2::Next"
helpviewer_keywords: 
  - "IEnumDebugPortSuppliers2::Next"
ms.assetid: e2a2d226-e70b-42c2-bf00-a936517940c8
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugPortSuppliers2::Next
Returns the next set of elements from the enumeration.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The number of elements to retrieve. Also specifies the maximum size of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] Array of [IDebugPortSupplier2](../vs140/idebugportsupplier2.md) elements to be filled in.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns the number of elements actually returned in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if fewer than the requested number of elements could be returned; otherwise, returns an error code.  
  
## See Also  
 [IEnumDebugPortSuppliers2](../vs140/ienumdebugportsuppliers2.md)   
 [IDebugPortSupplier2](../vs140/idebugportsupplier2.md)