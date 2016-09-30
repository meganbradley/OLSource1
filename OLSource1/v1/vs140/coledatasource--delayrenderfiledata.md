---
title: "COleDataSource::DelayRenderFileData"
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
  - "COleDataSource.DelayRenderFileData"
  - "DelayRenderFileData"
  - "COleDataSource::DelayRenderFileData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataSource class, operations"
  - "DelayRenderFileData method"
ms.assetid: 7b1bf05c-2e8d-4458-8c4a-81899273109d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource::DelayRenderFileData
Call this function to specify a format in which data is offered during data transfer operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The Clipboard format in which the data is to be offered. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which the data is to be offered. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If it is **NULL**, default values are used for the other fields in the **FORMATETC** structure.  
  
## Remarks  
 This function provides the data using delayed rendering, so the data is not supplied immediately. The [OnRenderFileData](../vs140/coledatasource--onrenderfiledata.md) member function is called to request the data.  
  
 Use this function if you are going to use a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to supply the data. If you are not going to use a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object, call the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) member function. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 To use immediate rendering, call the [CacheData](../vs140/coledatasource--cachedata.md) or [CacheGlobalData](../vs140/coledatasource--cacheglobaldata.md) member function.  
  
 For more information, see the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 For more information, see [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::CacheData](../vs140/coledatasource--cachedata.md)   
 [COleDataSource::CacheGlobalData](../vs140/coledatasource--cacheglobaldata.md)   
 [COleDataSource::DelayRenderData](../vs140/coledatasource--delayrenderdata.md)   
 [COleDataSource::OnRenderFileData](../vs140/coledatasource--onrenderfiledata.md)