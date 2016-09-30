---
title: "IDebugCustomAttribute::GetAttributeBytes"
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
  - "IDebugCustomAttribute::GetAttributeBytes"
helpviewer_keywords: 
  - "IDebugCustomAttribute::GetAttributeBytes"
ms.assetid: cf34583b-6530-4dcc-89f8-eb27e4e8d594
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCustomAttribute::GetAttributeBytes
Gets the attribute information as a blob of bytes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in, out] An array that is filled in with the attribute bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in, out] Specifies the maximum number of bytes to return in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> array and returns the number of bytes actually written to the array.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Set the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter to a null value to return the number of attributes bytes available. Then allocate an array and pass that array in for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.  
  
 The attribute bytes represent the raw data of the custom attribute.  
  
## See Also  
 [IDebugCustomAttribute](../vs140/idebugcustomattribute.md)