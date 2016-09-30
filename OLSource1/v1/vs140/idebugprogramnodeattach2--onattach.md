---
title: "IDebugProgramNodeAttach2::OnAttach"
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
  - "IDebugProgramNodeAttach2::OnAttach"
helpviewer_keywords: 
  - "IDebugProgramNodeAttach2::OnAttach"
ms.assetid: 5fe52761-a508-4ab5-abdb-334fb6590334
caps.latest.revision: 7
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramNodeAttach2::OnAttach
Attaches to the associated program or defers the attach process to the [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md) method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to assign to the associated program.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md) method should not be called. Otherwise, returns an error code.  
  
## Remarks  
 This method is called during the attach process, before the [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md) method is called. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method can perform the attach process itself (in which case, this method returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) or defer the attach process to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method (the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>). In either event, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method can set the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> of the program being debugged to the given <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDebugProgramNodeAttach2](../vs140/idebugprogramnodeattach2.md)   
 [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md)