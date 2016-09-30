---
title: "CPen::FromHandle"
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
  - "CPen.FromHandle"
  - "CPen::FromHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromHandle method [MFC]"
  - "CPen class, operations"
ms.assetid: 4c9ce849-8fed-4e7c-b8ab-e94e750d4a38
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPen::FromHandle
Returns a pointer to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object given a handle to a Windows GDI pen object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *hPen*  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> handle to Windows GDI pen.  
  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object if successful; otherwise **NULL**.  
  
## Remarks  
 If a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is not attached to the handle, a temporary <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object is created and attached. This temporary <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object is valid only until the next time the application has idle time in its event loop, at which time all temporary graphic objects are deleted. In other words, the temporary object is only valid during the processing of one window message.  
  
## Example  
 [!code[NVC_MFCDocView#105](../vs140/codesnippet/CPP/cpen--fromhandle_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPen Class](../vs140/cpen-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)