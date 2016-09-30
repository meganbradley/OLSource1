---
title: "COleDataSource::CacheGlobalData"
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
  - "CacheGlobalData"
  - "COleDataSource::CacheGlobalData"
  - "COleDataSource.CacheGlobalData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CacheGlobalData method"
  - "COleDataSource class, operations"
ms.assetid: 20cfee14-8c75-41f7-a58d-62b50d4c84f3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource::CacheGlobalData
Call this function to specify a format in which data is offered during data transfer operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The Clipboard format in which the data is to be offered. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 *hGlobal*  
 Handle to the global memory block containing the data in the format specified.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which the data is to be offered. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If it is **NULL**, default values are used for the other fields in the **FORMATETC** structure.  
  
## Remarks  
 This function provides the data using immediate rendering, so you must supply the data when calling the function; the data is cached until needed. Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function if you are supplying a large amount of data or if you require a structured storage medium.  
  
 To use delayed rendering, call the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) or [DelayRenderFileData](../vs140/coledatasource--delayrenderfiledata.md) member function. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 For more information, see the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 For more information, see [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::CacheData](../vs140/coledatasource--cachedata.md)   
 [COleDataSource::DelayRenderData](../vs140/coledatasource--delayrenderdata.md)   
 [COleDataSource::DelayRenderFileData](../vs140/coledatasource--delayrenderfiledata.md)