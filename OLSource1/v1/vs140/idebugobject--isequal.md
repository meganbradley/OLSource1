---
title: "IDebugObject::IsEqual"
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
  - "IDebugObject::IsEqual"
helpviewer_keywords: 
  - "IDebugObject::IsEqual method"
ms.assetid: 4b76e663-ef2e-41ff-9be1-bf26d666a34a
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugObject::IsEqual
Compares an object with this object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugObject](../vs140/idebugobject.md) object representing the object to compare to.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns non-zero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) if the values of the objects are equal; otherwise, returns zero (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Typically, this method can compare the addresses of the values represented by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter and this [IDebugObject](../vs140/idebugobject.md) object; if the addresses are equal, then the objects can be considered equal.  
  
## See Also  
 [IDebugObject](../vs140/idebugobject.md)