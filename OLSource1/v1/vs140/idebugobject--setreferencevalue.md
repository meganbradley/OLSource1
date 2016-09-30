---
title: "IDebugObject::SetReferenceValue"
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
  - "IDebugObject::SetReferenceValue"
helpviewer_keywords: 
  - "IDebugObject::SetReferenceValue method"
ms.assetid: 08c78a4e-98eb-41cb-8b75-02a6a43d49f7
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugObject::SetReferenceValue
Sets the reference value of this object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugObject](../vs140/idebugobject.md) object representing the new reference value.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method makes this [IDebugObject](../vs140/idebugobject.md) object a reference to the value of the object given in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter, throwing away any previous reference. Note that this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object must already be a reference type.  
  
## See Also  
 [IDebugObject](../vs140/idebugobject.md)   
 [GetValue](../vs140/idebugobject--getvalue.md)