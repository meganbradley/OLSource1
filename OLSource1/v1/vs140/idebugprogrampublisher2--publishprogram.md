---
title: "IDebugProgramPublisher2::PublishProgram"
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
  - "IDebugProgramPublisher2::PublishProgram"
helpviewer_keywords: 
  - "IDebugProgramPublisher2::PublishProgram"
ms.assetid: 92ff63f0-e869-4040-b3ae-b2c899e708ff
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramPublisher2::PublishProgram
This method makes a program available for debug engines (DEs) and the session debug manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An array of GUIDs for DEs that can launch or attach to this program.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Friendly name for the program (this appears in menus or dialogs presented to the user).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface for the program (this value is used as a cookie to uniquely identify the program; this same value is used to "unpublish" the program)  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 To make a program no longer available for debugging, call [IDebugProgramPublisher2::UnpublishProgram](../vs140/idebugprogrampublisher2--unpublishprogram.md).  
  
## See Also  
 [IDebugProgramPublisher2](../vs140/idebugprogrampublisher2.md)   
 [IDebugProgramPublisher2::UnpublishProgram](../vs140/idebugprogrampublisher2--unpublishprogram.md)