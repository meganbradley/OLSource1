---
title: "COleStreamFile::Attach"
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
  - "COleStreamFile::Attach"
  - "COleStreamFile.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleStreamFile class, attributes and operations"
  - "Attach method [MFC]"
ms.assetid: 42e11c35-aca6-40b5-92f3-659497830575
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleStreamFile::Attach
Associates the supplied OLE stream with the `COleStreamFile` object.  
  
## Syntax  
  
```  
  
      void Attach(  
   LPSTREAM lpStream   
);  
```  
  
#### Parameters  
 `lpStream`  
 Points to the OLE stream (`IStream`) to be associated with the object. Cannot be **NULL**.  
  
## Remarks  
 The object must not already be associated with an OLE stream.  
  
 For more information, see [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleStreamFile Class](../vs140/colestreamfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleStreamFile::Detach](../vs140/colestreamfile--detach.md)