---
title: "CDocument::OnDocumentEvent"
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
  - "CDocument::OnDocumentEvent"
  - "CDocument.OnDocumentEvent"
  - "OnDocumentEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDocumentEvent method"
ms.assetid: 17f619a0-127b-4ab3-984f-f50bf12e5ce1
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::OnDocumentEvent
Called by the framework in response to a document event.  
  
## Syntax  
  
```  
virtual void OnDocumentEvent(  
   DocumentEvent deEvent  
);  
```  
  
#### Parameters  
 [in] `deEvent`  
 An enumerated data type that describes the type of event.  
  
## Remarks  
 Document events may affect multiple classes. This method is responsible for handling document events that affect classes other than the [CDocument Class](../vs140/cdocument-class.md). Currently, the only class that must respond to document events is the [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md). The `CDocument` class has other overrideable methods responsible for handling the effect on the `CDocument`.  
  
 The following table lists the possible values for `deEvent` and the events that they correspond to.  
  
|Value|Corresponding Event|  
|-----------|-------------------------|  
|`onAfterNewDocument`|A new document was created.|  
|`onAfterOpenDocument`|A new document was opened.|  
|`onAfterSaveDocument`|The document was saved.|  
|`onAfterCloseDocument`|The document was closed.|  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [How to: Add Restart Manager Support](../vs140/how-to--add-restart-manager-support.md)