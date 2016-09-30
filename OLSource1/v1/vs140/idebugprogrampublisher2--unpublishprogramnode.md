---
title: "IDebugProgramPublisher2::UnpublishProgramNode"
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
  - "IDebugProgramPublisher2::UnpublishProgramNode"
helpviewer_keywords: 
  - "IDebugProgramPublisher2::UnpublishProgramNode"
ms.assetid: 57c7e6e1-b84e-4e14-ad83-cbbb64e2f526
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramPublisher2::UnpublishProgramNode
Removes a specified program node from availability to debug engines (DEs) and the session debug manager (SDM).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugProgramNode2](../vs140/idebugprogramnode2.md) object representing the program node being removed.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Once removed, the program node is no longer available to be queried for program information.  
  
 To make a program node available, call the [IDebugProgramPublisher2::PublishProgramNode](../vs140/idebugprogrampublisher2--publishprogramnode.md) method.  
  
## See Also  
 [IDebugProgramPublisher2](../vs140/idebugprogrampublisher2.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)   
 [IDebugProgramPublisher2::PublishProgramNode](../vs140/idebugprogrampublisher2--publishprogramnode.md)