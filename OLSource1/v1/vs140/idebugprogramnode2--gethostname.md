---
title: "IDebugProgramNode2::GetHostName"
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
  - "IDebugProgramNode2::GetHostName"
helpviewer_keywords: 
  - "IDebugProgramNode2::GetHostName"
ms.assetid: 16aad1ff-ad34-4394-a2e4-5621374a7729
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramNode2::GetHostName
Gets the name of the process hosting the program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A value from the [GETHOSTNAME_TYPE](../vs140/gethostname_type.md) enumeration that specifies the type of name to return.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns the name of the hosting process.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that exposes the [IDebugProgramNode2](../vs140/idebugprogramnode2.md) interface. This example ignores the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter and returns only the name of the program as taken from the base name of the module's file path.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)   
 [GETHOSTNAME_TYPE](../vs140/gethostname_type.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)