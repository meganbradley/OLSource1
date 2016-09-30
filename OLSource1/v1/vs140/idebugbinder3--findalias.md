---
title: "IDebugBinder3::FindAlias"
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
  - "IDebugBinder3::FindAlias"
helpviewer_keywords: 
  - "IDebugBinder3::FindAlias method"
ms.assetid: b8333701-2718-4983-8513-0875fb7cb730
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder3::FindAlias
This method locates an alias, given a name. This will search all aliases in the program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Name of alias to find.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Alias found (if any) represented by the [IDebugAlias](../vs140/idebugalias.md) interface.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (if alias is not found) or an error code.  
  
## Remarks  
 This method initializes the destination object to null before calling; then it tests for a null value afterward to determine whether or not the alias was found.  
  
## See Also  
 [IDebugBinder3](../vs140/idebugbinder3.md)   
 [IDebugAlias](../vs140/idebugalias.md)