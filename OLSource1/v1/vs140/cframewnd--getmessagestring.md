---
title: "CFrameWnd::GetMessageString"
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
  - "CFrameWnd::GetMessageString"
  - "GetMessageString"
  - "CFrameWnd.GetMessageString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMessageString method"
  - "CFrameWnd class, operations"
ms.assetid: 79619a94-5909-4d95-af8a-0a78a6c8104b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::GetMessageString
Override this function to provide custom strings for command IDs.  
  
## Syntax  
  
```  
  
      virtual void GetMessageString(  
   UINT nID,  
   CString& rMessage   
) const;  
```  
  
#### Parameters  
 `nID`  
 Resource ID of the desired message.  
  
 `rMessage`  
 `CString` object into which to place the message.  
  
## Remarks  
 The default implementation simply loads the string specified by `nID` from the resource file. This function is called by the framework when the message string in the status bar needs updating.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::SetMessageText](../vs140/cframewnd--setmessagetext.md)