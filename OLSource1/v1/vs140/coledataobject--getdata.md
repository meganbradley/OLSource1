---
title: "COleDataObject::GetData"
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
  - "COleDataObject.GetData"
  - "COleDataObject::GetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataObject class, operations"
  - "GetData method [MFC]"
ms.assetid: 2bd45589-595a-4fed-b1f4-d652d1b45988
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject::GetData
Call this function to retrieve data from the item in the specified format.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The format in which data is to be returned. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure that will receive data.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which data is to be returned. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If it is **NULL**, the default values are used for the other fields in the **FORMATETC** structure.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 For more information, see [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431), [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812), and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::GetFileData](../vs140/coledataobject--getfiledata.md)   
 [COleDataObject::GetGlobalData](../vs140/coledataobject--getglobaldata.md)   
 [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md)