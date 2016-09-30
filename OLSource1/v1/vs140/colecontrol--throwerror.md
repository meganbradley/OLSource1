---
title: "COleControl::ThrowError"
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
  - "COleControl::ThrowError"
  - "COleControl.ThrowError"
  - "ThrowError"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ThrowError method"
ms.assetid: 5177e2a8-a065-414f-92db-55fdad35875a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::ThrowError
Signals the occurrence of an error in your control.  
  
## Syntax  
  
```  
  
      void ThrowError(  
   SCODE sc,  
   UINT nDescriptionID,  
   UINT nHelpID = -1   
);  
void ThrowError(  
   SCODE sc,  
   LPCTSTR pszDescription = NULL,  
   UINT nHelpID = 0   
);  
```  
  
#### Parameters  
 `sc`  
 The status code value to be reported. For a complete list of possible codes, see the article [ActiveX Controls: Advanced Topics](../vs140/mfc-activex-controls--advanced-topics.md).  
  
 `nDescriptionID`  
 The string resource ID of the exception to be reported.  
  
 `nHelpID`  
 The help ID of the topic to be reported on.  
  
 `pszDescription`  
 A string containing an explanation of the exception to be reported.  
  
## Remarks  
 This function should only be called from within a Get or Set function for an OLE property, or the implementation of an OLE automation method. If you need to signal errors that occur at other times, you should fire the stock Error event.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::FireError](../vs140/colecontrol--fireerror.md)   
 [COleControl::DisplayError](../vs140/colecontrol--displayerror.md)