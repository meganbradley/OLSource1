---
title: "IDebugCustomAttributeQuery::GetCustomAttributeByName"
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
  - "IDebugCustomAttributeQuery::GetCustomAttributeByName"
  - "GetCustomAttributeByName"
ms.assetid: 6779727c-d10a-4abe-9acd-d0a1eb0737e7
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCustomAttributeQuery::GetCustomAttributeByName
Retrieves a custom attribute given its name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Name of the custom attribute.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in,out] Array of bytes that contain the custom attribute data.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Length in bytes of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If custom attribute does not exist, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugClassFieldSymbol** object that exposes the [IDebugCustomAttributeQuery](../vs140/idebugcustomattributequery.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugCustomAttributeQuery](../vs140/idebugcustomattributequery.md)