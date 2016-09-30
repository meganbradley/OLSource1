---
title: "IDebugEngine3::SetJustMyCodeState"
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
  - "IDebugEngine3::SetJustMyCodeState"
helpviewer_keywords: 
  - "IDebugEngine3::SetJustMyCodeState"
ms.assetid: 8ec17fbf-df93-424a-b2ed-fd1e5ee51256
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngine3::SetJustMyCodeState
This method tells the debug engine about the JustMyCode state information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Nonzero (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) to update current information, zero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) to reset all information (ignoring anything previously set).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Number of information structures in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Array of [JMC_CODE_SPEC](../vs140/jmc_code_spec.md) structures to use.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns error code.  
  
## Remarks  
 JustMyCode is the concept of debugging only the code that belongs to a user and ignoring all intermediate code such as system code—even if source code is available for that system code.  
  
## See Also  
 [IDebugEngine3](../vs140/idebugengine3.md)   
 [JMC_CODE_SPEC](../vs140/jmc_code_spec.md)