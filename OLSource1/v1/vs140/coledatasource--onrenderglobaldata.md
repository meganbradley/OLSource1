---
title: "COleDataSource::OnRenderGlobalData"
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
  - "COleDataSource.OnRenderGlobalData"
  - "COleDataSource::OnRenderGlobalData"
  - "OnRenderGlobalData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataSource class, operations"
  - "OnRenderGlobalData method"
ms.assetid: 41a5e7c0-609f-4fcf-a4ac-311aaa11dc1e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource::OnRenderGlobalData
Called by the framework to retrieve data in the specified format when the specified storage medium is global memory.  
  
## Syntax  
  
```  
  
      virtual BOOL OnRenderGlobalData(  
   LPFORMATETC lpFormatEtc,  
   HGLOBAL* phGlobal   
);  
```  
  
#### Parameters  
 `lpFormatEtc`  
 Points to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 `phGlobal`  
 Points to a handle to global memory in which the data is to be returned. If one has not yet been allocated, this parameter can be **NULL**.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The specified format is one previously placed in the `COleDataSource` object using the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 If `phGlobal` is **NULL**, then a new `HGLOBAL` should be allocated and returned in `phGlobal`. Otherwise, the `HGLOBAL` specified by `phGlobal` should be filled with the data. The amount of data placed in the `HGLOBAL` must not exceed the current size of the memory block. Also, the block cannot be reallocated to a larger size.  
  
 This is an advanced overridable. Override this function to supply your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If you want to handle multiple storage media, override [OnRenderData](../vs140/coledatasource--onrenderdata.md). If your data is in a file, or is of variable size, override [OnRenderFileData](../vs140/coledatasource--onrenderfiledata.md). For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 For more information, see the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure and [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::DelayRenderData](../vs140/coledatasource--delayrenderdata.md)   
 [COleDataSource::DelayRenderFileData](../vs140/coledatasource--delayrenderfiledata.md)   
 [COleDataSource::OnRenderData](../vs140/coledatasource--onrenderdata.md)   
 [COleDataSource::OnRenderFileData](../vs140/coledatasource--onrenderfiledata.md)   
 [COleDataSource::OnSetData](../vs140/coledatasource--onsetdata.md)