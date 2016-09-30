---
title: "COleDataObject::GetGlobalData"
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
  - "GetGlobalData"
  - "COleDataObject.GetGlobalData"
  - "COleDataObject::GetGlobalData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataObject class, operations"
  - "GetGlobalData method"
ms.assetid: 36436061-6b80-4a96-b9df-2b165dbd5794
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject::GetGlobalData
Call this function to allocate a global memory block and to retrieve data in the specified format into an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The format in which data is to be returned. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which data is to be returned. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If it is **NULL**, the default values are used for the other fields in the **FORMATETC** structure.  
  
## Return Value  
 The handle of the global memory block containing the data if successful; otherwise **NULL**.  
  
## Remarks  
 For more information, see [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::GetData](../vs140/coledataobject--getdata.md)   
 [COleDataObject::GetFileData](../vs140/coledataobject--getfiledata.md)   
 [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md)