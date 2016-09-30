---
title: "COleDataSource::OnRenderFileData"
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
  - "OnRenderFileData"
  - "COleDataSource.OnRenderFileData"
  - "COleDataSource::OnRenderFileData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRenderFileData method"
  - "COleDataSource class, operations"
ms.assetid: 1ac8edfc-3798-4c4e-bdd0-600b5c70195c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource::OnRenderFileData
Called by the framework to retrieve data in the specified format when the specified storage medium is a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [CFile](../vs140/cfile-class.md) object in which the data is to be rendered.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The specified format is one previously placed in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object using the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 This is an advanced overridable. Override this function to supply your data in the requested format and medium. Depending on your data, you might want to override one of the other versions of this function instead. If you want to handle multiple storage media, override [OnRenderData](../vs140/coledatasource--onrenderdata.md). If your data is in a file, or is of variable size, override <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 For more information, see the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure and [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::DelayRenderData](../vs140/coledatasource--delayrenderdata.md)   
 [COleDataSource::DelayRenderFileData](../vs140/coledatasource--delayrenderfiledata.md)   
 [COleDataSource::OnRenderData](../vs140/coledatasource--onrenderdata.md)   
 [COleDataSource::OnRenderGlobalData](../vs140/coledatasource--onrenderglobaldata.md)   
 [COleDataSource::OnSetData](../vs140/coledatasource--onsetdata.md)   
 [CFile Class](../vs140/cfile-class.md)