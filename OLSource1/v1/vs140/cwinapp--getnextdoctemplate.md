---
title: "CWinApp::GetNextDocTemplate"
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
  - "GetNextDocTemplate"
  - "CWinApp.GetNextDocTemplate"
  - "CWinApp::GetNextDocTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "document templates, retrieving"
  - "GetNextDocTemplate method"
ms.assetid: ed60a32e-e37b-4a32-9efa-ce1454876286
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::GetNextDocTemplate
Gets the document template identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the **POSITION** value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous call to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or [GetFirstDocTemplatePosition](../vs140/cwinapp--getfirstdoctemplateposition.md). The value is updated to the next position by this call.  
  
## Return Value  
 A pointer to a [CDocTemplate](../vs140/cdoctemplate-class.md) object.  
  
## Remarks  
 You can use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in a forward iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 You must ensure that your **POSITION** value is valid. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved document template is the last available, then the new value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to **NULL**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::AddDocTemplate](../vs140/cwinapp--adddoctemplate.md)