---
title: "COleDataSource::OnSetData"
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
  - "COleDataSource::OnSetData"
  - "COleDataSource.OnSetData"
  - "OnSetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataSource class, operations"
  - "OnSetData method"
ms.assetid: 65ef3be5-f152-4d94-a6b0-600836e09f61
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource::OnSetData
Called by the framework to set or replace the data in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object in the specified format.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which data is being replaced.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure containing the data that will replace the current contents of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Indicates who has ownership of the storage medium after completing the function call. The caller decides who is responsible for releasing the resources allocated on behalf of the storage medium. The caller does this by setting <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is nonzero, the data source takes ownership, freeing the medium when it has finished using it. When <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is 0, the caller retains ownership and the data source can use the storage medium only for the duration of the call.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The data source does not take ownership of the data until it has successfully obtained it. That is, it does not take ownership if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns 0. If the data source takes ownership, it frees the storage medium by calling the [ReleaseStgMedium](http://msdn.microsoft.com/library/windows/desktop/ms693491) function.  
  
 The default implementation does nothing. Override this function to replace the data in the specified format. This is an advanced overridable.  
  
 For more information, see the [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structures and the [ReleaseStgMedium](http://msdn.microsoft.com/library/windows/desktop/ms693491) and [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) functions in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::DelaySetData](../vs140/coledatasource--delaysetdata.md)   
 [COleDataSource::OnRenderData](../vs140/coledatasource--onrenderdata.md)   
 [COleDataSource::OnRenderFileData](../vs140/coledatasource--onrenderfiledata.md)   
 [COleDataSource::OnRenderGlobalData](../vs140/coledatasource--onrenderglobaldata.md)   
 [COleServerItem::OnSetData](../vs140/coleserveritem--onsetdata.md)