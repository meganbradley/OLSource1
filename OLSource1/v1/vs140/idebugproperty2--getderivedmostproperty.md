---
title: "IDebugProperty2::GetDerivedMostProperty"
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
  - "IDebugProperty2::GetDerivedMostProperty"
helpviewer_keywords: 
  - "IDebugProperty2::GetDerivedMostProperty"
ms.assetid: cc86b461-62d1-4340-8209-c65037fd8b02
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty2::GetDerivedMostProperty
Gets the derived-most property of a property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugProperty2](../vs140/idebugproperty2.md) object that represents the derived-most property.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise returns error code. Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if there is no derived-most property to retrieve.  
  
## Remarks  
 For example, if this property describes an object that implements <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> but which is actually an instantiation of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that is derived from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, then this method returns an [IDebugProperty2](../vs140/idebugproperty2.md) object describing the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
## See Also  
 [IDebugProperty2](../vs140/idebugproperty2.md)