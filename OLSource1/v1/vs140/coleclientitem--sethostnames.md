---
title: "COleClientItem::SetHostNames"
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
  - "COleClientItem::SetHostNames"
  - "COleClientItem.SetHostNames"
  - "SetHostNames"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, embedded object operations"
  - "SetHostNames method"
ms.assetid: 23b86a27-9029-40e7-9161-ff46a1aa9708
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::SetHostNames
Call this function to specify the name of the container application and the container's name for an embedded OLE item.  
  
## Syntax  
  
```  
  
      void SetHostNames(  
   LPCTSTR lpszHost,  
   LPCTSTR lpszHostObj   
);  
```  
  
#### Parameters  
 `lpszHost`  
 Pointer to the user-visible name of the container application.  
  
 `lpszHostObj`  
 Pointer to an identifying string of the container that contains the OLE item.  
  
## Remarks  
 If the server application was written using the Microsoft Foundation Class Library, this function calls the [OnSetHostNames](../vs140/coleserverdoc--onsethostnames.md) member function of the `COleServerDoc` document that contains the OLE item. This information is used in window titles when the OLE item is being edited. Each time a container document is loaded, the framework calls this function for all the OLE items in the document. `SetHostNames` is applicable only to embedded items. It is not necessary to call this function each time an embedded OLE item is activated for editing.  
  
 This is also called automatically with the application name and document name when an object is loaded or when a file is saved under a different name. Accordingly, it is not usually necessary to call this function directly.  
  
 For more information, see [IOleObject::SetHostNames](http://msdn.microsoft.com/library/windows/desktop/ms680642) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::OnSetHostNames](../vs140/coleserverdoc--onsethostnames.md)