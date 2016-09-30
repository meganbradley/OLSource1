---
title: "IDebugArrayObject2::GetBaseIndices"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "GetBaseIndices"
  - "IDebugArrayObject2::GetBaseIndices"
ms.assetid: 882951a2-3da0-49bf-8d1e-7daedd13ffe6
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugArrayObject2::GetBaseIndices
Retrieves the base indices (lower bounds) for each index given the number of dimensions in the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number of dimensions (rank) of the array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] The base indices (lower bounds) for the array.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 As an example, this function would return ‘5’ for the array created by the following C# code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugArrayObject2](../vs140/idebugarrayobject2.md)