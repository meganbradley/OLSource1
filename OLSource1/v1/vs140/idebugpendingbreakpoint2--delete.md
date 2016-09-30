---
title: "IDebugPendingBreakpoint2::Delete"
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
  - "IDebugPendingBreakpoint2::Delete"
helpviewer_keywords: 
  - "IDebugPendingBreakpoint2::Delete method"
  - "Delete method"
ms.assetid: 4cb5ed81-6f0c-41ce-a770-5adb6b4bf5d9
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPendingBreakpoint2::Delete
Deletes this pending breakpoint and all breakpoints bound from it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the breakpoint has been deleted.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that implements the [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)