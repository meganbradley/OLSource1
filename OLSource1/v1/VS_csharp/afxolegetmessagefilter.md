---
title: "AfxOleGetMessageFilter"
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
  - "AFXWIN/AfxOleGetMessageFilter"
  - "AfxOleGetMessageFilter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleGetMessageFilter function"
  - "application control"
ms.assetid: 36cca011-4775-4086-b471-5557a87b266c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleGetMessageFilter
Retrieves the application's current message filter.  
  
## Syntax  
  
```  
  
COleMessageFilter* AFXAPI AfxOleGetMessageFilter( );  
```  
  
## Return Value  
 A pointer to the current message filter.  
  
## Remarks  
 Call this function to access the current `COleMessageFilter`-derived object, just as you would call `AfxGetApp` to access the current application object.  
  
## Example  
 [!code[NVC_MFCAutomation#3](../VS_csharp/codesnippet/CPP/afxolegetmessagefilter_1.cpp)]  
  
 [!code[NVC_MFCAutomation#4](../VS_csharp/codesnippet/CPP/afxolegetmessagefilter_2.cpp)]  
  
## Requirements  
 **Header**: <afxwin.h>  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [COleMessageFilter Class](../VS_csharp/colemessagefilter-class.md)   
 [AfxGetApp](../VS_csharp/afxgetapp.md)