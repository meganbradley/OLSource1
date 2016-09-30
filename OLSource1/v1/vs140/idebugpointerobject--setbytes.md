---
title: "IDebugPointerObject::SetBytes"
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
  - "IDebugPointerObject::SetBytes"
helpviewer_keywords: 
  - "IDebugPointerObject::SetBytes method"
ms.assetid: 8c578b38-38d7-46f3-bb2e-8a730fccd334
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPointerObject::SetBytes
Sets the value pointed to from a series of consecutive bytes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An offset, in bytes, from the start of the object pointed to.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number of bytes to set.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] An array of bytes representing the new value. This value is stored into the object, starting at the given offset.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns the number of bytes actually set.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method is used if the pointer as represented by this [IDebugPointerObject](../vs140/idebugpointerobject.md) points to a primitive type or a simple array of primitive types (that is, an array that can be represented by a simple sequence of bytes). This <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object cannot be a null reference (it must point to an address in memory).  
  
## See Also  
 [GetBytes](../vs140/idebugpointerobject--getbytes.md)   
 [IDebugPointerObject](../vs140/idebugpointerobject.md)