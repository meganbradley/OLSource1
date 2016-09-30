---
title: "COleDropTarget::Register"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleDropTarget.Register"
  - "COleDropTarget::Register"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Register method"
  - "COleDropTarget class, operations"
ms.assetid: 6eb7df4b-a1d6-480a-8d08-5b2313392c05
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDropTarget::Register
Call this function to register your window with the OLE DLLs as a valid drop target.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the window that is to be registered as a drop target.  
  
## Return Value  
 Nonzero if registration is successful; otherwise 0.  
  
## Remarks  
 This function must be called for drop operations to be accepted.  
  
 For more information, see [RegisterDragDrop](http://msdn.microsoft.com/library/windows/desktop/ms678405) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDropTarget Class](../vs140/coledroptarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDropTarget::Revoke](../vs140/coledroptarget--revoke.md)   
 [COleDropTarget::COleDropTarget](../vs140/coledroptarget--coledroptarget.md)