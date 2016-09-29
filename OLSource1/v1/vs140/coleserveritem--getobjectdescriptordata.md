---
title: "COleServerItem::GetObjectDescriptorData"
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
  - "GetObjectDescriptorData"
  - "COleServerItem.GetObjectDescriptorData"
  - "COleServerItem::GetObjectDescriptorData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, operations"
  - "GetObjectDescriptorData method"
ms.assetid: e09c920d-0458-4e9b-8df1-69a200708875
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::GetObjectDescriptorData
Call this function to get the **CF_OBJECTDESCRIPTOR** data for an OLE item.  
  
## Syntax  
  
```  
  
      void GetObjectDescriptorData(  
   LPPOINT lpOffset,  
   LPSIZE lpSize,  
   LPSTGMEDIUM lpStgMedium   
);  
```  
  
#### Parameters  
 `lpOffset`  
 Offset of the mouse click from the upper-left corner of the OLE item. Can be **NULL**.  
  
 `lpSize`  
 Size of the OLE item. Can be **NULL**.  
  
 `lpStgMedium`  
 Pointer to the [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure that will receive the **CF_OBJECTDESCRIPTOR** data for the OLE item.  
  
## Remarks  
 The information is copied into the **STGMEDIUM** structure pointed to by `lpStgMedium`. This format includes the information needed for the Paste Special dialog.  
  
 For more information, see [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::AddOtherClipboardData](../vs140/coleserveritem--addotherclipboarddata.md)   
 [COleServerItem::GetEmbedSourceData](../vs140/coleserveritem--getembedsourcedata.md)   
 [COleServerItem::GetLinkSourceData](../vs140/coleserveritem--getlinksourcedata.md)   
 [COlePasteSpecialDialog Class](../vs140/colepastespecialdialog-class.md)