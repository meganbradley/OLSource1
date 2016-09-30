---
title: "IDebugProperty3::GetStringCharLength"
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
  - "IDebugProperty3::GetStringCharLength"
helpviewer_keywords: 
  - "IDebugProperty3::GetStringCharLength"
ms.assetid: 89a8676b-6da9-4358-91c2-039bf33f99e4
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty3::GetStringCharLength
Returns the number of characters in the associated property's string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|[out] Returns the number of characters in the property's string.|  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise returns error code.  
  
## Remarks  
 Typically, this method is used as a prelude to allocating a buffer for a call to the [IDebugProperty3::GetStringChars](../vs140/idebugproperty3--getstringchars.md) method.  
  
## Example  
 The following example shows how to implement this method for a **CProperty** object that exposes the [IDebugProperty3](../vs140/idebugproperty3.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugProperty3::GetStringChars](../vs140/idebugproperty3--getstringchars.md)   
 [IDebugProperty3](../vs140/idebugproperty3.md)