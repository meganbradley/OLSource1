---
title: "COleServerItem::OnInitFromData"
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
  - "COleServerItem::OnInitFromData"
  - "COleServerItem.OnInitFromData"
  - "OnInitFromData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnInitFromData method"
  - "COleServerItem class, overridables"
ms.assetid: 75e6a155-110f-43b9-8839-d8f745475b7a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnInitFromData
Called by the framework to initialize an OLE item using the contents of `pDataObject`.  
  
## Syntax  
  
```  
  
      virtual BOOL OnInitFromData(  
   COleDataObject* pDataObject,  
   BOOL bCreation   
);  
```  
  
#### Parameters  
 `pDataObject`  
 Pointer to an OLE data object containing data in various formats for initializing the OLE item.  
  
 `bCreation`  
 **TRUE** if the function is called to initialize an OLE item being newly created by a container application. **FALSE** if the function is called to replace the contents of an already existing OLE item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 If `bCreation` is **TRUE**, this function is called if a container implements Insert New Object based on the current selection. The data selected is used when creating the new OLE item. For example, when selecting a range of cells in a spreadsheet program and then using the Insert New Object to create a chart based on the values in the selected range. The default implementation does nothing. Override this function to choose an acceptable format from those offered by `pDataObject` and initialize the OLE item based on the data provided. This is an advanced overridable.  
  
 For more information, see [IOleObject::InitFromData](http://msdn.microsoft.com/library/windows/desktop/ms688510) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)