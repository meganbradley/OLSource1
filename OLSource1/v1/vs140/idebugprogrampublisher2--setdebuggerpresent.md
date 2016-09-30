---
title: "IDebugProgramPublisher2::SetDebuggerPresent"
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
  - "IDebugProgramPublisher2::SetDebuggerPresent"
helpviewer_keywords: 
  - "IDebugProgramPublisher2::SetDebuggerPresent"
ms.assetid: c88c3ff4-3632-4199-b5de-83c6d21bcf75
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramPublisher2::SetDebuggerPresent
Tells the program publisher that a debugger is present and running.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Non-zero (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) if a debugger is present, zero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) if it is not.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The presence or absence of a debugger is reflected in the data returned from the [IDebugProgramProvider2::GetProviderProcessData](../vs140/idebugprogramprovider2--getproviderprocessdata.md) method: the value returned there is set or cleared by a prior call to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.  
  
## See Also  
 [IDebugProgramPublisher2](../vs140/idebugprogrampublisher2.md)   
 [IDebugProgramProvider2::GetProviderProcessData](../vs140/idebugprogramprovider2--getproviderprocessdata.md)