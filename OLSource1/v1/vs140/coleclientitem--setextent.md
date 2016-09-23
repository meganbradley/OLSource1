---
title: "COleClientItem::SetExtent"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleClientItem.SetExtent
  - SetExtent
  - COleClientItem::SetExtent
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleClientItem class, embedded object operations
  - SetExtent method
ms.assetid: 98bfc69e-b04a-48ee-926a-05c943f10ce2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::SetExtent
Call this function to specify how much space is available to the OLE item.  
  
## Syntax  
  
```  
  
      void SetExtent(  
   const CSize& size,  
   DVASPECT nDrawAspect = DVASPECT_CONTENT   
);  
```  
  
#### Parameters  
 `size`  
 A [CSize](../vs140/csize-class.md) object that contains the size information.  
  
 `nDrawAspect`  
 Specifies the aspect of the OLE item whose bounds are to be set. For possible values, see [SetDrawAspect](../vs140/coleclientitem--setdrawaspect.md).  
  
## Remarks  
 If the server application was written using the Microsoft Foundation Class Library, this causes the [OnSetExtent](../vs140/coleserveritem--onsetextent.md) member function of the corresponding `COleServerItem` object to be called. The OLE item can then adjust its display accordingly. The dimensions must be in `MM_HIMETRIC` units. Call this function when the user resizes the OLE item or if you support some form of layout negotiation.  
  
 For more information, see [IOleObject::SetExtent](http://msdn.microsoft.com/library/windows/desktop/ms694330) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::GetExtent](../vs140/coleclientitem--getextent.md)   
 [COleClientItem::GetCachedExtent](../vs140/coleclientitem--getcachedextent.md)   
 [COleServerItem::OnSetExtent](../vs140/coleserveritem--onsetextent.md)