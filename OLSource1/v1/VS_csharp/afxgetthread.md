---
title: "AfxGetThread"
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
  - "AfxGetThread"
  - "AFXWIN/AfxGetThread"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxGetThread function"
ms.assetid: 75e7a519-c7e2-4ab0-ae05-20bb53e5df08
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxGetThread
Call this function to get a pointer to the [CWinThread](../VS_csharp/cwinthread-class.md) object representing the currently executing thread.  
  
## Syntax  
  
```  
  
CWinThread* AfxGetThread( );  
```  
  
## Return Value  
 Pointer to the currently executing thread; otherwise **NULL**.  
  
## Remarks  
 Must be called from within the desired thread.  
  
> [!NOTE]
>  If you are porting an MFC project calling `AfxGetThread` from Visual C++ versions 4.2, 5.0, or 6.0, `AfxGetThread` calls [AfxGetApp](../VS_csharp/afxgetapp.md) if no thread is found. In Visual C+ .NET and later, `AfxGetThread` returns **NULL** if no thread was found. If you want the application thread, you must call `AfxGetApp`.  
  
## Example  
 [!code[NVC_MFCWindowing#132](../VS_csharp/codesnippet/CPP/afxgetthread_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [AfxBeginThread](../VS_csharp/afxbeginthread.md)