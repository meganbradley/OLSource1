---
title: "IDebugProcessEx2::AddImplicitProgramNodes"
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
  - "IDebugProcessEx2::AddImplicitProgramNodes"
helpviewer_keywords: 
  - "IDebugProcessEx2::AddImplicitProgramNodes method"
ms.assetid: 8b491b00-f9e7-45b3-9115-fe58c3464289
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcessEx2::AddImplicitProgramNodes
This method adds a program node for each debug engine (DE) specified.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of a DE that is to be used to launch programs (and is assumed to add its own program nodes).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Array of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>s of DEs for which program nodes will be added.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The number of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>s in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> array.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 [Program Nodes](../vs140/program-nodes.md) will be added for each DE listed in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>—excluding the launching engine (as given in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>), which is assumed to add its own program node when it launches a program.  
  
## See Also  
 [IDebugProgramEx2](../vs140/idebugprogramex2.md)   
 [Program Nodes](../vs140/program-nodes.md)