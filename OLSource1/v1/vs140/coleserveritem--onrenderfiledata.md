---
title: "COleServerItem::OnRenderFileData"
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
  - "COleServerItem.OnRenderFileData"
  - "COleServerItem::OnRenderFileData"
  - "OnRenderFileData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRenderFileData method"
  - "COleServerItem class, overridables"
ms.assetid: 23425063-aac3-4c94-8eaa-7506906d7b03
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnRenderFileData
Called by the framework to retrieve data in the specified format when the storage medium is a file.  
  
## Syntax  
  
```  
  
      virtual BOOL OnRenderFileData(  
   LPFORMATETC lpFormatEtc,  
   CFile* pFile   
);  
```  
  
#### Parameters  
 `lpFormatEtc`  
 Points to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 `pFile`  
 Points to a `CFile` object in which the data is to be rendered.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The specified format is one previously placed in the `COleDataSource` object using the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 This is an advanced overridable. Override this function to provide your data in the requested format and medium. Depending on your data, you might want to override one of the other versions of this function instead. If you want to handle multiple storage mediums, override [OnRenderData](../vs140/coleserveritem--onrenderdata.md). If your data is in a file, or is of variable size, override [OnRenderFileData](#_mfc_coleserveritem.3a3a.onrenderfiledata).  
  
 For more information, see [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnRenderData](../vs140/coleserveritem--onrenderdata.md)