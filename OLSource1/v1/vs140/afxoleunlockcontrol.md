---
title: "AfxOleUnlockControl"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxOleUnlockControl"
  - "AFXWIN/AfxOleUnlockControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleUnlockControl function"
ms.assetid: 721503cb-c47a-40c3-b620-f870b2980f26
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleUnlockControl
Unlocks the class factory of the specified control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The unique class ID of the control.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The unique program ID of the control.  
  
## Return Value  
 Nonzero if the class factory of the control was successfully unlocked; otherwise 0.  
  
## Remarks  
 A control is locked with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, so that dynamically created data associated with the control remains in memory. This can significantly speed up display of the control because the control need not be created and destroyed every time it is displayed. When you are ready to destroy the control, call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCAutomation#9](../vs140/codesnippet/CPP/afxoleunlockcontrol_1.cpp)]  
  
## Requirements  
 **Header:** \<afxwin.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxOleLockControl](../vs140/afxolelockcontrol.md)