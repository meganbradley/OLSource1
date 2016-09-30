---
title: "IDebugActivateDocumentEvent2"
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
  - "IDebugActivateDocumentEvent2"
helpviewer_keywords: 
  - "IDebugActivateDocumentEvent2 interface"
ms.assetid: 6f37edd7-a48c-4b41-b160-dff9be63a284
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugActivateDocumentEvent2
The debug engine (DE) uses this interface to request a document to be loaded.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 The DE implements this interface when it needs a source file to be opened. This interface is implemented only by debug engines that work with or are a part of script interpreters. The [IDebugEvent2](../vs140/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](../vs140/queryinterface.md) to access the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface).  
  
## Notes for Callers  
 The DE creates and sends this event object when it needs to have a source file opened. The event is sent by using the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Methods|Description|  
|-------------|-----------------|  
|[GetDocument](../vs140/idebugactivatedocumentevent2--getdocument.md)|Gets the document to activate.|  
|[GetDocumentContext](../vs140/idebugactivatedocumentevent2--getdocumentcontext.md)|Gets the document context that describes the position within the document.|  
  
## Remarks  
 A typical scenario in which this interface is used is if a parse error occurs in script code on an HTML page, the script DE sends this interface to the SDM so that the document with the parse error can be displayed.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugDocument2](../vs140/idebugdocument2.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)