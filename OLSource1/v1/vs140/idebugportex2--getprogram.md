---
title: "IDebugPortEx2::GetProgram"
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
  - "IDebugPortEx2::GetProgram"
helpviewer_keywords: 
  - "IDebugPortEx2::GetProgram"
ms.assetid: cd83a111-bfd5-4eae-b576-526466c6b6ec
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortEx2::GetProgram
Gets the program associated with a program node.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugProgramNode2](../vs140/idebugprogramnode2.md) object representing the program node.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugProgram2](../vs140/idebugprogram2.md) object that represents the program associated with the program node.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortEx2](../vs140/idebugportex2.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)