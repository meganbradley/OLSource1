---
title: "COleDocument::UpdateModifiedFlag"
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
  - "UpdateModifiedFlag"
  - "COleDocument.UpdateModifiedFlag"
  - "COleDocument::UpdateModifiedFlag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateModifiedFlag method"
  - "COleDocument class, operations"
ms.assetid: 983415e1-8213-4a36-a462-97f7fd9a29d2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::UpdateModifiedFlag
Call this function to mark the document as modified if any of the contained OLE items have been modified.  
  
## Syntax  
  
```  
  
virtual void UpdateModifiedFlag( );  
```  
  
## Remarks  
 This allows the framework to prompt the user to save the document before closing, even if the native data in the document has not been modified.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::SetModifiedFlag](../vs140/cdocument--setmodifiedflag.md)   
 [COleClientItem::IsModified](../vs140/coleclientitem--ismodified.md)