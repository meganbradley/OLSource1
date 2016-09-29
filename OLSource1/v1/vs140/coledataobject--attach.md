---
title: "COleDataObject::Attach"
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
  - "COleDataObject.Attach"
  - "COleDataObject::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataObject class, operations"
  - "Attach method [MFC]"
ms.assetid: ac454ec6-69cd-45e6-8377-ba00eaf8394b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject::Attach
Call this function to associate the `COleDataObject` object with an OLE data object.  
  
## Syntax  
  
```  
  
      void Attach(  
   LPDATAOBJECT lpDataObject,  
   BOOL bAutoRelease = TRUE   
);  
```  
  
#### Parameters  
 *lpDataObject*  
 Points to an OLE data object.  
  
 `bAutoRelease`  
 **TRUE** if the OLE data object should be released when the `COleDataObject` object is destroyed; otherwise **FALSE**.  
  
## Remarks  
 For more information, see [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::AttachClipboard](../vs140/coledataobject--attachclipboard.md)   
 [COleDataObject::Detach](../vs140/coledataobject--detach.md)   
 [COleDataObject::Release](../vs140/coledataobject--release.md)