---
title: "COleDataObject::GetFileData"
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
  - "COleDataObject.GetFileData"
  - "GetFileData"
  - "COleDataObject::GetFileData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataObject class, operations"
  - "GetFileData method"
ms.assetid: 9bf5fc2f-297a-4667-ae24-e3ccce5ae00c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject::GetFileData
Call this function to create a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived object and to retrieve data in the specified format into a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The format in which data is to be returned. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which data is to be returned. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If it is **NULL**, the default values are used for the other fields in the **FORMATETC** structure.  
  
## Return Value  
 Pointer to the new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-derived object containing the data if successful; otherwise **NULL**.  
  
## Remarks  
 Depending on the medium the data is stored in, the actual type pointed to by the return value may be <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object accessed by the return value of this function is owned by the caller. It is the responsibility of the caller to **delete** the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object, thereby closing the file.  
  
 For more information, see [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::GetData](../vs140/coledataobject--getdata.md)   
 [COleDataObject::GetGlobalData](../vs140/coledataobject--getglobaldata.md)   
 [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md)