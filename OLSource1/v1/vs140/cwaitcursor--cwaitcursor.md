---
title: "CWaitCursor::CWaitCursor"
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
  - "CWaitCursor::CWaitCursor"
  - "CWaitCursor.CWaitCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWaitCursor class, constructor"
ms.assetid: f96cdfeb-9d12-427c-bead-a69fc873d735
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWaitCursor::CWaitCursor
To display a wait cursor, just declare a `CWaitCursor` object before the code that performs the lengthy operation.  
  
## Syntax  
  
```  
  
CWaitCursor( );  
  
```  
  
## Remarks  
 The constructor automatically causes the wait cursor to be displayed.  
  
 When the object goes out of scope (at the end of the block in which the `CWaitCursor` object is declared), its destructor sets the cursor to the previous cursor. In other words, the object performs the necessary clean-up automatically.  
  
 You can take advantage of the fact that the destructor is called at the end of the block (which might be before the end of the function) to make the wait cursor active in only part of your function. This technique is shown in the second example below.  
  
> [!NOTE]
>  Because of how their constructors and destructors work, `CWaitCursor` objects are always declared as local variables — they're never declared as global variables, nor are they allocated with **new**.  
  
## Example  
 [!code[NVC_MFCWindowing#63](../vs140/codesnippet/CPP/cwaitcursor--cwaitcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWaitCursor Class](../vs140/cwaitcursor-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWaitCursor::Restore](../vs140/cwaitcursor--restore.md)   
 [CCmdTarget::BeginWaitCursor](../vs140/ccmdtarget--beginwaitcursor.md)   
 [CCmdTarget::EndWaitCursor](../vs140/ccmdtarget--endwaitcursor.md)