---
title: "IDebugDocumentTextEvents2"
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
  - "IDebugDocumentTextEvents2"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents2 interface"
ms.assetid: a10cbb6b-11a8-4056-b42a-2ecebf0e690d
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentTextEvents2
This interface is used to notify Visual Studio about changes to the source document that are supplied by the debug engine.  
  
## Syntax  
  
```  
IDebugDocumentTextEvents2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to support making changes to the source code. This interface is typically implemented on the same object that implements the [IDebugDocument2](../vs140/idebugdocument2.md) interface.  
  
## Notes for Callers  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] obtains this interface through a call to the <xref:System.Runtime.InteropServices.ComTypes.IConnectionPoint.Advise*> method. The <xref:System.Runtime.InteropServices.ComTypes.IConnectionPoint*> interface is obtained from a call to the <xref:System.Runtime.InteropServices.ComTypes.IConnectionPointContainer.EnumConnectionPoints*> method. The <xref:System.Runtime.InteropServices.ComTypes.IConnectionPointContainer*> interface is obtained by calling the [QueryInterface](../vs140/queryinterface.md) method on an [IDebugDocument2](../vs140/idebugdocument2.md) interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugDocumentTextEvents2`.  
  
|Method|Description|  
|------------|-----------------|  
|[onDestroy](../vs140/idebugdocumenttextevents2--ondestroy.md)|Indicates that the entire document has been destroyed.|  
|[onInsertText](../vs140/idebugdocumenttextevents2--oninserttext.md)|Notifies the debug package that text has been inserted into the document.|  
|[onRemoveText](../vs140/idebugdocumenttextevents2--onremovetext.md)|Notifies the debug package that text has been removed from the document.|  
|[onReplaceText](../vs140/idebugdocumenttextevents2--onreplacetext.md)|Notifies the debug package that text has been replaced in the document.|  
|[onUpdateTextAttributes](../vs140/idebugdocumenttextevents2--onupdatetextattributes.md)|Notifies the debug package that text attributes have been updated in the document.|  
|[onUpdateDocumentAttributes](../vs140/idebugdocumenttextevents2--onupdatedocumentattributes.md)|Notifies receiver of the event that the document attributes have been updated.|  
  
## Remarks  
 Only debug engines that supply their own documents would take advantage of the `IDebugDocumentTextEvent2` interface. An example of this would be a scripting debug engine. In the process of interpreting scripts, new source code can be generated that is not present in any disk file and is known only to the DE.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugDocumentText2](../vs140/idebugdocumenttext2.md)   
 [IDebugDocument2](../vs140/idebugdocument2.md)