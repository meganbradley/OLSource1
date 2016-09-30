---
title: "IDebugCustomAttributeQuery::IsCustomAttributeDefined"
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
  - "IDebugCustomAttributeQuery::IsCustomAttributeDefined"
  - "IsCustomAttributeDefined"
ms.assetid: c7425db6-4347-4f69-8f88-337ddaa34fa6
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCustomAttributeQuery::IsCustomAttributeDefined
Determines if the specified custom attribute is defined.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Name of the custom attribute.  
  
## Return Value  
 If the custom attribute is defined, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows how to implement this method for a **CDebugClassFieldSymbol** object that exposes the [IDebugCustomAttributeQuery](../vs140/idebugcustomattributequery.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugCustomAttributeQuery](../vs140/idebugcustomattributequery.md)